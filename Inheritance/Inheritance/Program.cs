// See https://aka.ms/new-console-template for more information

using Classes_and_Object;
using Inheritance;

Animal Whiskers = new Animal()
{
    Name = "Whiskers",
    Sound = "Meao"
};

Dog grover = new Dog()
{
    Name = "grover",
    Sound = "Woof",
    Sound2 = "Grrr"
};

grover.Sound = "Wooooof";
Whiskers.MakeSound();
grover.MakeSound();

Whiskers.SetAnimalIdInfo(12345, "Sally smith");
grover.SetAnimalIdInfo(1425, "John");
Whiskers.GetAnimalIdInfo();
grover.GetAnimalIdInfo();
Animal.AnimalHealth getHelth = new Animal.AnimalHealth();
Console.WriteLine("Is my Animal Healthy : {0}", getHelth.HealthyWeight(11, 46));

Animal Monkey = new Animal()
{
    Name = "Happy",
    Sound = "Eeee"
};

Animal spot = new Dog()//spot is animal inside dog class
{
    Name = "spot",
    Sound = "hetre" ,
    Sound2="htfy"

};
spot.MakeSound();





