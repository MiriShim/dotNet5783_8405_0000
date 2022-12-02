using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO;

public class Cart
{
    public int id { get; set; }
    public string castumerName { get; set; }
    public string castumerEamil { get; set; }
    public string castumerAdress { get; set; }
    public List<OrderItem> items { get; set; } //?????
    public double totalPrice { get; set; }

    public override string ToString() => $@"
    id: {id},
    castumer name:{castumerName}
    castumer Email: {castumerEamil}
    castumer Adress: {castumerAdress}
    item: {items}
    totalPrice: {totalPrice}";
}
