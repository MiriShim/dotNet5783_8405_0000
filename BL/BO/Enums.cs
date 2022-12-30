using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO;

 
    public enum OrderStatus
    {
        Temp = 1,
        Orderd,
        NotPaid,
        Paid,
        Delivered,
        Recived
    }
    public enum Category
    {
    All=0,
        Flowers = 1,
        Seeds,
        Pkaat,
        Tree,
    Fertilizer

}

