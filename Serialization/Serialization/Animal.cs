using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable()]
    public class Animal : ISerializable
    {

        public string Name { get; set; }
        public double Weight { get; set; }

        public double Height {  get; set; }
        public int AnimalID { get; set; }
        public Animal(){}

        public Animal(string name="No Name",double weight=0,double height=0,int animalId=0)
        {
            Name = name;    
            Weight = weight;
            Height = height;
            AnimalID = AnimalID;
        }

        public override string ToString()
        {
            return string.Format("{0} weighs {1}kgs and height is {2}feet tall ",Name,Weight,Height);
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", Name);
            info.AddValue("Weight", Weight);
            info.AddValue("Height", Height);
            info.AddValue("AnimlID", AnimalID);
        }

        //create DeSerlization function , it will remove object data from the file
        public Animal(SerializationInfo Info , StreamingContext context)
        {
            Name = (string)Info.GetValue("Name", typeof(string));
            Weight = (double)Info.GetValue("Weight", typeof(double));
            Height = (double)Info.GetValue("Height", typeof(double));
            AnimalID = (int)Info.GetValue("AnimalID", typeof(int));

        }
    }
}
