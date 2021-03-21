using Microsoft.EntityFrameworkCore;
using apilivros.Models;

namespace apilivros.DataContext
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Products> Products { get; set; }
    }
}
