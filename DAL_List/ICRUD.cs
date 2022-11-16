namespace DAL
{
    internal interface    ICRUD<T>
    {
        
        List<T> GetAll();   

        T Add(T entity);
        T GetById(int id);
        T Update(T entity);
        bool Remove(int id);
       
    }
}