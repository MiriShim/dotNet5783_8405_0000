using DalAPI;

namespace DAL
{
    public class DalList : IDal
    {
        public static DalList Instance {get;} = new DalList();
          DalList()
        {

        }
        public IProductCRUD Product => new ProductCRUD();

        public IOrderItemCRUD OrderItem => throw new NotImplementedException();

        public IOrderCRUD Order => new OrderCRUD();

    }
}
