// See https://aka.ms/new-console-template for more information
using System;

namespace Interface_ByME
{
    class Program
    {
        public static void Main(string[] args)
        {
             Vehicle Tata = new Vehicle("Tata",4,400);
             if(Tata is IDrivable)
            {
                Tata.Move();
                Tata.Stop();
            }
            else
            {
                Console.WriteLine("This car is faulty and can't be driven",Tata.Brand);
            }




        }
    }
}

