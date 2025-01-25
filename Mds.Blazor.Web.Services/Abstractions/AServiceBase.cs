
using Mds.Blazor.Web.Services.Models;

namespace Mds.Blazor.Web.Services.Abstractions;
internal abstract class AServiceBase<TModel> : IServiceBase<TModel>
    where TModel : AObjectBase
{
    protected static List<TModel> elements = [];

    public void Add(TModel model)
    {
        model.Id = this.GetNextId();
        elements.Add(model);
    }

    public void Delete(int id)
    {
        elements.FirstOrDefault(x => x.Id == id);
    }

    public List<TModel> GetAll()
        => elements;

    public TModel? GetById(int id)
        => elements.FirstOrDefault(x => x.Id == id);

    public void Update(int id, TModel model)
    {
        throw new NotImplementedException();
    }

    private int GetNextId()
    {
        if (elements.Count == 0)
            return 1;

        var max = elements.Max(e => e.Id);

        return max + 1;
    }
}
