using System.ComponentModel.DataAnnotations;

namespace apilivros.Models
{
    public class Category
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage ="Campo obrigatório")]
        [MaxLength(60,ErrorMessage ="tamanho do caracter deve ser menor que 60")]
        [MinLength(3,ErrorMessage ="tamanho do caracter deve ser maior que 3")]
        public string title { get; set; }
    }
}
