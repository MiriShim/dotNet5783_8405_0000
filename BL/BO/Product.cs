using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public Category? category { get; set; }
    public int? InStock { get; set; }

    public override string ToString() => $@"
        id = {Id},
        name = {Name},
        price = {Price},
        category = {category},
        in stock = {InStock}";
}
