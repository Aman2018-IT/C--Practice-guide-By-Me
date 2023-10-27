using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertitance
{
    internal class ItalianChef : Chef
    {
        public void MakePasta()
        {
            Console.WriteLine("Make Pasta");
        }

        public override void MakeSpecialDish()//Method Ovveriding , virtual matlb inherit calss abne accordin iss method ko modify kar sakta hai
        {
            Console.WriteLine("Chef make Chiken Korma");

        }

    }
}
