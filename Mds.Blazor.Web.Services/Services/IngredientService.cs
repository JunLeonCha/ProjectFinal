using Mds.Blazor.Web.Services.Abstractions;
using Mds.Blazor.Web.Services.Models;

namespace Mds.Blazor.Web.Services.Services;

internal sealed class IngredientService : AServiceBase<Ingredient>, IIngredientService
{
    public IngredientService()
    {
        if(elements.Count == 0)
        {
            elements = [
                new() { Id = 1, Name = "Poulet", Kcal = 50 },
                new() { Id = 2, Name = "Merguez", Kcal = 70 },
                new() { Id = 3, Name = "Chorizo", Kcal = 40 },
                new() { Id = 4, Name = "Ananas", Kcal = 20 },
            ];
        }
    }
}
