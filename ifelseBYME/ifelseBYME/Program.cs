// See https://aka.ms/new-console-template for more information

using System;

namespace ifelseBYME
{
    public class Program
    {
        static void Main(string[] args)
        {
            int age = 19;
            if((age>=5) && (age<=7))
            {
                Console.WriteLine("Go to elementry School");
            }
            else if((age>7) && (age<=18))
            {
                Console.WriteLine("Please go to Primary school");

            }
            else 
            {
                Console.WriteLine("Go to college");

            }
            Console.WriteLine("!true=" + (!true));

            bool canDrive = age >= 18 ? true : false;
            Console.WriteLine("canDrive?="+canDrive);

            switch (age)
            {
                case 4: 
                    Console.WriteLine("go to Primary school");
                    break;
                case 9:
                    Console.WriteLine("go to high  school");
                    break;
                default:
                    Console.WriteLine("out of my Range");
                    goto otherSchool;


            }
        otherSchool:
            Console.WriteLine("Work Hard for yours parent");

            string myName1 = "Jaohmn";
            string myName2 = "Jaohmn";
            if(myName2.Equals(myName1,StringComparison.OrdinalIgnoreCase)) {
                Console.WriteLine("names are equals");
            }
            else
            {
                Console.WriteLine("names are not equals");
            }
        


        }
    }
}
