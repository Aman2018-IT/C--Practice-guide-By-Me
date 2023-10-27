// See https://aka.ms/new-console-template for more information
using System;

namespace Lambda
{
    public class Program
    {
        public static void Main(string[] args)
        {
            doubleIT dblit = x => x * 2;//Lambda Expression with delegate
            Console.WriteLine($"5*2={dblit(5)}");

            List<int> numList = new List<int> { 1, 3, 5, 24,67 ,4,8,};
            var evenList = numList.Where(a => a % 2 == 0).ToList();//ToList() convert it to list 
            foreach(var j in evenList)
            {
                Console.WriteLine(j);
            }


            var rangeList = numList.Where(x => (x>2) && (x<9) ).ToList();
            foreach (var i in rangeList)
            {
                Console.WriteLine(i);
            }





            List<int> flipList= new List<int>();
            
            Random rnd=new Random();
            int k = 0;
            while (k<100)
            {
                flipList.Add(rnd.Next(1,3));//1 se n-1 tak
                k++;
            }
            Console.WriteLine($"Heads :{flipList.Where(a => a == 1).ToList().Count()}");
            Console.WriteLine($"Tails :{flipList.Where(a => a == 2).ToList().Count()}");







            var nameList = new List<string> { "Dough", "Sally", "Sue" };
            var sNameList = nameList.Where(x => x.StartsWith("S"));
            foreach(var i in sNameList)
            {
                Console.WriteLine(i);

            }
        }
        delegate double doubleIT(double val);

            

    }
}

