using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using apilivros.Models;
using apilivros.DataContext;
using System.Linq;

namespace apilivros.Controllers
{
    [ApiController]
    [Route("v1/products")]

    public class ProductsController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Products>>> Get([FromServices] DBContext context)
        {
            var products = await context.Products.Include(x => x.Category).ToListAsync();
            return products;

        }
        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Products>> GetById([FromServices] DBContext context, int id)
        {
            var product = await context.Products.Include(x => x.Category).AsNoTracking().FirstOrDefaultAsync(x => x.id == id);
            return product;
        }

        [HttpGet]
        [Route("categories/{id:int}")]
        public async Task<ActionResult<List<Products>>> GetByCategory([FromServices] DBContext context, int id)
        {
            var product = await context.Products
                .Include(x => x.Category)
                .AsNoTracking()
                .Where(x => x.CategoryId == id)
                .ToListAsync();

            return product;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Products>> Post([FromServices] DBContext dBContext, [FromBody] Products products)
        {
            if (ModelState.IsValid)
            {
                dBContext.Products.Add(products);
                await dBContext.SaveChangesAsync();
                return products;
            }
            else
            {
                return BadRequest(ModelState);
            }
        }


    }

  
}
