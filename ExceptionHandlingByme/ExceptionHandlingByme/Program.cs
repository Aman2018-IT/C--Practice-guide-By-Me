// See https://aka.ms/new-console-template for more information
using System;
namespace ExceptionHandlingByme
{
    public class Program
    {
        static double DoDivision(double a ,double b)
        {
            if (b == 0) throw new System.DivideByZeroException();
            else return a / b;
        }
        public static void Main(string[] args)
        {
            //we do exception Handling to handle erros in our code using try and catch 

            double number1 = 5;
            double number2 = 0;

            try
            {
                Console.WriteLine(number1 / number2);//or
                Console.WriteLine("5/0={0}", DoDivision(number1, number2));
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("You cant divide 0");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.GetType().Name);

            }
            catch(Exception ex)
            {
                Console.WriteLine("an error Occur ");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.GetType().Name);

            }
            finally
            {
                Console.WriteLine("Close database connection if there is error or not does not matters ");
            }
            

        }
    }
}
