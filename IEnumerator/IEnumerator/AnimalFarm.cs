
using IEnumeratorByMe;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumeratorByme
{
    class AnimalFarm : IEnumerable
    {
        private List<Animal> animalList=new List<Animal>();

        public AnimalFarm(List<Animal> animalList)//constructor
        {
            this.animalList = animalList;
        }

        public AnimalFarm() { }//Empty constructor

        public Animal this[int index]//indexer    Animal is return type , parameter is of integer type called index
        {
            get { return (Animal)animalList[index]; }
            set { animalList.Insert(index, value); }

        }

        public int Count
        {
            get
            {
                return animalList.Count;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return animalList.GetEnumerator();
        }

       


    }
}
