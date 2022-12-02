using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BO;

public class OrderForList
{
    public int Id { get; set; }//forgin key from Order
    public string CustomerName { get; set; }
    public OrderStatus Status { get; set; }
    public int NumOfItems { get; set; }
    public double TotalPrice { get; set; }

    public override string ToString() => $@"
id = {Id},
castumerName = {CustomerName},
status = {Status},
amountOfItems = {NumOfItems},
totalPrice = {TotalPrice}";
}
