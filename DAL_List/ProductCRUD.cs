using DalAPI;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DAL;

internal class ProductCRUD : IProductCRUD
{
    public bool Remove(int id)
    {
        return false;
    }

    public Product Update(Product? entity)
    {
        if (entity is null) 
            throw new EntityException();
//        Product? p = DataSource.Products.FirstOrDefault  (a => a.HasValue && a.Value.ID == entity.Value.ID);
        int ix = DataSource.Products.IndexOf(entity);
        DataSource.Products[ix] = entity;

        return entity.Value ;
    }      

    public IEnumerable<Product?> GetAll(Func<Product?, bool>? predicate = null)
    {
        Product?[] list = new Product?[DataSource.Products.Count];
        if (predicate == null)
            DataSource.Products.CopyTo(list, 0);
        else
            DataSource.Products.Where(a => a != null).Where(predicate).ToList().CopyTo(list, 0);

        return list.ToList().AsEnumerable();
    }

    public Product? Add(Product? entity)
    {
        if (entity == null)
            throw new EntityException();
        Product pr = entity.Value;;

        pr.ID = DataSource.GetUniqueProductId();
        DataSource.Products.Add(pr);
        return pr;
    }

   public Product? GetById(int id)
    {
        return DataSource.Products.Single(p => (p.HasValue && p.Value.ID == id)) ?? throw new EntityNotFoundException();
    }

    Product? ICRUD<Product?>.Update(Product? entity)
    {
        throw new NotImplementedException();
    }
}
