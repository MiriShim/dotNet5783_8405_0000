using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO;

public class Order
{
    public int id { get; set; }
    public string CustomerName { get; set; }
    public string CustomerEmail { get; set; }
    public string CastumerAdress { get; set; }
    public DateTime OrderDate { get; set; }
    public OrderStatus Status { get; set; }
    public DateTime PaymentDate { get; set; }
    public DateTime ShipDate  { get; set; }
    public DateTime DeleveryDate { get; set; }
    public List<OrderItem> Items { get; set; } //????
    public double TotalPrice { get; set; }

    public override string ToString() => $@"
id = {id},
castumerName = {CustomerName},
castumerEamil = {CustomerEmail},
castumerAdress = {CastumerAdress},
orderDate = {OrderDate},
status = {Status},
paymentDate = {PaymentDate},
shipDate = {ShipDate},
deleveryDate = {DeleveryDate},
items = {Items.ToString()},
totalPrice = {TotalPrice}";
}
