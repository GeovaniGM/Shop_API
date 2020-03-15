using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Esse campo é obrigatório")]
        [MinLength(3, ErrorMessage = "Esse campo deve conter entre 3 e 20 caracteres")]
        [MaxLength(20, ErrorMessage = "Esse campo deve conter entre 3 e 20 caracteres")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Esse campo é obrigatório")]
        [MinLength(3, ErrorMessage = "Esse campo deve conter entre 3 e 20 caracteres")]
        [MaxLength(20, ErrorMessage = "Esse campo deve conter entre 3 e 20 caracteres")]
        public string Password { get; set; }

        public string Role { get; set; }
    }
}