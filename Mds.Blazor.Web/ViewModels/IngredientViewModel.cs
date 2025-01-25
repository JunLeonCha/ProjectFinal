using System.ComponentModel.DataAnnotations;

namespace Mds.Blazor.Web.ViewModels;

public sealed class IngredientViewModel
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    [Required]
    [Range(1, int.MaxValue)]
    public int KCal { get; set; }
}
