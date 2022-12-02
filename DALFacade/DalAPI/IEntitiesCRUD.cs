
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalAPI
{
    public  interface  IProductCRUD : ICRUD<Product>
    {
       

    }
    public interface IOrderCRUD : ICRUD<Order >
    {

    }
    public interface IOrderItemCRUD : ICRUD<OrderItem >
    {

    }
}
