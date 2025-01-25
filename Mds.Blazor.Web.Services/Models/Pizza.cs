namespace Mds.Blazor.Web.Services.Models;
public sealed class Pizza : AObjectBase
{
    public string Name { get; set; } = string.Empty;

    public int PateId { get; set; }

    public List<int> Ingredients { get; set; } = [];

    public PizzaSize Size { get; set; }
}
