namespace DalAPI
{
   public  interface ICRUD<T>
    {
        IEnumerable<T?> GetAll(Func<T?, bool>? predicate=null);   

        T Add(T entity);
        T GetById(int id);
        T Update(T entity);
        bool Remove(int id)
        {
            Console.WriteLine("entity removed");
            return true;
        }

        static void method()
        {
            
        }
       
    }
}