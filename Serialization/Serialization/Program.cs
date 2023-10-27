// See https://aka.ms/new-console-template for more information
using Serialization;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace SeralizationByme
{
   class Program
    {
        public static void Main(string[] args)
        {
            //Serialization
            //we can store state of the object in a file stram and we can pass it to remote network

            Animal bowser= new Animal("Bowser",45,25,1);
            Stream stream = File.Open("AnimalData.dat",FileMode.Create);//Seralize the object data to a file
            BinaryFormatter bf = new BinaryFormatter();//create a BinaryFormater

            bf.Serialize(stream, bowser);//send the object data to a file
            stream.Close();

            //delete data
            bowser = null;
            //Read object data from a file
            stream = File.Open("AnimalData.dat", FileMode.Open);
            bf = new BinaryFormatter();

            bowser=(Animal)bf.Deserialize(stream);
            stream.Close();

            Console.WriteLine(bowser.ToString());




            bowser.Weight = 45;

            //XMLSerializer
            XmlSerializer serializer = new XmlSerializer(typeof(Animal));
            using (TextWriter tw = new StreamWriter(@"C:\Users\tecnomic\Desktop\Office-Data\sampleFolder\bowser.xml"))
            {
                serializer.Serialize(tw, bowser);
            }

            //delete bowser data
            bowser = null;
            //deseralize using XML
            XmlSerializer deseralizer = new XmlSerializer(typeof(Animal));
            TextReader reader = new StreamReader(@"C:\Users\tecnomic\Desktop\Office-Data\sampleFolder\bowser.xml");
            object obj=deseralizer.Deserialize(reader);
            bowser = (Animal)obj;
            reader.Close();
            Console.WriteLine(bowser.ToString());



            //lets save collection of Animal
            List<Animal> theAnimals = new List<Animal>
            { new Animal("Mario",60,30,2),
              new Animal("Jis",60,56,3),
              new Animal("Peach",20,10,4),
              new Animal("Vijj",78,34,6)

            };

            using (Stream fs = new FileStream(@"C:\Users\tecnomic\Desktop\Office-Data\sampleFolder\animals.xml", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer seralizer2=new XmlSerializer(typeof(List<Animal>));
                seralizer2.Serialize(fs, theAnimals);
            }
            //delete
            theAnimals = null;
            //Read
            XmlSerializer seralizer3=new XmlSerializer(typeof(List<Animal>));
            using(FileStream fs2= File.OpenRead(@"C:\Users\tecnomic\Desktop\Office-Data\sampleFolder\animals.xml"))
            {
                theAnimals=(List<Animal>)seralizer3.Deserialize(fs2);
            }

            foreach(Animal a in theAnimals)
            {
                Console.WriteLine(a.ToString());
            }

        }
    }
}
