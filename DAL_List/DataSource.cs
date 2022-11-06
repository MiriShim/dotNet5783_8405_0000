using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class DataSource
    {
        private readonly static Random s_rand = new();

        internal static class Config
        {
            internal const int s_startOrderNumber = 1000;
            private static int s_nextOrderNumber = s_startOrderNumber;
            internal static int NextOrderNumber { get => ++s_nextOrderNumber; }
        }


        Product[] products = new Product[50];
        Order [] orders = new Order[100];
        OrderItem[] OItems = new OrderItem[200];
        static  DataSource()
        {
            s_Initialize();
        }
       static  void s_Initialize()
        {
            generateProducts ();
        }
       static  void generateProducts()
        {
            for (int i = 0; i < 100; i++)
            {

            }
        }
    }
}
