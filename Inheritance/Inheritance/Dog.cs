using Classes_and_Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inheritance
{
    class Dog : Animal

    {
        public string Sound2 { get; set; } = "Grrr";

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound} and {Sound2}");
        }
         public Dog(string name="No NAME",string sound="No SOUND" ,string sound2="No SOUND 2"):base(name,sound)//basee class jo name and sound dega usko hi ham use karna chate hai
        {
            Sound2= sound2;

        }
    }
}
