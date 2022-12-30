using AutoMapper;
using BlApi;
using DAL;
using DalAPI;

namespace BlImlementation;

internal class OrderServices : IOrder
{
    private   IDal dalRep = new DalList();

 
    
    public void Delete(BO.Order IEntity)
    {
        throw new NotImplementedException();
    }
    public BO.Order Get(int id)
    {
        IMapper mapper = BLAutoMapper.OredrMappingConfiguration.CreateMapper();

        //מקבל מספר מזהה ומחזיר את ההזנה המתאימה מתוך רשימת ההזמנות
        //אם הקלט הוא -1 הוא יחזיר את כל הרשימה של ההזמנות 
        var doOrder = dalRep.Order.GetById(id);


        return mapper.Map<BO.Order>(doOrder); ;
    }

    public IEnumerable<BO.Order?> GetAll(Func<BO.Order?, bool>? predicate = null)
    {
        IMapper mapper = BLAutoMapper.OredrMappingConfiguration.CreateMapper();

        return dalRep.Order.GetAll().ToList().ConvertAll<BO.Order>(c => mapper.Map<BO.Order>(c))
            .Where(predicate ?? ((item) => true));


        //var orders = dalRep.Product.GetAll();


        //List<BO.Order> list = new List<BO.Order>();

        //orders .ToList().ForEach(p => list.Add(mapper.Map<BO.Product>(p)));

        //return list.Where(predicate ?? ((item) => true));
    }

    public BO.Order GetById(int id)
    {
        throw new NotImplementedException();
    }

    public bool Remove(int id)
    {
        throw new NotImplementedException();
    }

  public   BO.Order Add(BO.Order entity)
    {
        IMapper map = BLAutoMapper.OredrItemMappingConfiguration.CreateMapper();
        var r = dalRep.Order.Add(map.Map<DO.Order>(entity));

        return map.Map<BO.Order>(r);
    }

   

  public   BO.Order Update(BO.Order entity)
    {
        throw new NotImplementedException();
    }

 
}
