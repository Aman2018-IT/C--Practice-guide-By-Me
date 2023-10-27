// See https://aka.ms/new-console-template for more information

using Delegate;
using System;

namespace Delegate
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Animal> animalList = new List<Animal>();
            List<int> numberlist = new List<int>();
            numberlist.Add(24);

            animalList.Add(new Animal() { Name = "dog" });
            animalList.Add(new Animal() { Name = "Cat" });
            animalList.Add(new Animal() { Name = "Tiger" });

            animalList.Insert(1, new Animal() { Name = "Cow" });//at 1 position Insert
            animalList.RemoveAt(1);
            Console.WriteLine($"Number of Animal : {animalList.Count()}");
            foreach (Animal A in animalList)
            {
                Console.WriteLine(A.Name);
            }

            int x = 5, y = 55;
            Animal.GetSum<int>(ref x, ref y);
            //ham bta rhe hai ki <t> GetSum me jo hai int data type ka hai

            string strX = "5", strY = "6";
            Animal.GetSum<string>(ref strX, ref strY);



            Rectangle<int> rect1 = new Rectangle<int>(20, 20);
            Console.WriteLine(rect1.getarea());

            Rectangle<string> rect2 = new Rectangle<string>("20", "20");
            Console.WriteLine(rect2.getarea());



            Arithmetic add, sub, addSub;
            add = new Arithmetic(Add);
            sub = new Arithmetic(subtract);
            addSub = add + sub;

            Console.WriteLine($"Add {6} & {10}");
            add(6, 10);
            Console.WriteLine($"Add & subtract {10} & {1}");
            addSub(10, 1);

        }

        public struct Rectangle<T>
        {
            private T width;
            private T length;

            public T Width
            {
                get { return width; }
                set { width = value; }

            }
            public T Length
            {
                get { return length; }
                set { length = value; }

            }

            public Rectangle(T w, T l)
            {
                width = w;
                length = l;
            }

            public string getarea()
            {
                double dblwidth = Convert.ToDouble(width);
                double dbllength = Convert.ToDouble(length);
                return string.Format($"{width}*{length}={dbllength * dblwidth}");
            }


        }

        public delegate void Arithmetic(double num1, double num2);

        public static void Add(double num1, double num2)
        {
            Console.WriteLine($"{num1}+{num2}={num1+num2}");

        }
        public static void subtract(double num1, double num2)
        {
            Console.WriteLine($"{num1}-{num2}={num1 - num2}");

        }


    }
    
}
