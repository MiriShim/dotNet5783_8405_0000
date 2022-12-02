using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO;

public class Product
{
    public int id { get; set; }
    public string name { get; set; }
    public double price { get; set; }
    public Category category { get; set; }
    public int inStock { get; set; }

    public override string ToString() => $@"
id = {id},
name = {name},
price = {price},
category = {category},
in stock = {inStock}";
}
