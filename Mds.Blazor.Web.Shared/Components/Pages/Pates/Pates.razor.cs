using Mds.Blazor.Web.Services.Abstractions;
using Mds.Blazor.Web.ViewModels;
using Microsoft.AspNetCore.Components;

namespace Mds.Blazor.Web.Shared.Components.Pages.Pates;

public sealed partial class Pates
{
    private List<PateViewModel> pateCollection = [];

    [Inject]
    public IPateService PateService { get; set; } = null!;

    protected override void OnInitialized()
    {
        this.pateCollection = this.PateService.GetAll()
            .Select(x => new PateViewModel
        {
            Id = x.Id,
            Name = x.Name,
        }).ToList();

        base.OnInitialized();
    }

}
