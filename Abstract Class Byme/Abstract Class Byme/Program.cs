// See https://aka.ms/new-console-template for more information

using System;

namespace Abstract_Class_Byme
{
    class Program
    {
        public static void Main(string[] args)
        {
            //some time we need to class jiska instance/object  na bne then us case ham abstract class bnate hai
            //

            Shape[] shapes = { new Circle(5), new Rectangle(4, 5) };//shapes Array

            foreach (Shape s in shapes)
            {
                s.GetInfo();
                Console.WriteLine("{0} Area : {1:f2}", s.Name, s.Area());//f2 me till 2 decimal place it will accept

                Circle testCir = s as Circle;
                if (testCir == null)
                {
                    Console.WriteLine("This isn't a Circle");
                }
                if (s is Circle)
                {
                    Console.WriteLine("This isn't a Rectangle");
                }
            }

            object circ1 = new Circle(4);
            Circle circ2 =  (Circle)circ1;//type casting
            Console.WriteLine("The {0} Area  is {1:f2}",circ2.Name, circ2.Area());


        }
    }
}