// See https://aka.ms/new-console-template for more information
using Classes_and_Object;
using System;
using System.Runtime.InteropServices;

namespace Classes_and_ObjectByme
{
    public class Program
    {
        public static void Main(string[] args)
        {
           /* Rectangle rect1;
            rect1.length = 200;
            rect1.width = 50;
            Console.WriteLine("Area of Reactangle is :{0}", rect1.Area());

            Rectangle rect2=new Rectangle(400,40);
            Console.WriteLine("Area of Reactangle is :{0}", rect2.Area());
            rect2 = rect1;
            rect1.length = 33;
            Console.WriteLine("Rect2.length:{0}", rect2.length);
            Console.WriteLine("Rect2.width:{0}", rect2.width);
            Console.WriteLine("Rect1.length:{0}", rect1.length);




            Animal Fox = new Animal()
            {
                name = "Red",
                sound = "Raaw"
            };

            Console.WriteLine("Total number of animals : {0}",Animal.GetNumAnimals());

            Console.WriteLine("Area of reactangle :{0}", ShapeMath.GetArea("Rectangle", 5, 6));


            //Database se handle karte samye null datatype ka bahut use hota hai.
            //Null datatype in c#
            int? randNumer = null;//? allows us to work with null 
            if(randNumer == null)
            {
                Console.WriteLine("randNum is Null");

            }
            if(!randNumer.HasValue) { Console.WriteLine("randnumber is null"); }   */






            Animal cat=new Animal();
            cat.SetName("Whisker");//using setter because name is private
            cat.Sound = "Meow";

            Console.WriteLine("The cat name is {0} and say {1}",cat.GetName(),cat.Sound);
            cat.Owner = "dreak";
            Console.WriteLine("{0} owner is {1} ",cat.GetName(),cat.Owner);
            Console.WriteLine("{0} Shelter id is  is {1} ", cat.GetName(), cat.idNum);
            Console.WriteLine("# of animals : {0}", Animal.numofAnimals);





             


           
        }
        
           /* struct Rectangle
            {
                    public double length;
                    public double width;

            //Constructor
                    public Rectangle(double l = 1, double w = 1)
                    {
                        length = l;
                        width = w;
                    }
                    public double Area()
                    {
                        return length * width;
                    }

            }*/
      }

     
   
}
