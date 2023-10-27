// See https://aka.ms/new-console-template for more information
using System;
namespace MethodByme
{
    public class Program
    {
         //Access Specifier
        //public: can ne acccessed from onther class
        //private:can't be accessed from other class
        //protected ; can't be accessed from other class but can be accessed from derived class
        public static void Main(string[] args)
        {
            Greeting();
           Console.WriteLine( GetSum(7, 9));
            double x = 5;
            double y = 10;
            Console.WriteLine( GetSum(x,y ));
            Console.WriteLine( "x={0}",x);


            int solution;
            doubleIt(18, out solution);
            Console.WriteLine("18*2={0}", solution);



            int num3 = 10;
            int num4 = 20;
            Console.WriteLine("Before Swap num3 : {0} num4 : {1} ", num3, num4);
            Swap(ref num3, ref num4);
            Console.WriteLine("After Swap num3 : {0} num4 : {1} ", num3, num4);


            Console.WriteLine("1+2+3+4= {0}", GetSumMore(1, 2, 3, 4));

          PrintInfo(zipCode: 14726, name:"Aman");//named parameter i.e we are passing with the name of the parameter 


            
            

        }
        private static void Greeting()
        {
            int CurrentYear;
            Console.WriteLine(" Whats the current year in which you are ");
            CurrentYear =Convert.ToInt32( Console.ReadLine() );
            Console.WriteLine("hello : {0}", CurrentYear);

        }

        static double GetSum(double x=1,double y=1)
        {
            // return x + y;
            double temp = x;
            x = y;
            y=temp;
            return x + y;
        }

        static void doubleIt(int x, out int solution)
        {
            solution = x * 2;

        }

        //pass by reference so that actual variable me changes ho
        public static void Swap(ref int num3, ref int num4)
        {
            int temp = num3;
            num3=num4;
            num4 = temp;


        }

        static double GetSumMore(params double[] nums)
        {
            double sum = 0;
            foreach(int i in nums)
            {
                sum += i;
            }
            return sum;
        }


        static void PrintInfo(string name, int zipCode)
        {
            Console.WriteLine("{0} lives in the zip code {1}", name, zipCode);

        }
    }
}
