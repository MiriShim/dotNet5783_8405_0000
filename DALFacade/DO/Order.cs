﻿namespace DO;

public struct Order
{
    public int ID { set; get; }
    public string? CustomerName { set; get; }
    public string? CustomerEmail { set; get; }
    public string? CustomerAddress { set; get; }
    public DateTime? OrderDate { set; get; }
    public DateTime? ShipDate { set; get; } 
}
