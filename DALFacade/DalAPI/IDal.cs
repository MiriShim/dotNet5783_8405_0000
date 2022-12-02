using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalAPI
{
    public  interface IDal
    {
        IProductCRUD Product { get; }
        IOrderCRUD Order { get; }
        IOrderItemCRUD OrderItem { get; }

    }
}
