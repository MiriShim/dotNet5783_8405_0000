using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL;

internal class DALProduct : ICRUD<Product>
{
    public Product Add(Product entity)
    {
        //var np = new Product() { Name = "Hamania", Category = Category.Flowers, Price = 4, InStock = 22 };
        entity.ID = DataSource.getUniqueProductId();
        DataSource.products[DataSource.Config.NextProductFreeLocation] = entity;
        return entity;
    }

    public Product[] GetAll()
    {
        Product[] arr= new Product[DataSource.products.Length];
        Array.Copy(DataSource.products, arr,0);
        return arr;
    }
    public Product? GetById(int id)
    {
        return DataSource.products.Single (p => (p.HasValue && p.Value.ID ==id) ) ;
    }

    public bool Remove(int id)
    {
        return false;
    }

    public Product Update(Product entity)
    {
        throw new NotImplementedException();
    }
}

    public Product GetById(int id)
    {
        throw new NotImplementedException();
    }

    public bool Remove(int id)
    {
        throw new NotImplementedException();
    }

    public Product Update(Product entity)
    {
        throw new NotImplementedException();
    }
}
