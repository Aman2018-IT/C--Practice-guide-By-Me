using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_ByME
{
     class Vehicle:IDrivable

    {
        public string Brand {  get; set; }

        public Vehicle(string brand="No Brand",int wheels=0,double speed=0) 
        {
            Brand= brand;
            Wheels = wheels;
            Speed = speed;

        }
        public double Speed { get; set; }
        public int Wheels { get; set; }
        public void Move()
        {
            Console.WriteLine($"The {Brand} Moves forward with  {Speed} km/ph");
        }
        public void Stop()
        {
            Console.WriteLine($"The {Brand} is Stoped");
            Speed = 0;
        }


    }
}
