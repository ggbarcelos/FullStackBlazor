using System.ComponentModel.DataAnnotations;

namespace Fina.Core.Requests.Categories;

public class CreateCategoryRequest : Request
{
    [Required(ErrorMessage = "O Título é obrigatório.")]
    [MaxLength(80, ErrorMessage = "O Título deve ter no máximo 80 caracteres.")]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "A Descrição é obrigatória.")]
    public string Description { get; set; } = string.Empty;
}