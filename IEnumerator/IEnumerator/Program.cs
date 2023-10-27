// See https://aka.ms/new-console-template for more information

using IEnumeratorByme;
using System;

namespace IEnumeratorByMe
{
 class Program
    {
        public static void Main(string[] args)
        {

            //IEnumerable Interface is used to iterate a given object on c#. It contain method call GetEnumerator
            AnimalFarm myAnimals = new AnimalFarm();
            myAnimals[0] = new Animal("Wilbur");
            myAnimals[1] = new Animal("Templeton");
            myAnimals[2] = new Animal("Gandar");
            myAnimals[3] = new Animal("Charlotte");
            foreach(Animal i in myAnimals) { Console.WriteLine(i.Name); }

            Console.WriteLine(myAnimals.Count);



        }
    }

}
