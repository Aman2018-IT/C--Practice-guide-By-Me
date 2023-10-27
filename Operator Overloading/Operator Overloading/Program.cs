// See https://aka.ms/new-console-template for more information
using Operator_Overloading;
using System;

namespace Operator_oveloading
{
    class Program
    {
        public static void Main(string[] args)
        {
            Box box1 = new Box(2, 3, 4);
            Box box2 = new Box(5, 8, 4);
            Box box3 = box1 + box2;


            Console.WriteLine($"Box3: {box3}");
            Console.WriteLine($"Box int : {(int)box3}");
            Box box4 = (Box)4;





            //Anynomus Types

            //some time you will create simple class that contins fields and at that movement  Anyomous class we will use to create it 
            var Shopkins = new { Name = "Shopikns", Price = 4.99 };
            Console.WriteLine("{0} cost ${1}", Shopkins.Name, Shopkins.Price);

            //These Anynomous type can also be stored in array
            var toArray = new[] { new{ Name="Yo-Good-me",Price=4.99},
             new { Name="Legos",Price = 9.99 }};


            Console.WriteLine(toArray[0]);
            Console.WriteLine(toArray[0].Price);


            foreach (var item in toArray )
            {
                Console.WriteLine("{0} Cost ${1}",item.Name,item.Price);
            }
            


        }
    }
}

