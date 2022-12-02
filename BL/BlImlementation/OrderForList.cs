using BlApi;
using DAL;
using DalAPI;

namespace BlImlementation;

internal class OrderForList: IOrderForList
{
    private IDal Dal = new DalList();
}
