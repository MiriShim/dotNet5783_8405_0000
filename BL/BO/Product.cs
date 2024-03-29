﻿using DO;
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
    public Category? Category { get; set; }
    public int? InStock { get; set; }

    public ProductStatus ProductStatus { get; set; } = BO.ProductStatus.State1;
    public DateTime LastUpdateAt { get; set; }

    public override string ToString() => $@"
        id = {Id},
        {nameof (ProductStatus)} = {ProductStatus },
        name = {Name},
        price = {Price},
        category = {Category},
        in stock = {InStock}";
}
