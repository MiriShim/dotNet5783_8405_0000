using DalAPI;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DAL;

internal class ProductCRUD : IProductCRUD
{
    public Product Add(Product entity)
    {
        //var np = new Product() { Name = "Hamania", Category = Category.Flowers, Price = 4, InStock = 22 };
        entity.ID = DataSource.getUniqueProductId();
        DataSource.Products.Add( entity);
        return entity;
    }

    public bool Remove(int id)
    {
        return false;
    }

    public Product Update(Product entity)
    {
        throw new NotImplementedException();
    }

   public  IEnumerable<Product>  GetAll()
    {
       Product[] list=new Product  [DataSource.Products.Count  ];
       DataSource.Products.CopyTo (list ,0)   ;
       return list;
    }

   public  Product  GetById(int id)
    {
        return DataSource.Products.Single(p => p.ID == id);
    }
}
