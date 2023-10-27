using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight_to_the_Death
{
    class MAgicWarrior:Warrior
    {
        int teleportChance = 0;

        CanTeleports teleportsType=new CanTeleports();
        public MAgicWarrior(string name="Warrior",double health=0,double attackMax=0,double blockmax=0,int teleportchance=0) : base(name,health,attackMax,blockmax)
        {
            this.teleportChance = teleportchance;
        }

        public override double Block()
        {
            Random rnd=new Random();
            int rndDodge = rnd.Next(1,100);

            if(rndDodge<this.teleportChance)
            {
                Console.WriteLine($"{Name} {teleportsType.teleport()}");
                return 10000;
            }
            else
            {
                return base.Block();
            }


        }


    }
}
