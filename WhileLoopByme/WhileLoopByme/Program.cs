// See https://aka.ms/new-console-template for more information
using System;
namespace WhileLoopByme
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i = 0;
            while (i <= 10)
            {
                if (i % 2 == 0)
                {

              
                i++;
                continue;
                }
                if (i == 9) break;
                Console.WriteLine(i);
                i++;

            }

            Random rnd = new Random();
            int secretNumber = rnd.Next(1, 11);//min=1,max=11 inbetwen number will be generated  
            int NumberGuessed = 0;
            Console.WriteLine("Random Number: ", secretNumber);
            do
            {
                Console.WriteLine("Enter a number between 1 to 10");
                NumberGuessed = Convert.ToInt32(Console.ReadLine());
            } while (secretNumber != NumberGuessed);

             
        }
    }
}
