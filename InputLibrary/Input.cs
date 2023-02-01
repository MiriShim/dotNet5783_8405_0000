using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InputLibrary
{
    public  class Input
    {
        //public static int ReadInt(string message)
        //{
        //    Console.WriteLine(message );
        //    string s  ;
        //    int inputValue;
        //    do
        //    {
        //       // Console.WriteLine("The value is not valid");
        //        s = Console.ReadLine();
        //    }
        //    while (!int.TryParse(s, out inputValue));
        //    return inputValue;
        //}

        public static int ReadInt(string message,int min=0,int max=0)
        {  
            Console.WriteLine(message);
            string s;
            int inputValue;
            do
            {
                s = Console.ReadLine();
            }
            while (!int.TryParse(s, out inputValue)
            || (max != 0 && inputValue>max ) 
            || (min != 0 && inputValue <min));

            return inputValue;
        }

        public  static bool ReadBool(string v)
        {
            Console.WriteLine(v);
            string userInput;
            bool boolInputValue;
            do
            {
                userInput = Console.ReadLine();
            }
            while (bool.TryParse(userInput, out boolInputValue)   );

            return boolInputValue;
        }

        public static string ReadString(string v ,[Optional]ConsoleColor? color)
        {
            ConsoleColor prevColor = Console.ForegroundColor;
            if (color != null)
                Console.ForegroundColor = color.Value;
            Console.WriteLine(v); 
            string s=Console.ReadLine();
            Console.ForegroundColor = prevColor ;
            return s;
        }
    }
}
