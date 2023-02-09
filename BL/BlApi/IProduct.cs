﻿using BO;
using DalAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlApi;

public interface IProduct : ICRUD<BO.Product>
{
    Product SelectProductToState();
}
