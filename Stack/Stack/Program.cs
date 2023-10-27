// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;

namespace Stackbyme
{
    class Program
    {
        public static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            Console.WriteLine($"Peek :{stack.Peek()}");//lIFO
            Console.WriteLine($"Pop :{stack.Pop()}");

            Console.WriteLine($"Contains : {stack.Contains(1)}");


            object[] numArray=stack.ToArray();
            Console.WriteLine(string.Join(", ", numArray));

            foreach( object obj in stack )
            {
                Console.WriteLine($"Stack : {obj}");
            }

        }
    }
}
