using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
     class Animal
    {
        public string Name { get; set; }
        public Animal(String name="No Name") { Name = name; }

        public static void GetSum<T>(ref T num1,ref T num2)
        {
            double dblX=Convert.ToDouble(num1);
            double dblY=Convert.ToDouble(num2);
            Console.WriteLine($"{dblX}+{dblY}={dblY+dblX}");


        }
    }
}
