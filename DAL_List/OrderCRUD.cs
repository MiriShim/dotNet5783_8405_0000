using DalAPI;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class OrderCRUD : IOrderCRUD
    {
         public Order Add(Order entity)
        {
            entity.ID = DataSource.Config.NextOrderId;
            DataSource.Orders.Add(  entity);
 
            return entity;
        }

        public IEnumerable <Order> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetAll(Func<Order, bool>? predicate = null)
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
