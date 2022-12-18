using AutoMapper;
using DAL;
using DalAPI;

namespace BlImlementation;

internal class Product : BlApi.IProduct
{
    private IDal Dal = new DalList();
    BLAutoMapper myMapper = new BLAutoMapper();


    public int Add(BO.Product IEntity)
    {
        throw new NotImplementedException();
    }

    public void Delete(BO.Product IEntity)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<BO.Product?> GetAll(Func<BO.Product?, bool>? predicate = null)
    {
        MapperConfiguration ProductMappingConfiguration = new(cnf =>
            cnf.CreateMap<BO.Product, DO.Product>().ReverseMap()) ;

        IMapper mapper = ProductMappingConfiguration.CreateMapper();

        List<BO.Product> list = new List<BO.Product>();

        Dal.Product.GetAll().ToList().ForEach(p=>list.Add(mapper.Map<BO.Product >(p)));
        return list;
     }

    

    public BO.Product GetById(int id)
    {
        var doProduct = Dal.Product.GetById(id);


        IMapper mapper = myMapper.ProductMappingConfiguration.CreateMapper();

        return mapper.Map<BO.Product>(doProduct);


    }

    public bool Remove(int id)
    {
        throw new NotImplementedException();
    }

    public bool Update(BO.Product IEntity)
    {
        throw new NotImplementedException();
    }

    BO.Product ICRUD<BO.Product>.Add(BO.Product entity)
    {
        IMapper map = myMapper.ProductMappingConfiguration.CreateMapper();
        var r = Dal.Product.Add(map.Map<DO.Product>(entity));

        return map.Map<BO.Product>(r);
    }

    BO.Product ICRUD<BO.Product>.Update(BO.Product entity)
    {
        throw new NotImplementedException();
    }
}
