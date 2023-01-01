using BlApi;

namespace BlImlementation;

internal  class BL : BlApi.IBL
{
    public ICart Cart => new Cart();

    public IOrder Order => new OrderServices();

    public IOrderForList OrderForList => throw new NotImplementedException();

    public IOrderItem OrderItem => throw new NotImplementedException();

    public IOrderTracking OrderTracking => throw new NotImplementedException();

    public IProduct Product => new ProductServices();
    public IProductForList ProductForList => throw new NotImplementedException();

    public IProductItem ProductItem => throw new NotImplementedException();
}
