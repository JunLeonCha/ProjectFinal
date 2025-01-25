using System.ComponentModel.DataAnnotations;

namespace Mds.Blazor.Web.ViewModels;

public sealed class PateViewModel
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;
}
