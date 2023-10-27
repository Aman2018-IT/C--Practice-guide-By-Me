// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.DataAnnotations;

namespace Select
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Select execute function on each iteam on a list

            var onTo10 = new List<int>();
            onTo10.AddRange(Enumerable.Range(1, 10));

            var squares=onTo10.Select(x=>x*x);
            foreach(var x in squares)
                Console.WriteLine(x);
        }
    }
}
