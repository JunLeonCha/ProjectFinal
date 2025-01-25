using Mds.Blazor.Web.Services.Models;
using Mds.Blazor.Web.ViewModels;

namespace Mds.Blazor.Web.Mappings;

public static class Mapper
{
    public static PateViewModel ToViewModel(this Pate pate)
    => new PateViewModel
    {
        Id = pate.Id,
        Name = pate.Name,
    };
}
