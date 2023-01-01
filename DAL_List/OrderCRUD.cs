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
            if (DataSource.Orders.Any(a => a.HasValue && a.Value.ID == entity.ID)) 
                throw new DuplicateIdException("ערך כפול לא ניתן להכניס.") {Entity=entity ,EntityId=entity.ID  };

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
