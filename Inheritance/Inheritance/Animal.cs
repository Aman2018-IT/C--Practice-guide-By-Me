using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance;

namespace Classes_and_Object
{
     class Animal
    {
       
        private string name;  
        protected string sound;
        //"is a" relation ship hoga means inheitance hai
        //"has a " relation ship means delegate


        protected AnimalIdInfo animalIDinfo=new AnimalIdInfo();
        public void SetAnimalIdInfo(int idNum,string Owner)
        {
            animalIDinfo.IDNum= idNum;
            animalIDinfo.Owner= Owner;
        }

        public void GetAnimalIdInfo()
        {
            Console.WriteLine($"{name} has Id of  {animalIDinfo.IDNum} and is owned by {animalIDinfo.Owner}");
        }





        public virtual void MakeSound()
        {
            Console.WriteLine($"{name} says {Sound}");
        }

        public Animal() : this("No Name", "No Sound") { }

        public Animal(string name) : this(name, "NoSound") { }

        public Animal(string name,string sound)
        {
            Name=name;
            Sound= sound;

           
        }

        //public void makeSound()
        //{

        //    Console.WriteLine("{0} say {1}",name ,sound);

        //}

       




        //Creating Getter and setters for names
        public string Name
        {
            get { return name; }
            set
            {
                if(value.Any(char.IsDigit))
                {
                    name = "No Name";
                    Console.WriteLine("Can't use numbers in name");
                }
                name = value;  
            }
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
        
        //inner class /class inside other class, Normally it is called as helper class for the outside class.
        public class AnimalHealth
        {
            public bool HealthyWeight(double height,double weight)
            {

                double calc=height/weight;
                if ((calc >= .18) && (calc <= .27))
                {
                    return true;
                }
                else return false;


            }
        }

       
        

    }
}
