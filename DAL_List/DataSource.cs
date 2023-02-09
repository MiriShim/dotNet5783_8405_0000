using DO;


namespace DAL;

internal static class DataSource
{
    private readonly static Random rand = new();

    internal static class Config
    {
        static int nextOrderId = 1000;
        public static  int NextOrderId { get => ++nextOrderId; }

        private static int nextOrderFreeLocation = 0;


        static int nextOrderItemId = 1000;
        public static int NextOrderItemId { get => ++nextOrderItemId; }
    }

     internal static List<Product?> Products = new();
    internal static List<Order?> Orders = new();
    internal static List<OrderItem?> OrderItems=new();

    static DataSource()
    {
        s_Initialize();
    }
    static void s_Initialize()
    {
        generateProducts();
    }
    static void generateProducts()
    {
        string[,] productsNames = new[,] { { "Grass seeds", "Portulaka seeds", "Wheet seeds", "onion seeds" },
            { "Roze", "Mini rose", "Vinka", "Sitvanit" } };

        //Category.Seeds
        for (int i = 0; i < productsNames.GetLength(1); i++)
        {
            Products.Add(new Product()
            {
                Id = GetUniqueProductId(),
                Name = productsNames[0, i],
                Price = rand.Next(200),
                Category = Category.Seeds,
                InStock = rand.Next(50),
            });
        }


        //Category.Flowers
        for (int i = 0; i < productsNames.GetLength(1); i++)
        {
            Products.Add(new Product()
            {
                Id = GetUniqueProductId(),
                Name = productsNames[1, i],
                Price = rand.Next(200),
                Category = Category.Flowers,
                InStock = rand.Next(50),
                ProductStatus = (ProductStatus)rand.Next(1, 5)
            }) ;
        }
    }

    static void generateOrders()
    {
        string[] customerNames = new[] { "Sara", "Rivka", "Rachel", "Lea", "Dvora", "Bruria", "Shivra", "Tamar", "Yehudit", "Yocheved" };
        string[] customerAddresses = new[] { "Chazon ish", "Rabi Akiva", "Rachel", "Lea", "Dvora", "Bruria", "Shivra", "Tamar", "Yehudit", "Yocheved" };

        for (int i = 0; i < Orders.Count ; i++)
        {
            DateTime orderDate = DateTime.Now.AddDays(-rand.Next(50, 100));//לפני 50-100 ימים
            Orders.Add( new Order()
            {
                ID = Config.NextOrderId,
                OrderDate = orderDate,
                ShipDate = orderDate.AddDays(rand.Next(20, 45)),// אחרי ההזמנה 20-45 ימים
                CustomerName = customerNames[i - i * 10] + " " + i,
                CustomerAddress = customerAddresses[i - i * 10] + " " + i,
                CustomerEmail = $"{customerNames[i - i * 10]}.{customerNames[i - i * 10]}@gmail.com",
            });
        }
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
    internal static int GetUniqueProductId()
    {
        int rnd = rand.Next(100000, 999999);
        Product? hh=null;
        if (hh?.Id == 0)
            while (Products.Any(p=>p.HasValue && p.Value.Id==rnd ))
                rnd = rand.Next(100000, 999999);
        return rnd;
    }

}
