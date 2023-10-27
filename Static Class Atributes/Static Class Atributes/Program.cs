// See https://aka.ms/new-console-template for more information
using Static_Class_Atributes;

Console.WriteLine("Hello, World!");


Song holiday = new Song("Holiday", "Green Day", 180);
Song Bahubali = new Song("Bahubali", "Part2", 120);


Console.WriteLine(Bahubali.title);//This is normal atribute(Title,artist,duration) of Song class has different value for holiday object and has different value for Bahubali object
Console.WriteLine(holiday.title);//But static Attribute is same every object will have same value

Console.WriteLine(Song.SongCount);//static attribute belongs to the class thats why we can call them using class name . but normal atribute belons to that particular object so ham uske uske object ke naam se call karte hai.


Song Ashique = new Song("Ashique", "Aly", 240);
Console.WriteLine(Song.SongCount);
