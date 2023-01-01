using AutoMapper;
using DAL;
using DalAPI;

namespace BlImlementation;

internal class ProductServices : BlApi.IProduct
{
    private IDal? dal = DalAPI.Factory.GetDal();

    public void Delete(BO.Product IEntity)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<BO.Product?> GetAll(Func<BO.Product?, bool>? predicate = null)
    {
        var products = dal?.Product.GetAll() ?? throw new DO.DalNotFoundException() ;

        IMapper mapper = BLAutoMapper.ProductMappingConfiguration.CreateMapper();

        List<BO.Product> list = new List<BO.Product>();
 
        products.ToList().ForEach(p=>list.Add(mapper.Map<BO.Product >(p)));
         
        return list.Where(predicate??((item)=>true));
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

    public BO.Product Update(BO.Product IEntity)
    {
        throw new NotImplementedException();
    }

    BO.Product ICRUD<BO.Product>.Add(BO.Product entity)
    {
        IMapper map = BLAutoMapper.ProductMappingConfiguration.CreateMapper();
        var r = dal?.Product.Add(map.Map<DO.Product>(entity));

        return map.Map<BO.Product>(r);
    }
 
}
