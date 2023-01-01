namespace DalAPI;

public interface IDal
{
    IProductCRUD Product { get; }
    IOrderCRUD Order { get; }
    IOrderItemCRUD OrderItem { get; }

}
