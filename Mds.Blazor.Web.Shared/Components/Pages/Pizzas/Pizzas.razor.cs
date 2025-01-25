using Mds.Blazor.Web.Mappings;
using Mds.Blazor.Web.Services.Abstractions;
using Mds.Blazor.Web.ViewModels;
using Microsoft.AspNetCore.Components;

namespace Mds.Blazor.Web.Shared.Components.Pages.Pizzas;

public sealed partial class Pizzas
{
    private List<PizzaDisplayViewModel> pizzaCollection = [];

    [Inject]
    public IPizzaService PizzaService { get; set; } = null!;

    [Inject]
    public IIngredientService IngredientService { get; set; } = null!;

    [Inject]
    public IPateService PateService { get; set; } = null!;

    protected override void OnInitialized()
    {
        this.pizzaCollection = this.PizzaService.GetAll()
            .Select(x => new PizzaDisplayViewModel
            {
                Id = x.Id,
                Ingredients = this.IngredientService.GetAll()
                    .Where(i => x.Ingredients.Contains(i.Id))
                    .Select(i => new IngredientViewModel 
                    {
                        Id = i.Id,
                        KCal = i.Kcal,
                        Name = i.Name,
                    }).ToList(),
                Name = x.Name,
                Pate = this.PateService.GetById(x.PateId)?.ToViewModel() ?? new(),
                Size = x.Size,
            }).ToList();

        base.OnInitialized();
    }
}
