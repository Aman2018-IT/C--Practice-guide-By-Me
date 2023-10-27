// See https://aka.ms/new-console-template for more information
using System;

namespace ArraysByme
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello aman");
            int[] integerarray1 = new int[5];
            int[] integerarray2 = { 3, 5, 7 };
            integerarray1[0] = 9;
            Console.WriteLine("faviourte Number ; {0}", integerarray1[0]);

            string[] integerarray3 = { "bob", "sally", "sue" };

            var employees = new[] { "mike", "paul", "Ricj" };
            int[] integerarray4 = new int[] { 3, 5, 7 };
            object[] randoarray = { "Paul", 34, 12.22 };
            Console.WriteLine(randoarray.GetType());
            Console.WriteLine(employees.GetType());
            Console.WriteLine(integerarray3.GetType());
            Console.WriteLine(integerarray4.GetType());

            Console.WriteLine("---------------");
            Console.WriteLine(integerarray3.Length);

            for(int i=0;i<integerarray3.Length;i++)
            {
                Console.WriteLine(integerarray3[i]);
            }

            Console.WriteLine("----------------------------");

            string[,] custName = new string[2, 2] { { "Bob", "John"},
            {"Rohan" ,"Mike" }
            };
            Console.WriteLine(custName.GetValue(1,1));

            for(int i=0; i<custName.GetLength(0);i++)
                
            {
                for(int j = 0; j < custName.GetLength(0);j++)
                {
                    Console.WriteLine("index : {0,1} and value : {1} ", (i,j), custName[i, j]);
                }
                
            }

            int[] randNums = { 1, 3, 5, 6 ,2};
            PrintArray(randNums, "forEachLoop");
            Console.WriteLine("---------------");

            Array.Sort(randNums);
            Array.Reverse(randNums);
            Console.WriteLine(Array.IndexOf(randNums, 1));
            
            foreach(int i in randNums) Console.WriteLine(i);
            randNums.SetValue(0, 1);
            
            foreach (int i in randNums) Console.WriteLine(i);

            int[] srcArray = { 1, 2, 3 };
            int[] desArray = new int[2];
            int startInd = 0;
            int length = 2;
            
            
            Array.Copy(srcArray, startInd, desArray, 0, length);
            PrintArray(desArray, "copy");

            //another way to create Array in c#
            Array anotherArray = Array.CreateInstance(typeof(int), 10);
            srcArray.CopyTo(anotherArray, 5);
            foreach (int i in anotherArray) Console.WriteLine(i);



            int[] numArray = { 1, 12, 4, 5 };
            //Console.WriteLine(">10:{0}",Array.Find(numArray,GT10));


        }
        static void PrintArray(int[] intArray,string message)
        {
            foreach(int k in intArray)
            {
                Console.WriteLine("{0} : {1}",message,k);

            }
        }
    }
}
