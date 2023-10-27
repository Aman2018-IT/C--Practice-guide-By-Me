// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;

namespace Queues
{
    class Program
    {
        public static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);   
            queue.Enqueue(4);

            Console.WriteLine("queue element Contain : {0}",queue.Contains(1));
            Console.WriteLine("Remove  : {0}", queue.Dequeue());
            Console.WriteLine("Peek element  : {0}", queue.Peek());

            object[] numArray= queue.ToArray();//copying queue into array
            Console.WriteLine(string.Join(", ", numArray));//all the individual string will be seperated by comma

            foreach (var item in numArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Amamamamamamamamamam");
            foreach(object i in queue)
            {
                Console.WriteLine(i);
            }    
            queue.Clear();


        }
    }

}
