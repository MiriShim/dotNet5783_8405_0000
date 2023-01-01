namespace BlApi
{
    public class BL_Factory
    {
        public static IBL Get()
        {
            return new BlImlementation.BL() ;
        }
    }
}
