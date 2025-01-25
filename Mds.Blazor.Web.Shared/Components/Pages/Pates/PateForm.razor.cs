using Mds.Blazor.Web.Services.Abstractions;
using Mds.Blazor.Web.ViewModels;
using Microsoft.AspNetCore.Components;

namespace Mds.Blazor.Web.Shared.Components.Pages.Pates;

public sealed partial class PateForm
{
    private PateViewModel pate = new();

    [Parameter]
    public int PateId { get; set; }

    [Inject]
    public IPateService PateService { get; set; } = null!;

    [Inject]
    public NavigationManager Navigation { get; set; } = null!;

    private void OnValidSubmitHandler()
    {
        this.PateService.Add(new()
        {
            Name = pate.Name,
        });

        this.Navigation.NavigateTo("/pates");

    }
}
