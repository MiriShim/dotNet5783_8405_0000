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
    Flowers,
    Seeds,
    Trees,
    /// <summary>
    /// עציצים
    /// </summary>
    Pots,
    /// <summary>
    /// כלי גינון
    /// </summary>
    GardeningTools,
    /// <summary>
    /// פקעות
    /// </summary>
    Tubers,
    /// <summary>
    /// תערובת שתילה
    /// </summary>
    plantingMixture,
    /// <summary>
    /// דשן
    /// </summary>
    Fertilizer

}

