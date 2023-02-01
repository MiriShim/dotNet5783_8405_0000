using AutoMapper;
using BO;
using DAL;
using DalAPI;

namespace BlImlementation;

internal class ProductServices : BlApi.IProduct
{
    IMapper mapper = BLAutoMapper.ProductMappingConfiguration.CreateMapper();

    private IDal? dal = DalAPI.Factory.GetDal();

    public void Delete(BO.Product IEntity)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<BO.Product?> GetAll(Func<BO.Product?, bool>? predicate = null)
    {
        var products = dal?.Product.GetAll() ?? throw new DO.DalNotFoundException();

        IMapper mapper = BLAutoMapper.ProductMappingConfiguration.CreateMapper();

        List<BO.Product> list = new List<BO.Product>();

        products.ToList().ForEach(p => list.Add(mapper.Map<BO.Product>(p)));

        return list.Where(predicate ?? ((item) => true));
    }

    public BO.Product GetById(int id)
    {
        var doProduct = dal?.Product.GetById(id);


        IMapper mapper = BLAutoMapper.ProductMappingConfiguration.CreateMapper();

        return mapper.Map<BO.Product>(doProduct);


    }

    public bool Remove(int id)
    {
        throw new NotImplementedException();
    }

    public Product SelectProductToState()
    {
        var x = GetAll();
        var x1 = x.Where(p => (int?)p?.ProductStatus < 6);
        var x2 = x1.OrderBy(p => p?.UpdateAt);
        var x3 = x2.FirstOrDefault();
        return x3;
    }

    public BO.Product Update(BO.Product IEntity)
    {
        var p = mapper.Map<DO.Product>(IEntity);
        var updatedProduct = dal?.Product.Update(p);
        return mapper.Map<BO.Product>(updatedProduct);
    }

    BO.Product ICRUD<BO.Product>.Add(BO.Product entity)
    {

        var r = dal?.Product.Add(mapper.Map<DO.Product>(entity));

        return mapper.Map<BO.Product>(r);
    }

}
