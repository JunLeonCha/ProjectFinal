using Mds.Blazor.Web.Services.Models;

namespace Mds.Blazor.Web.ViewModels;

public sealed class PizzaDisplayViewModel
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public PateViewModel Pate { get; set; } = new();

    public List<IngredientViewModel> Ingredients { get; set; } = [];

    public PizzaSize Size { get; set; }

    public int KCal => this.Ingredients.Sum(x => x.KCal);
}
