namespace Mds.Blazor.Web.Services.Abstractions;
public interface IServiceBase<TModel>
{
    List<TModel> GetAll();
    TModel? GetById(int id);
    void Add(TModel model);
    void Update(int id, TModel model);
    void Delete(int id);
}
