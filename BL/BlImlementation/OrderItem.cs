using System;
using System.Collections.Generic;
using AutoMapper;
using BlApi;
using DAL;
using DalAPI;

namespace BlImlementation;

internal class OrderItem: IOrderItem
{
    private IDal dal = new DalList();
    BLAutoMapper AutoMapper = new BLAutoMapper();

    public int Add(BO.OrderItem IEntity)
    {
        throw new NotImplementedException();
    }

    public void Delete(BO.OrderItem IEntity)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<BO.OrderItem> GetAll()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<BO.OrderItem?> GetAll(Func<BO.OrderItem?, bool>? predicate = null)
    {
        throw new NotImplementedException();
    }

    public BO.OrderItem GetById(int id)
    {
        throw new NotImplementedException();
    }

    public bool Remove(int id)
    {
        throw new NotImplementedException();
    }

    public bool Update(BO.OrderItem IEntity)
    {
        throw new NotImplementedException();
    }

    BO.OrderItem ICRUD<BO.OrderItem>.Add(BO.OrderItem entity)
    {
        throw new NotImplementedException();
    }

    BO.OrderItem ICRUD<BO.OrderItem>.Update(BO.OrderItem entity)
    {
        throw new NotImplementedException();
    }
}
