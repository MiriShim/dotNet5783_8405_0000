using BlApi;
using DAL;
using DalAPI;

namespace BlImlementation;

internal class ProductForList: IProductForList
{
    private IDal Dal = new DalList();
}
