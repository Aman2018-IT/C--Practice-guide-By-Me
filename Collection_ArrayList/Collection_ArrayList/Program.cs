// See https://aka.ms/new-console-template for more information

using System;
using System.Collections;
using System.Collections.Generic;


namespace Collection_ArrayList
{
    class Program
    {
        public static void Main(string[] args) 
        {
            #region ArrayList Code //ArrayList are resizable array that can hold multiple data type

            ArrayList aList=new ArrayList();
            aList.Add(1);
            aList.Add("bIb");
            aList.Add(true);
            aList.Add(null);

            foreach(object i in aList) 
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Length of our array is :"+aList.Capacity);
            Console.WriteLine("Count is : " + aList.Count);

            ArrayList aList2= new ArrayList();
            aList2.Add(new object[] { "Mike", "Pooja" });
            aList.AddRange(aList2);//Add kardega 
            foreach (object i in aList)
            {
                
                Console.WriteLine(i);
            }
            Console.WriteLine("Length of our array is :" + aList.Capacity);
            Console.WriteLine("Count is : " + aList.Count);





            aList2.AddRange(aList);
            aList2.Sort();
            aList2.Reverse();
            aList2.Remove(3);
            aList2.RemoveRange(0, 2);//remove Multiple iteams
            aList2.Insert(2, "Aman");
           
            Console.WriteLine("Aman Index is :" + aList2.IndexOf("Aman",0));
            foreach (object i in aList2)
            {

                Console.WriteLine(i);
            }
            Console.WriteLine("Length of our array is :" + aList2.Capacity);
            Console.WriteLine("Count is : " + aList2.Count);

            string[] myArary = (string[])aList.ToArray(typeof(string));

            string[] cust = { "Boo", "Sally", "Sue" };
            ArrayList custArrayList=new ArrayList();
            custArrayList.AddRange(cust);



            #endregion 
        }
    }
}
