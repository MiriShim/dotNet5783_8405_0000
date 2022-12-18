using DAL;
using DalAPI;

namespace BlImlementation;

internal class ProductItem : BlApi.IProduct
{
    private IDal Dal = new DalList();

    public BO.Product Add(BO.Product entity)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<BO.Product> GetAll()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<BO.Product?> GetAll(Func<BO.Product?, bool>? predicate = null)
    {
        throw new NotImplementedException();
    }

    public BO.Product GetById(int id)
    {
        throw new NotImplementedException();
    }

    public bool Remove(int id)
    {
        throw new NotImplementedException();
    }

    public BO.Product Update(BO.Product entity)
    {
        throw new NotImplementedException();
    }
}
