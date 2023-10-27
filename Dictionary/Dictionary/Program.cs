// See https://aka.ms/new-console-template for more information

//As we know dictionary me ham key-Value pair store karte hai

using System;

namespace Dictionary
{
     class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("hello");

            Dictionary<string,string> superHero = new Dictionary<string,string>();
            superHero.Add("Clark kent", "Superman");
            superHero.Add("Bruce Waye", "Batman");
            superHero.Add("Barry West", "The Flash");

            superHero.Remove("Barry West");

            Console.WriteLine($"Count : {superHero.Count}");
            Console.WriteLine("Clark :{0}", superHero.ContainsKey("Clark kent"));
            superHero.TryGetValue("Clark kent", out string test);
            Console.WriteLine($"Clark kent : {test}");

            foreach(string key in superHero.Keys)
            {
                Console.WriteLine(key);
            }
            foreach(string value in superHero.Values)
            {
                Console.WriteLine(value);
            } 
        
            foreach(KeyValuePair<string,string> iteam in superHero)
            {
                Console.WriteLine("{0} : {1}",iteam.Key,iteam.Value);
            }


            superHero.Clear();



        }
    }
}
