using DalAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public  class DalList : IDal
    {
        public IProductCRUD  Product => new ProductCRUD();


        public IOrderItemCRUD OrderItem => throw new NotImplementedException();

 

       public  IOrderCRUD Order => throw new NotImplementedException();

        DalAPI.IOrderCRUD IDal.Order => throw new NotImplementedException();
    }
}
