// See https://aka.ms/new-console-template for more information


using System;

namespace JustPractice
{
    public class Program
    {
        static void Main(string[] args)
        {

            /* Console.ForegroundColor = ConsoleColor.Black;
             Console.BackgroundColor = ConsoleColor.White;
             Console.Clear();
             Console.WriteLine("Hello Aman");
            */

            Console.WriteLine("Biggest Integer : {0} ", int.MaxValue);
            Console.WriteLine("smallest Integer : {0} ", int.MinValue);


            Console.WriteLine("Biggest Long : {0}",long.MaxValue);
            Console.WriteLine("Smallest Long :{0}", long.MinValue);

            decimal deciPiValue = 3.334734984037388998383004749934M;
            decimal decBigNum = 3.0000000000000000000000000000000000000011M;

            Console.WriteLine("Decimal : PI + bigNum={0}", deciPiValue + decBigNum);


            Console.WriteLine("Biggest Decimal : {0} ",decimal.MaxValue);
            Console.WriteLine("smallest Decimal : {0} ", decimal.MinValue);

            Console.WriteLine("Biggest Double : {0} ",double.MaxValue);
            Console.WriteLine("Samallest Double :{0} ", double.MinValue);


            double dbPiVal = 3.14159265358975;
            double dbBigNum = 3.14159265358975;
            Console.WriteLine("Addiding it up = {0}", dbPiVal + dbBigNum);


            Console.WriteLine("Biggest Float : {0} ", float.MaxValue);
            Console.WriteLine("Samallest Float :{0} ", float.MinValue);


            float flPiVal = 3.14159F;
            float flBigNum = 3.1415F;
            Console.WriteLine("Addiding it up = {0}", flPiVal + flBigNum);

        }
    }
}
