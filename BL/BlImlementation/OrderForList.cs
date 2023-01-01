using BlApi;
using DAL;
using DalAPI;

namespace BlImlementation;

internal class OrderForList: IOrderForList
{
    private IDal? dal = DalAPI.Factory.GetDal();
}
