using System.Reflection;
using System.Text;

namespace DALFacade
{
    //    קוד לביצוע tostring במתודת הרחבה ע"י reflection

    public static  class Utiliies
    {
       
            public static string ToStringProperty<T>(this T t)
            {
            StringBuilder sBuilder = new();
            foreach (PropertyInfo item in typeof(T).GetProperties())
                sBuilder.AppendLine($"{item.Name} : { item.GetValue(t, null)}"); ;
                return sBuilder.ToString();
            }
        
    }

    //  העתקה עמוקה גנרית, כפונקציית הרחבה

    namespace DL
    {
        static class Cloning
        {

            internal static T Clone<T>(this T original) where T : new()
            {
                T copyToObject = new T();
                //T copyToObject = (T)Activator.CreateInstance(typeof(T));

                foreach (PropertyInfo propertyInfo in typeof(T).GetProperties())
                    propertyInfo.SetValue(copyToObject, propertyInfo.GetValue(original, null), null);

                return copyToObject;
            }


        }
    }
    
