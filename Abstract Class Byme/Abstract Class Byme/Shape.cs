using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Byme
{
    abstract class Shape// abstract keyword likhna hoga to make class as abstract class

    {
        public string Name
        {
            get;set;
        }

        
        public virtual void GetInfo()
        {
            Console.WriteLine($"This is a {Name}");


        }
        //we can only make abstract methods inside of abstract classes
        public abstract double Area();


    }
}
