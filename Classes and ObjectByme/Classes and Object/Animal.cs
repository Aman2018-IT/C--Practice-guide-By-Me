using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Object
{
     class Animal
    {
        /*public string name;
        public string sound;*/
        private string name;  // private karne se this can only be access using getter and setter
        private string sound;
        static int numberofAnimals = 0;//yeh spure class ke liye hoga i.e saare object me NumberofAnimal ki value same hogi
        public const string SHELTER = "Dereks home for Animals";//constant
        public readonly int idNum;//id numbers for animals, readonly set only one thime through constructor and cant be change

        // if we do not pass any thing inside our object than by deafult name="No name" and sound will be "No Sound"
        /* public Animal()
         {
             name = "No Name";
             sound = "No Sound";
             numberofAnimals++;
         }*/
        //uper me jo ham ne bnaya hai i.e default constructor ke liye usko ham dusre tarike se bhi kar sakte hai see down below.
        public Animal() : this("No Name", "No Sound") { }



        //Below constructor is if we do not pass sound of animal while creating its object
        /* public Animal(string name= "no name")// kuch name object bnate samye pass hua toh thik hai warna bydefault "no name" le lega
         {
             this.name = name;
             this.sound = "No sound";
             numberofAnimals++;
         }*/
        //or 2nd way to create constructor that accept only one argument is :
        public Animal(string name) : this(name, "NoSound") { }





       /* public Animal(string name="No name",string sound="No Sound")
        {
            this.name = name;   
            this.sound = sound;
            numberofAnimals++;
        }*/

        public Animal(string name,string sound)
        {
            SetName(name);
            Sound= sound;

            numberofAnimals = 1;
            Random rnd=new Random();
            idNum=rnd.Next(1,21467);
        }

        public void MakeSound()
        {
            Console.WriteLine("{0} say {1}",name ,sound);

        }

        public static int GetNumAnimals()
        {
            return numberofAnimals;

        }




        //Creating Getter and setters for names
        public void SetName(string name)
        {
            if(!name.Any(char.IsDigit))
            {
                this.name =name;
            }
            else
            {
                this.name = "No Name";
                Console.WriteLine("Name can't Contain numbers");
            }


        }
        public string GetName()
        {
            return name;
        }



        //Creating Getters and Setters for Sound
        public string Sound
        {
            get { return sound;}
            set
            {
                if(value.Length>10)
                {
                    sound = "No Sound ";
                    Console.WriteLine("Sound is Too Long");
                }
                else
                {
                    sound = value;
                }
            }
        }
        //
        public string Owner { get; set; } = "No Owner";

        public static int numofAnimals
        {
            get { return numberofAnimals; }
            set { numberofAnimals += value; }

        }

    }
}
