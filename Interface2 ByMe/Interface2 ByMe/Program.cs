// See https://aka.ms/new-console-template for more information
using System;

namespace Interface2_ByMe
{
    class Program
    {
        public static void Main(string[] args) 
        {
            IElectronicDevice Tv = TvRemote.GetDevice();

            PowerButton powBtn=new PowerButton(Tv);

            powBtn.Execute();
            powBtn.Undo();

        }
    }
}
