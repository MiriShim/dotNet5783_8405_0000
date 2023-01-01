using DalAPI;

namespace DAL
{
    //internal class DalList : IDal
    internal class XmlDataWorker : IDal
    {
        public static XmlDataWorker Instabce { get; } = new XmlDataWorker();
        XmlDataWorker()
        {

        }

        public IProductCRUD Product => new ProductCRUD();

        public IOrderItemCRUD OrderItem => new OrderItemCRUD();

        public IOrderCRUD Order => new OrderCRUD();

    }
}