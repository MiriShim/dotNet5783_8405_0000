using BlApi;
using DAL;
using DalAPI;

namespace BlImlementation;

internal class OrderTracking : IOrderTracking
{
    private IDal? dal = DalAPI.Factory.GetDal();
}
