// See https://aka.ms/new-console-template for more information

using System;

namespace Method_Overloading_Byme
{
    
   
    public class Program
    {

        //Method Overloading
        static double GetSum(double x = 2, double y = 2)
        {
            return x + y;
        }
        static double GetSum(string x = "2", string y = "2")
        {
            double dbxx = Convert.ToDouble(x);
            double dbyy = Convert.ToDouble(y);
            return dbxx + dbyy;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("5.0+6.45={0}", GetSum(5.0,6.45));
            Console.WriteLine("5.0+6.45={0}", GetSum("5.0", "6.45"));


            //Date Time

            DateTime currentDate = new DateTime(1978, 12, 21);
            Console.WriteLine("Day of the Week : {0}", currentDate.DayOfWeek);

            currentDate=currentDate.AddDays(3);
            currentDate= currentDate.AddMonths(1);
            currentDate = currentDate.AddYears(2);
            Console.WriteLine("new date : {0}", currentDate.Date);


            TimeSpan lunchTime = new TimeSpan(12, 30, 0);

            lunchTime=lunchTime.Subtract(new TimeSpan(0, 15, 0));
            Console.WriteLine("New Time : {0}",lunchTime.ToString());


            


        }
    }
}

