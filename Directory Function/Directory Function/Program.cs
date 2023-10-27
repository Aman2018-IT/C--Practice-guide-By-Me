// See https://aka.ms/new-console-template for more information
using System;
using System.Text;

namespace Directory_Function
{
    class Progrm
    {
        public static void Main(string[] args)
        {
            /*
            //How to deal with Directory and Files

            DirectoryInfo CurrentDir = new DirectoryInfo(".");
            DirectoryInfo AmanDir = new DirectoryInfo(@"C:\Users\tecnomic\Desktop\Office-Data");
            Console.WriteLine(AmanDir.FullName);
            Console.WriteLine(AmanDir.Name);
            Console.WriteLine(AmanDir.Parent);//Parent Directory
            Console.WriteLine(AmanDir.Attributes);//Type of my directory
            Console.WriteLine(AmanDir.CreationTime);//When This Directory Created

            DirectoryInfo dataDir=new DirectoryInfo(@"C:\Users\tecnomic\Desktop\Office-Data\Data");//we can create Direactory 
            dataDir.Create();
            Directory.Delete(@"C:\Users\tecnomic\Desktop\Office-Data\Data");//Delete that Directory


            //File I/O
            string[] customers =
            {
                "Bob smith",
                "Sally Smith",
                "Robert Smith"
            };
            string textFilePath = @"C:\Users\tecnomic\Desktop\Office-Data\sampleFolder\testFile1.txt";//main jahta hu ku yaha mera String customer save ho.
            File.WriteAllLines(textFilePath, customers);

            foreach (string customer in File.ReadAllLines(textFilePath))
                {
                   Console.WriteLine($"{customer}");
                }

            DirectoryInfo myDataDirectory = new DirectoryInfo(@"C:\Users\tecnomic\Desktop\Office-Data\sampleFolder");

            FileInfo[] textFile=myDataDirectory.GetFiles("*.txt",SearchOption.AllDirectories);
            Console.WriteLine("Matches : {0} ",textFile.Length);
            
            foreach(FileInfo file in textFile)
            {
                Console.WriteLine($"{file.Name}");
                Console.WriteLine(file.Length);
            }
            */



            /*
            //File Streams
            // you can access through many ways and eak tarika file data ko access karne ka hai using filestreams

            string textfilePath2 = @"C:\Users\tecnomic\Desktop\Office-Data\sampleFolder\textfile2.txt";
            FileStream fs = File.Open(textfilePath2, FileMode.Create);
            string randString = "This is a Random String";
            byte[] rsByteArray = Encoding.Default.GetBytes(randString);//Convert to Byte Array

            fs.Write(rsByteArray, 0, rsByteArray.Length);                                  //Write file

            fs.Position = 0;
            byte[] fileByteArray=new byte[rsByteArray.Length];

            for(int i = 0;i < fileByteArray.Length; i++)
            {
                fileByteArray[i] = (byte)fs.ReadByte();
            }

            Console.WriteLine(Encoding.Default.GetString(fileByteArray));
            fs.Close();//close file after finish
            */



            /*
              //Stream Writer/Stream Reader
              // if you want to work with string and want to write in your file its better to use stream writer and stream Reader

              string textFilePath3 = @"C:\Users\tecnomic\Desktop\Office-Data\sampleFolder\textfile3.txt";
              StreamWriter sw=new StreamWriter(textFilePath3);
              sw.Write("This is a Random ");
              sw.WriteLine("Since I was in Class 2");//With New Line
              sw.WriteLine("This is another sentence.");
              sw.Close();//close Stram Writer

              // To open file and read Data from it
              StreamReader sr = new StreamReader(textFilePath3);
              Console.WriteLine("peek : {0} ",Convert.ToChar(sr.Peek()));
              Console.WriteLine("1st string : {0} ",sr.ReadLine());

              Console.WriteLine("Everything Else : {0} ",sr.ReadToEnd());
              sr.Close();

              */



            //Binary Writer / Binary Reader
               //These are used to Read and Write Datatype
            string textFilePath4 = @"C:\Users\tecnomic\Desktop\Office-Data\sampleFolder\textfile4.txt";
            FileInfo datafile= new FileInfo(textFilePath4);
            BinaryWriter bw=new BinaryWriter(datafile.OpenWrite());
            string randText = "Random Text";
            int myAge = 23;
            double Height = 6.23;
            bw.Write(randText);
            bw.Write(Height);
            bw.Write(myAge);
            bw.Close();

            //Binary Reader

            BinaryReader br=new BinaryReader(datafile.OpenRead());
            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadDouble());
            br.Close();













        }
    }
}
