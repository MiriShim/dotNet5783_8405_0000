﻿using AutoMapper;
using BlApi;
using DAL;
using DalAPI;

namespace BlImlementation;

internal class Order : BlApi.IOrder
{
    private IDal Dal = new DalList();

   // BLAutoMapper autMapper = new BLAutoMapper();

    public int Add(BO.Order IEntity)
    {
        throw new NotImplementedException();
    }

    public void Delete(BO.Order IEntity)
    {
        throw new NotImplementedException();
    }

    public BO.Order Get(int id)
    {
        //מקבל מספר מזהה ומחזיר את ההזנה המתאימה מתוך רשימת ההזמנות
        //אם הקלט הוא -1 הוא יחזיר את כל הרשימה של ההזמנות 
        var doOrder = Dal.Order.GetById(id);

        IMapper  mapper = autMapper.OredrMappingConfiguration.CreateMapper();
        var boOrder=mapper.Map<BO.Order>(doOrder);
        
        return boOrder;
    }

    public IEnumerable<BO.Order> GetAll()
    {
        throw new NotImplementedException();
    }

    public BO.Order GetById(int id)
    {
        throw new NotImplementedException();
    }

    public bool Remove(int id)
    {
        throw new NotImplementedException();
    }

    public bool Update(BO.Order IEntity)
    {
        throw new NotImplementedException();
    }

    BO.Order ICRUD<BO.Order>.Add(BO.Order entity)
    {
        throw new NotImplementedException();
    }

    BO.Order ICRUD<BO.Order>.Update(BO.Order entity)
    {
        throw new NotImplementedException();
    }
}