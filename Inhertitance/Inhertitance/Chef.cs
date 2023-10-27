using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertitance
{
    internal class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("The Chef Chicken");

        }
        public void MakeSalad()
        {
            Console.WriteLine("Chef Malke Salad");
        }
        public virtual void MakeSpecialDish()//Method Ovveriding , virtual matlb inherit calss abne accordin iss method ko modify kar sakta hai
        {
            Console.WriteLine("Chef make bbq ribs");

        }

    }
}
