using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO;

public class ProductIem
{
    public int id { get; set; }//forgin key from product
    public string name { get; set; }
    public double price { get; set; }
    public Category category { get; set; }
    public int amount { get; set; }
    public bool inStock { get; set; }

    public override string ToString() => $@"
id = {id},
name = {name},
price = {price},
category = {category},
amount = {amount},
in stock = {inStock}";
}
