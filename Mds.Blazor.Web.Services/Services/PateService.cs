using Mds.Blazor.Web.Services.Abstractions;
using Mds.Blazor.Web.Services.Models;

namespace Mds.Blazor.Web.Services.Services;

internal sealed class PateService : AServiceBase<Pate>, IPateService
{
    public PateService()
    {
        if (elements.Count == 0)
        {
            elements = [
                new() { Id = 1, Name = "Base crème" },
                new() { Id = 2, Name = "Base tomate" },
            ];
        }
    }
}
