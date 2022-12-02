namespace DalAPI
{
   public  interface ICRUD<T>
    {
        
        IEnumerable <T> GetAll();   

        T Add(T entity);
        T GetById(int id);
        T Update(T entity);
        bool Remove(int id);
       
    }
}