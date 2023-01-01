using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using m = System.Math;

namespace BlTest
{
    internal class LearnExamples
    {
        public void OptParameters(int a, int x = 8, int t = 55)
        {
            Console.WriteLine(x);

        }

        public LearnExamples()
        {
            #region named parameters
            OptParameters(3, 4, 5);
            OptParameters(3);
            OptParameters(3, 4);
            OptParameters(3, t: 4);
            #endregion

            #region Local function
            int yy;
            //פונקציה מקומית::local function
            bool IsNullAble(Type t) => Nullable.GetUnderlyingType(typeof(Product)) != null;
            bool IsNullAble1(Type t) { yy = 66; return Nullable.GetUnderlyingType(typeof(Product)) != null; };

            bool b = IsNullAble(typeof(Product));
            //use tupple

            var value = (5, "ff", "rrr");//without names 
            #endregion

            #region Tupple
            var value1 = (Number: 5, str: "ff", "rrr");//with names
            int x = value1.Number;
            string xx = value.Item3;
            //פרוק של טאפל למשתנים באופן מהיר
            var (city, population, size) = QueryCityData("New York City");
            (string ss, int population, double size) res = QueryCityData("New York City");
            Console.WriteLine(res.ss);


            var result = QueryCityData("New York City");
            var city1 = result.Item1;
            var population2 = result.Item2;
            var size3 = result.Item3;
            //יש דרך לפרק את כל האוביקט לערכים
            //  (string ss, int population, double size) = result  ; 
            #endregion

            #region switch
            //switch::
            // switch against any type:

            int a = 1, d = 2;
            switch ((a, d))
            {
                case ( > 0, > 0) when a == d: break;
                case ( > 0, > 5):
                    break;
            }
            //switch expresion
            int i = -1;
            Console.WriteLine(i + 2 switch
            {
                1 => "One",
                2 => "Two",
                > 2 => "Many",
                _ => "Non-positive"
            });
            #endregion

        # region static using
                    var result1 = m.Cos(9);
            #endregion

            //?
            //??

            Product? pMaybeNull = new Product() { };
            int? number = 9;
            int value3 = number ?? 99;
            Product pSure = pMaybeNull ?? new Product();

            Person p = new Person();
            p = null;
            p.Name = "ggg";
            xxx(null);
        }

        void xxx (Person? p)
        {   
            Console.WriteLine(p?.Name );
        }

        void xxxProduct(Product? p)
        {
            Console.WriteLine(p?.ProductName);
            Console.WriteLine(p.HasValue?p.Value.ProductName :"no value");
        }


        //use tupple - function returns tupple
        (string, int, double) QueryCityData(string name)
        {
            if (name == "New York City")
                return (name, 8175133, 468.48);
            return ("", 0, 0);
        }

    }



}
