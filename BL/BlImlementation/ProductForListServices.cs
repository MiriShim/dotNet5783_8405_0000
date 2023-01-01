using BlApi;
using BO;
using DAL;
using DalAPI;

namespace BlImlementation;

internal class ProductForListServices: IProductForList
{
    private IDal? dal = DalAPI.Factory.GetDal();

    public ProductForList Add(ProductForList entity)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<ProductForList?> GetAll(Func<ProductForList?, bool>? predicate = null)
    {
        throw new NotImplementedException();
    }

    public ProductForList GetById(int id)
    {
        throw new NotImplementedException();
    }

    public bool Remove(int id)
    {
        throw new NotImplementedException();
    }

    public ProductForList Update(ProductForList entity)
    {
        throw new NotImplementedException();
    }
}
