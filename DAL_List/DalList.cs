using DalAPI;

namespace DAL
{
    internal class DalList : IDal
    {
        public static DalList Instabce {get;} = new DalList();
          DalList()
        {

        }
        public IProductCRUD Product => new ProductCRUD();

        public IOrderItemCRUD OrderItem => throw new NotImplementedException();

        public IOrderCRUD Order => new OrderCRUD();

    }
}
