using Mds.Blazor.Web.Services.Models;
using System.ComponentModel.DataAnnotations;

namespace Mds.Blazor.Web.ViewModels;

public sealed class PizzaViewModel
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    public int PateId { get; set; }

    public int[] IngredientsIds { get; set; } = [];

    public PizzaSize Size { get; set; }
}
