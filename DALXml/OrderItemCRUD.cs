using DalAPI;
using DO;

namespace DAL
{
    internal class OrderItemCRUD : IOrderItemCRUD
    {
        public OrderItem Add(OrderItem entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderItem> GetAll(Func<OrderItem, bool>? predicate = null)
        {
            throw new NotImplementedException();
        }

        public OrderItem GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }

        public OrderItem Update(OrderItem entity)
        {
            throw new NotImplementedException();
        }
    }
}