using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight_to_the_Death
{
     class Warrior
    {
        public string Name { get; set; }
        public double Health { get; set; }
        public double AttackMax {  get; set; }
        public double BlockMax {  get; set; }

        Random rnd = new Random();
        
        public Warrior(string name="Warrior",double health=0,double attackmax=0,double blockmax=0)
        { 
            Name = name;
            Health = health;
            AttackMax = attackmax;
            BlockMax = blockmax;
           



        }


        public double Attack()
        {
            return rnd.Next(1,(int)AttackMax);

        }
        public virtual  double Block()
        {
            return rnd.Next(1, (int)BlockMax);

        }
    }
}
