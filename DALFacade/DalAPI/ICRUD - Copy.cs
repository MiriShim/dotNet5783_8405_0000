using DO;

namespace DalAPI
{
   public  interface ICRUD_Samples<T>
    {
        
        IEnumerable <T> GetAll(Func<T?,bool> predicate=null);   
           
        T Add(T entity);
        T GetById(int id);
        T Update(T entity);
        bool Remove(int id);

        //IEnumerable<T> GetAll()
       
    }

    public class productCrud : ICRUD_Samples<Product>
    {
        List<Product> Products;
        

        public Product Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll(Func <Product,bool>? pred =null )
        {
            if (pred == null)
                return Products;
           return  Products.Where(pred);
        }


        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Product Update(Product entity)
        {
            throw new NotImplementedException();
        }

        public productCrud()
        {
            var x = GetAll(null);
            var x1 = GetAll(new Func<Product, bool>(aaaa));
            var x2 = GetAll(aaaa1);

            var x3 = GetAll(pr=>pr.InStock<10);
        }

        private bool aaaa(Product arg)
        {
            return arg.ID > 100;
        }

        private bool aaaa1(Product arg)
        {
            throw new NotImplementedException();
        }
    }
}