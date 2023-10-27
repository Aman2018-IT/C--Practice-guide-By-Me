// See https://aka.ms/new-console-template for more information
using System;

namespace Fight_to_the_Death
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Warrior thor = new Warrior("Thor",100,26,10);
            //Warrior loki = new Warrior("Loki", 100, 26, 10);
            MAgicWarrior loki = new MAgicWarrior("Loki", 75, 20, 10,50);
            Battle.StartFight(thor, loki);


        }
    }
}
