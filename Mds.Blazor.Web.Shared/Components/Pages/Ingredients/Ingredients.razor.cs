using Mds.Blazor.Web.Services.Abstractions;
using Mds.Blazor.Web.ViewModels;
using Microsoft.AspNetCore.Components;

namespace Mds.Blazor.Web.Shared.Components.Pages.Ingredients;

public sealed partial class Ingredients
{
    private List<IngredientViewModel> ingredientCollection = [];

    [Inject]
    public IIngredientService IngredientService { get; set; } = null!;

    protected override void OnInitialized()
    {
        this.ingredientCollection = this.IngredientService.GetAll()
            .Select(x => new IngredientViewModel
            {
                Id = x.Id,
                Name = x.Name,
                KCal = x.Kcal,
            }).ToList();

        base.OnInitialized();
    }
}
