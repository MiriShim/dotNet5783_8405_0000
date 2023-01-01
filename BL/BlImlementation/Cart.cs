 
using BlApi;
using DAL;
using DalAPI;

namespace BlImlementation;

internal class Cart: ICart
{
    private IDal? dal = DalAPI.Factory.GetDal();
}
