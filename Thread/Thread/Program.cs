// See https://aka.ms/new-console-template for more information
using System;
using static System.Threading.Thread;

namespace threadByme
{
    class Program
    {

        //static void Print1()
        //{
        //    for (int i=0; i < 1000;i++)
        //    {
        //        Console.Write(1);
        //    }
        //}
        public static void Main(string[] args)
        {
            //With Threads 
            /* Thread t = new Thread(Print1);
             t.Start();
             Console.WriteLine();
             for (int i=0;i < 1000;i++) { Console.Write(0); } */


            /*  int num = 1;
              for(int i=0;i<10;i++)
              {
                  Console.WriteLine(num);
                  Thread.Sleep(1000);
                  num++;

              }
              Console.WriteLine("Thread ends Execution"); */



            /*  BankAcct Acct = new BankAcct(10);
              Thread[] threads = new Thread[15];

              Thread.CurrentThread.Name = "main";

              for(int i=0;i<15;i++)
              {
                  Thread t = new Thread(new ThreadStart(Acct.IssueWithdraw));
                  t.Name=i.ToString();
                  threads[i] = t;
              }
              for (int i= 0; i < 15; i++)
              {
                  Console.WriteLine("Thread {0} Alive : {1}", threads[i].Name, threads[i].IsAlive);
                  threads[i].Start();


                  Console.WriteLine("Thread {0} Alive : {1}", threads[i].Name, threads[i].IsAlive);

              }

              Console.WriteLine("Current Priority : {0}", Thread.CurrentThread.Priority);
              Console.WriteLine("Thread {0} Ending : {1}", Thread.CurrentThread.Name); */



            Thread t = new Thread(()=>Count(10));
            t.Start();

            new Thread(() => //multiline Lambda
            {
                Count(5);
                Count(4);
            }).Start();




        }

        static void Count(int maxNum)
        {
            for (int i = 0; i < maxNum; i++) { Console.WriteLine(i); }
        }
    }
}
