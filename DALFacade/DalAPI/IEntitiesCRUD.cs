using DO;

namespace DalAPI;

public  interface  IProductCRUD : ICRUD<Product?>
{
   

}
public interface IOrderCRUD : ICRUD<Order >
{

}
public interface IOrderItemCRUD : ICRUD<OrderItem >
{

}
