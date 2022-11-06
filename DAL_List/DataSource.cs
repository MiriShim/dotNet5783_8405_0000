using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal static  class DataSource
    {
        private readonly static Random rand = new();

        internal static class Config
        {
            internal static  int NextOrderId = 1000;
            private static int nextOrderFreeLocation = 0;
            internal static int NextOrderFreeLocation { get => nextOrderFreeLocation++; }

            internal static int NextOrderDeatilId = 1000;
            private static int nextOrderDeatilFreeLocation = 0;
            internal static int NextOrderDeatilFreeLocation { get => nextOrderDeatilFreeLocation++; }


            private static int nextProductFreeLocation = 0;
            internal static int NextProductFreeLocation { get => nextProductFreeLocation++; }
            internal static int AutoNextProductFreeLocation { get =>Array.IndexOf(products, products.FirstOrDefault (a=>a==null)); }


        }


        internal static Product?[] products = new Product?[50];
        internal static Order? [] orders = new Order?[100];
        internal static OrderItem?[] OItems = new OrderItem?[200];
        static  DataSource()
        {
            s_Initialize();
        }
        static  void s_Initialize()
        {
            generateProducts ();
        }
        static void generateProducts()
        {
            string[,] productsNames = new[,] { { "Grass seeds", "Portulaka seeds", "Wheet seeds", "onion seeds" }, { "Roze", "Mini rose", "Vinka", "Sitvanit" } };
            for (int i = 0; i < 10; i++)
            {
                products[i] =
                    new Product()
                    {
                        ID = getUniqueProductId(),
                        Name = productsNames[rand.Next(0, 4), 0],
                        Price = rand.Next(200),
                        Category = Category.Seeds,
                        InStock = rand.Next(50),
                    };
            }
        }
    
        static void generateOrders()
        {
        
        }

        static void generateOrderItems()
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    Product? product = products[rand.Next(Config.NextOrderId)];
            //    orderItems.Add(
            //        new OrderItem
            //        {
            //            OrderID = s_rand.Next(Config.NextOrderId, Config.NextOrderId + _orders.Count),
            //            ProductID = product?.ID ?? 0,
            //            Price = product?.Price ?? 0,
            //            Amount = s_rand.Next(5),
            //        });
            //}
        }
        internal  static int getUniqueProductId()
        {
            int rnd = rand.Next(100000, 999999);
            while (products.Any(p => p.num == rnd))
                rnd = rand.Next(100000, 999999);
            return rnd;
        }


    }
}}
