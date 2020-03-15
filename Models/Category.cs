using System.ComponentModel.DataAnnotations;

public class Category
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Título é obrigatório")]
    [MinLength(3, ErrorMessage = "Título deve conter entre 3 e 60 caracteres.")]
    [MaxLength(60, ErrorMessage = "Título deve conter entre 3 e 60 caracteres.")]
    public string Title { get; set; }
}