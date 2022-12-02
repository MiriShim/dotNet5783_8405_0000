using AutoMapper;
using DAL;
using DalAPI;

namespace BlImlementation;

internal class Product : BlApi.IProduct
{
    private IDal Dal = new DalList();
    BLAutoMapper AutoMapper = new BLAutoMapper();

    public int Add(BO.Product IEntity)
    {
        throw new NotImplementedException();
    }

    public void Delete(BO.Product IEntity)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<BO.Product> GetAll()
    {
        throw new NotImplementedException();
    }

    public  BO.Product  GetById(int id)
    {
        var doProduct = Dal.Product.GetById (id);


        IMapper mapper = AutoMapper.ProductMappingConfiguration.CreateMapper();
         
       return  mapper.Map<BO.Product>(doProduct);
        
         
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
        throw new NotImplementedException();
    }

    BO.Product ICRUD<BO.Product>.Update(BO.Product entity)
    {
        throw new NotImplementedException();
    }
}
