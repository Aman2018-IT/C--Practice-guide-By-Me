// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;

namespace Linq
{
    class program
    {
        public static void Main(string[] args)
        {
            
           
            Console.WriteLine("Linq");
            //Language Integrete Query 
            //It is simillar to Sql and with the help of Linq we can work with data
            //it provide tools to work with data  and data bases

            string[] dogs = {"K 9","Brian Giraffe","Benji","Scooby Doo","old Yeller","Rin Yin Tin",
            "Charlie B. Barkin","Lassie","Snoopy"};

            var dogSpaces=from dog in dogs
                          where dog.Contains(" ") orderby dog descending select dog;

            foreach( var dog in dogSpaces )
            {
                Console.WriteLine(dog);
            }


            int[] intArray = QueryIntArray();
            foreach (var num in intArray)
            {
                Console.WriteLine(num);
            }
            




           




        }
        static int[] QueryIntArray()//it will return int array
        {
            int[] nums = { 5, 10, 15, 20, 25, 30, 35, 40, 45 };
            var gt20 = from num in nums
                       where num > 20
                       orderby num
                       select num;
            foreach( var num in gt20 )
            {
                Console.WriteLine(num);
            }
            Console.WriteLine($"Get Type : {gt20.GetType()}");
            var listGT20=gt20.ToList<int>();//converting gt20 to list
            var arrayGT20=gt20.ToArray<int>();//converting it to Array

            nums[0] = 90;
            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }

            return arrayGT20;
         



        }
    }
}
