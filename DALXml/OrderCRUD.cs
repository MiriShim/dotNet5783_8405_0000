using DalAPI;
using DO;
using System.Xml.Linq;
 
namespace DAL
{
    internal class OrderCRUD : IOrderCRUD
    {
        static string filePath = $@"..\xml\{typeof(Order).Name }";


        public Order Add(Order entity)
        {
           ccc
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


        static IEnumerable<XElement> createOrderElement(DO.Order order)
        {
            return order.

            yield return new XElement("ID", order.ID);

            if (order.OrderDate is not null)
                yield return new XElement(nameof(order.OrderDate), order.OrderDate);
            if (order.ShipDate is not null)
                yield return new XElement("ShipDate", order.ShipDate);
            if (order.CustomerName is not null)
                yield return new XElement("CustomerName", order.CustomerName);
            if (order.CustomerEmail is not null)
                yield return new XElement("CustomerEmail", order.CustomerEmail);
            if (order.CustomerAddress is not null)
                yield return new XElement("CustomerAddress", order.CustomerAddress);
        }

    }
}