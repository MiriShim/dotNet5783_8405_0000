using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet5783_8405_0000
{
    internal partial  class Program
    {
        static partial void Hello0000()
        {
            Console.WriteLine("Hello, whats your name?");

            string? n = Console.ReadLine();

            Console.WriteLine($"Welcome {n}");
        }
    }
}
