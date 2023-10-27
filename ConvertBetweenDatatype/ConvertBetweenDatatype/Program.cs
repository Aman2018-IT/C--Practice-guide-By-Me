// See https://aka.ms/new-console-template for more information

using System;

 namespace ConvertBetweenDatatype
 {
    public class Program
    {
        static void Main(string[] args) 
        {

            bool boofromStr = bool.Parse("true");
            int intFromStr = int.Parse("100");
            double dbFromStr = double.Parse("1.234");

            string strVal = dbFromStr.ToString();


            Console.WriteLine($"Data Type :{strVal.GetType()}");


            //Converting double to integer means lossing decimal values
            //lossing data means Explict conversion
            double dblNum = 12.345;
            Console.WriteLine($"Integer value : {(int)dblNum}");

            //Implict conversion means no data lose i.e samller data type is getting converted to bigger data type
            int intNum = 10;
            long longNum = intNum;
            Console.WriteLine(longNum);


            Console.WriteLine("Currency : {0:c}", 23.455);
            Console.WriteLine("Add with 0s : {0:d4}", 23);
            Console.WriteLine("3 decimals places : {0:f3}", 23.45555);
            Console.WriteLine("Commas : {0:n3}", 23000);

            string randString = "This is a string";
            Console.WriteLine(randString.Length);
            Console.WriteLine("String Contains : {0}",randString.Contains("is"));
            Console.WriteLine("Index of is : {0}", randString.IndexOf("is"));
            Console.WriteLine("Remove String : {0} ", randString.Remove(10, 6));
            Console.WriteLine(randString);//Means string is Immutable
            Console.WriteLine("Insert String : {0}", randString.Insert(10, "Short "));
            Console.WriteLine(randString);//String is Immutable

            Console.WriteLine("Replace a string :{0}", randString.Replace("string", "sentance"));
            Console.WriteLine("compare a string A and B : {0}", string.Compare("A", "B"));
            Console.WriteLine("compare a string A and B : {0}", string.Compare("c", "a",StringComparison.OrdinalIgnoreCase));


            Console.WriteLine("---------------------------");


            Console.WriteLine("A=a:{0}", String.Equals("A", "a",StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Pad Left : {0}",randString.PadLeft(20));
            Console.WriteLine("Pad Left : {0}", randString.PadLeft(20,'.'));
            Console.WriteLine("Pad right : {0}", randString.PadRight(90,'.'));

            Console.WriteLine("Trim White space : {0}", randString.Trim());
            Console.WriteLine("UpperCase : {0} ",randString.ToUpper());

            string newString = string.Format("{0} saw a {1} {2} in the {3}", "paul", "Playing", "ground", "field");
            Console.Write(newString + "\n");

            //Escape Character
            // \' \\ \t \a
            Console.WriteLine(@"Exactly i Typed \n");



        }
    }
}
