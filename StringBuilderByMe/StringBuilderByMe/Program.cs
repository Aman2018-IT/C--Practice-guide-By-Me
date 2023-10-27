// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;
using System.Text;

namespace StringBuilderByMe
{
    public class Program
    {
        public static void Main(string[] args) { 
        
            //string builder ki help se ham original string ko change kar sakte hai insted of making copy of string.
            StringBuilder sb=new StringBuilder("Random Text");//string builder ka default size 14 charcter ka hota haoi but we can increase it
            StringBuilder sb1 = new StringBuilder("More stuff than usual and it is very Important ",256);//256 charcter ka kar diya size
            Console.WriteLine("capacity :{0}",sb1.Capacity);
            Console.WriteLine("Length :{0}", sb.Length);
            Console.WriteLine("capacity :{0}", sb.Capacity);
            sb1.AppendLine("\n and more more needful have to be done");
            Console.WriteLine(sb1);

            //culture specfic formating
            CultureInfo enUs = CultureInfo.CreateSpecificCulture("en-US");
            string bestCust = "Bob Smith";
            sb1.AppendFormat(enUs, "Best Customer : {0}",bestCust);
            Console.WriteLine(sb1.ToString());

            sb1.Replace("more", "less");
            Console.WriteLine(sb1.ToString());
            sb1.Clear();
            sb1.Append("Random Text");
            Console.WriteLine(sb.Equals(sb1));
            sb1.Insert(11, " Thats Good ");
            Console.WriteLine(sb1.ToString());
            sb1.Remove(11, 6);
            Console.WriteLine(sb1.ToString());




        }
    }
}
