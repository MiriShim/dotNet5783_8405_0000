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
        internal static int NextOrderFreeLocation { get => nextOrderFreeLocation++; }

        private static int nextOrderDeatilFreeLocation = 0;
        internal static int NextOrderDeatilFreeLocation { get => nextOrderDeatilFreeLocation++; }

        static int nextOrderItemId = 1000;
        public static int NextOrderItemId { get => ++nextOrderItemId; }


        private static int nextProductFreeLocation = 0;
        internal static int NextProductFreeLocation { get => nextProductFreeLocation++; }
        //todo::
        //בכל גישה הערך יגדל ויגרמו רווחים
        internal static int AutoNextProductFreeLocation { get => Array.IndexOf(products, products.FirstOrDefault(a => a == null)); }
    }


    internal static Product?[] products = new Product?[50];
    internal static Order?[] orders = new Order?[100];
    internal static OrderItem?[] OItems = new OrderItem?[200];
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
            products[i] = new Product()
            {
                ID = getUniqueProductId(),
                Name = productsNames[0, i],
                Price = rand.Next(200),
                Category = Category.Seeds,
                InStock = rand.Next(50),
            };
        }


        //Category.Flowers
        for (int i = 0; i < productsNames.GetLength(1); i++)
        {
            products[i] = new Product()
            {
                ID = getUniqueProductId(),
                Name = productsNames[1, i],
                Price = rand.Next(200),
                Category = Category.Flowers,
                InStock = rand.Next(50),
            };
        }
    }

    static void generateOrders()
    {
        string[] customerNames = new[] { "Sara", "Rivka", "Rachel", "Lea", "Dvora", "Bruria", "Shivra", "Tamar", "Yehudit", "Yocheved" };
        string[] customerAddresses = new[] { "Chazon ish", "Rabi Akiva", "Rachel", "Lea", "Dvora", "Bruria", "Shivra", "Tamar", "Yehudit", "Yocheved" };

        for (int i = 0; i < orders.Length; i++)
        {
            DateTime orderDate = DateTime.Now.AddDays(-rand.Next(50, 100));//לפני 50-100 ימים
            orders[i] = new Order()
            {
                ID = Config.NextOrderId,
                OrderDate = orderDate,
                ShipDate = orderDate.AddDays(rand.Next(20, 45)),// אחרי ההזמנה 20-45 ימים
                CustomerName = customerNames[i - i * 10] + " " + i,
                CustomerAddress = customerAddresses[i - i * 10] + " " + i,
                CustomerEmail = $"{customerNames[i - i * 10]}.{customerNames[i - i * 10]}@gmail.com",
            };
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
    internal static int getUniqueProductId()
    {
        int rnd = rand.Next(100000, 999999);
        while (products.Any(p => p.HasValue && p.Value.ID == rnd))
            rnd = rand.Next(100000, 999999);
        return rnd;
    }

}
