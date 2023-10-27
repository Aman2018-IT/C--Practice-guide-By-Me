// See https://aka.ms/new-console-template for more information
using System;

namespace Zipp
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Zip basically apply function to List

            var ListOne = new List<int>(new int[] { 1, 3, 4 });
            var ListTwo = new List<int>(new int[] { 4, 6, 8 });

            var SumList=ListOne.Zip(ListTwo,(x,y)=>x+y).ToList();
            foreach(var x in SumList)
                Console.WriteLine(x);
            



            //Aggerate Method
            var numList2=new List<int>() { 1,2,3,4,3};
            Console.WriteLine("Sum : {0}",numList2.Aggregate((a,b)=>a+b));

            //Average Method
            Console.WriteLine("Average : {0}", numList2.AsQueryable().Average());

            //All Method
            Console.WriteLine("All >3 :{0}", numList2.All(x => x > 3));

            //Any Method
            Console.WriteLine("Any >3 : {0}",numList2.Any(x=> x > 3));

            //Distinct Method and Join Method
            Console.WriteLine("Distinct : {0}",string.Join(",",numList2.Distinct()));

            //Except method
            var numList3 = new List<int>() { 3 };
            Console.WriteLine("Except : {0}",string.Join(",", numList2.Except(numList3)));

            //Intersect
            Console.WriteLine("Intersect : {0}",string.Join(",",numList2.Intersect(numList3)));

            
        }
    }
}
