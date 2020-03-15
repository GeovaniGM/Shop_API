using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Título é obrigatório")]
        [MinLength(3, ErrorMessage = "Título deve conter entre 3 e 60 caracteres.")]
        [MaxLength(60, ErrorMessage = "Título deve conter entre 3 e 60 caracteres.")]
        public string Title { get; set; }

        [MaxLength(1024, ErrorMessage = "A descrição pode conter até 1024 caracteres")]
        public string Desciption { get; set; }

        [Required(ErrorMessage = "Esse campo é obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "O preço deve ser maior que zero")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Esse campo é obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "Categoria inválida")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}