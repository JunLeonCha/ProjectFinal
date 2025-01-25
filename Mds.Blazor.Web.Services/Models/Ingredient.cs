namespace Mds.Blazor.Web.Services.Models;
public sealed class Ingredient : AObjectBase
{
    public string Name { get; set; } = string.Empty;

    public int Kcal { get; set; }
}
