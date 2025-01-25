using Mds.Blazor.Web.Services.Abstractions;
using Mds.Blazor.Web.ViewModels;
using Microsoft.AspNetCore.Components;

namespace Mds.Blazor.Web.Shared.Components.Pages.Pizzas;

public sealed partial class PizzaForm
{
    private PizzaViewModel pizza = new();
    private PateViewModel[] availablePates = [];
    private IngredientViewModel[] availableIngredients = [];

    [Parameter]
    public int PizzaId { get; set; }

    [Inject]
    public IPizzaService PizzaService { get; set; } = null!;

    [Inject]
    public IPateService PateSevice { get; set; } = null!;

    [Inject]
    public IIngredientService IngredientService { get; set; } = null!;

    [Inject]
    public NavigationManager Navigation { get; set; } = null!;

    protected override void OnInitialized()
    {
        this.availableIngredients = this.IngredientService.GetAll()
            .Select(x => new IngredientViewModel
            {
                Id = x.Id,
                Name = x.Name,
                KCal = x.Kcal,
            })
            .ToArray();

        this.availablePates = this.PateSevice.GetAll()
            .Select(x => new PateViewModel
            {
                Id = x.Id,
                Name = x.Name
            })
            .ToArray();

        base.OnInitialized();
    }

    private void OnValidSubmitHandler()
    {
        this.PizzaService.Add(new()
        {
            Name = pizza.Name,
            Ingredients = pizza.IngredientsIds.ToList(),
            PateId = pizza.PateId,
            Size = pizza.Size,
        });

        this.Navigation.NavigateTo("/pizzas");

    }
}
