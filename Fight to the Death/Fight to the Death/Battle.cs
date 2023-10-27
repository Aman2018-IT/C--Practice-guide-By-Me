using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Fight_to_the_Death
{
     class Battle
    {
        //start the fight
        //warrior1 attacks warrior2 and warrior2 is damage and its helth decreases
        //Get attack Result
        //warrior2 attacks warrior1 and warrior1 is damage and its helth decreases
        //Get attack Result


        public static void StartFight(Warrior warrior1 , Warrior warrior2)
        {
            while(true)
            {
                if (GetAttackResult(warrior1, warrior2) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
                if (GetAttackResult(warrior1, warrior2) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
            }
            
        }

        public static string GetAttackResult(Warrior warriorA, Warrior warriorB)
        {
            double warAAtackAmount = warriorA.Attack();
            double warBBlockAmount=warriorB.Block();

            double dmage2warB = warAAtackAmount - warBBlockAmount;

            if(dmage2warB >0)
            {
               warriorB.Health=warriorB.Health-dmage2warB;


            }
            else dmage2warB=0;

            Console.WriteLine("{0} Attacks {1} and Deals {2} Damge",warriorA.Name,warriorB.Name,dmage2warB);
            Console.WriteLine("{0} has  {1} Health", warriorB.Name, warriorB.Health);

            if(warriorB.Health<=0)
            {
                Console.WriteLine("{0} has died and {1} is victorious", warriorB.Name, warriorA.Name);
                return "Game Over";
            }
            else return "Fight Again";


        }




    }
}
