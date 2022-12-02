using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BO;

public class OrderItem
{
    public int id { get; set; }
    public int productId { get; set; }//forgin key from Product
    public double price { get; set; }
    public int amount { get; set; }

    public override string ToString() => $@"
id = {id},
product id = {productId},
price = {price},
amount = {amount}";
}
