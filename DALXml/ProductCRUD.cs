using DalAPI;
using DO;
using System.Xml.Linq;

namespace DAL
{
    internal class ProductCRUD : IProductCRUD, IInit
    {
        static string filePath = $@"..\xml\{typeof(Product).Name }";
         public Product? Add(Product? entity)
        {
            var allElements = XDocument.Load(filePath);

            Product p = entity ?? throw new Exception() ;
            
            XElement OrderElement = p.CreateElement();
 
            allElements?.Root?.Add(OrderElement);

            allElements?.Save(filePath);

            return entity;
        }

        public IEnumerable<Product?> GetAll(Func<Product?, bool>? predicate = null)
        {
            return XMLTools.LoadListFromXMLElement(filePath).Elements()
                .Select(s => getStudent(s)).Where( predicate ?? (p=>true ) );
        }

        private Product? getStudent(XElement s)
        {
            throw new NotImplementedException();
        }

        public Product? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Init()
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Product? Update(Product? entity)
        {
            throw new NotImplementedException();
        }

        static DO.Product? getProductFromXElement(XElement s) => 
       s.ToIntNullable("ID") is null ? null : new DO.Product()
       {
           Id = (int)s.Element("Id")!,
           Name = (string?)s.Element("Name")??"",
           Category = Enum.Parse<Category> (s.Element("Category")?.Value??"0" )       
       };

    }
}