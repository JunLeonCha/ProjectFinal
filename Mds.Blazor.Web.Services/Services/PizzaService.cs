using Mds.Blazor.Web.Services.Abstractions;
using Mds.Blazor.Web.Services.Models;

namespace Mds.Blazor.Web.Services.Services;
internal sealed class PizzaService : AServiceBase<Pizza>, IPizzaService
{
    public PizzaService()
    {
        if (elements.Count == 0)
        {
            elements = [
                new() { Id = 1, Name = "H", PateId = 2, Ingredients = [1, 4] },
            ];
        }
    }
}
