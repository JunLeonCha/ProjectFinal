using Mds.Blazor.Web.Services.Abstractions;
using Mds.Blazor.Web.ViewModels;
using Microsoft.AspNetCore.Components;

namespace Mds.Blazor.Web.Shared.Components.Pages.Ingredients;

public sealed partial class IngredientsForm
{
    private IngredientViewModel ingredient = new();

    [Parameter]
    public int IngredientId { get; set; }

    [Inject]
    public IIngredientService IngredientService { get; set; } = null!;

    [Inject]
    public NavigationManager Navigation { get; set; } = null!;

    private void OnValidSubmitHandler()
    {
        this.IngredientService.Add(new()
        {
            Name = ingredient.Name,
            Kcal = ingredient.KCal,
        });

        this.Navigation.NavigateTo("/ingredients");

    }
}
