using DalAPI;
using DO;
using System.Runtime.CompilerServices;

namespace DAL;

internal class ProductCRUD : IProductCRUD
{
    public bool Remove(int id)
    {
        return false;
    }
    [MethodImpl(MethodImplOptions.Synchronized)]
    public Product? Update(DO.Product? entity)
    {
        Product sureProduct=entity?? throw new EntityException();
        //        Product? p = DataSource.Products.FirstOrDefault  (a => a.HasValue && a.Value.ID == entity.Value.ID);
        int ix = DataSource.Products.IndexOf(sureProduct);
        
        sureProduct.LastUpdateAt = DateTime.Now;
         DataSource.Products[ix] = sureProduct ;

        return sureProduct ;
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
        Product pr = entity.Value; ;

        pr.Id = DataSource.GetUniqueProductId();
        DataSource.Products.Add(pr);
        return pr;
    }

    public Product? GetById(int id)
    {
        return DataSource.Products.Single(p => (p.HasValue && p.Value.Id == id)) ?? throw new EntityNotFoundException();
    }
}

     
