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

    public List<Product> GetAll()
    {
        Product?[] arr=new Product?[DataSource.Config.NextProductFreeLocation];
        Array.Copy(DataSource.products,arr,DataSource.Config.NextProductFreeLocation)
        return DataSource.products.CopyTo 

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
