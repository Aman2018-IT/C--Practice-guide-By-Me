// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace Linq2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*ArrayList animalList = new ArrayList()
            {
                new Animal{
                    Name="German Sherphard",
                    Height=4,
                    Weight=130,
                    AnimalID=1

                },
                new Animal{
                    Name="Bull Dog",
                    Height=3,
                    Weight=10,
                    AnimalID=2

                },
                new Animal{
                    Name="Labrador",
                    Height=3.5,
                    Weight=90,
                    AnimalID=3

                },
                 new Animal{
                    Name="Tiger",
                    Height=6,
                    Weight=320,
                    AnimalID=4

                },
                  new Animal{
                    Name="Lion",
                    Height=6,
                    Weight=240,
                    AnimalID=4

                }


            };

            //ArrayList ko ham Enumerable
           var animalListEnum=animalList.OfType<Animal>();

            var smallAnimals=from animal in animalListEnum
                             where animal.Weight<=90
                             orderby animal.Name
                             select animal;
            foreach( var animal in smallAnimals )
            {
                Console.WriteLine($"{animal.Name} and their Weight is {animal.Weight}kg");
            }



            var HeightWeight = from dog in animalListEnum
                               where (dog.Weight <= 140) && (dog.Height <= 3.3 && dog.Height>=3)
                               orderby dog.Name
                               select dog;

            foreach (var animal in HeightWeight)
            {
                Console.WriteLine($"{animal.Name} and their height is {animal.Height} and their Weight is {animal.Weight}kg");
            }*/





            Animal[] animal = new[]
            {
                new Animal{
                    Name="German Sherphard",
                    Height=4,
                    Weight=130,
                    AnimalID=1

                },
                new Animal{
                    Name="Bull Dog",
                    Height=3,
                    Weight=10,
                    AnimalID=2

                },
                new Animal{
                    Name="Labrador",
                    Height=3.5,
                    Weight=90,
                    AnimalID=3

                },
                 new Animal{
                    Name="Tiger",
                    Height=6,
                    Weight=320,
                    AnimalID=4

                },
                  new Animal{
                    Name="Lion",
                    Height=6,
                    Weight=240,
                    AnimalID=4

                }

            };

            Owner[] owners = new[]
            {
                new Owner{Name="Jyoti",OwnerID=1},
                new Owner{Name="Gyan",OwnerID=2},
                new Owner{Name="SubhGyan",OwnerID=3},
                new Owner{Name="Mangla",OwnerID=4}

            };

            var nameHeight = from a in animal
                             select new
                             {
                                 a.Name,
                                 a.Height,
                             };
            Array arrayNameHeight=nameHeight.ToArray();
            foreach (var i in arrayNameHeight)
            {
                Console.WriteLine(i.ToString());
            }


            //join
            var innerJoin = from a in animal
                            join owner in owners on a.AnimalID
                            equals owner.OwnerID
                            select new
                            {
                                PersonName = owner.Name,
                                AnimalName = a.Name
                            };

            foreach (var i in innerJoin)
            {
                Console.WriteLine($"{i.PersonName} has same id as {i.AnimalName}");
            }


            //Group join
            var groupJoin = from owner in owners
                            orderby owner.OwnerID
                            join ani in animal on owner.OwnerID
                            equals ani.AnimalID into ownerGroup
                            select new
                            {
                                Owner = owner.Name,
                                Animal = from owner2 in ownerGroup
                                         orderby owner2.Name
                                         select owner2
                            };
            int totalAnimals = 0;

            foreach(var ownerGroup in groupJoin)
            {
                Console.WriteLine(ownerGroup.Owner);
                foreach(var _animal in ownerGroup.Animal)
                {
                    totalAnimals++;
                    Console.WriteLine("*{0}",_animal.Name);
                }
                Console.WriteLine(totalAnimals);
            }

        }
    }
}
