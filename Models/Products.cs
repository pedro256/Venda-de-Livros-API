using System.ComponentModel.DataAnnotations;

namespace apilivros.Models
{
    public class Products
    {

        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(60, ErrorMessage = "tamanho do caracter deve ser menor que 60")]
        [MinLength(3, ErrorMessage = "tamanho do caracter deve ser maior que 3")]
        public string title { get; set; }


        [MaxLength(1024, ErrorMessage = "tamanho do caracter deve ser menor que 1024")]
        [MinLength(3, ErrorMessage = "tamanho do caracter deve ser maior que 3")]
        public string description { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage ="valor invalido !!")]
        public decimal price { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "id de categoria invalido !!")]
        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
