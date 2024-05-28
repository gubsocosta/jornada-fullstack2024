using System.ComponentModel.DataAnnotations;

namespace Fina.Core.Requests.Categories;

public class UpdateCategoryRequest : Request
{
    public long Id { get; set; }

    [Required(ErrorMessage = "{0} is invalid")]
    [MaxLength(80, ErrorMessage = "{0} must be {1}")]
    public string Title { get; set; }

    [Required(ErrorMessage = "{0} is invalid")]
    public string Description { get; set; } = string.Empty;

}
