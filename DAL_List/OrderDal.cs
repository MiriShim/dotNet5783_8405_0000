using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class OrderDal : IOrderDal
    {
         public Order Add(Order entity)
        {
            entity.ID = DataSource.Config.NextOrderId;
            DataSource.orders [DataSource.Config.NextOrderFreeLocation] = entity;
 
            return entity;
        }

        public List<Order> GetAll()
        {
            throw new NotImplementedException();
        }

        public Order GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Order Update(Order entity)
        {
            throw new NotImplementedException();
        }
    }
}
