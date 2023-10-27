// See https://aka.ms/new-console-template for more information

using System;

namespace EnumeratorByme
{
    public class Program
    {
        static void PaintColor(CarColor cc)
        {
            Console.WriteLine("The Car was painted {0} with the code {1}",cc,(int)cc);
        }
        //An enum is a special class that represent a group of constants(unchangeable/read-only variables)
        enum CarColor:byte
        {
            orange=1,
            Blue=2,
            Red=3,
            Green,
            yellow,

        }
        public static void Main(string[] args)
        {
            CarColor Car1=CarColor.yellow;
            PaintColor(Car1);

        }
    }
}