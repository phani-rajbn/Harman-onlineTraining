using System;
using System.IO;//For File IO operations
using System.Runtime.Serialization.Formatters.Binary;//For BinaryFormatter class
using System.Xml.Serialization;//For the XmlSerializer
/*
* Serialization is an ability of persisting(saving) the state of the object along with its type information into a storage device like memory, disc, or into a process. The object that is saved is called as serialized object. 
* Thro Deserialization, we could get the same object from its saved state into the app as it was saved. This includes the data as well as the metadata of the object. This will be helpfull for transfering objects from one process to another. 
* Database Apps, IPC Apps, Service based Apps use serialization for transfering objects from one end to another. 
* In .NET serialization is achieved using Binary, XML or SOAP. 
* Binary serialization is used for apps that are used only within the Windows platform.
* XML serialization is used for cross platform data transfer using XML. 
* SOAP is used by Web services for transfering the data.
* Any Serialization has 3 steps:
* What to serialize? Any object of a class that has an attribute called serializable can be serialized. 
* Where to serialize? Any File or process, in our example it will be FileStream.
* How to serialize? Any of the above mentioned formats: Binary, XML or Soap.
*/
namespace SampleConApp
{
    [Serializable]//1st step to make the objects of this class serializable in binary format...
    public class Example 
    {
        //[NonSerialized]//Applicable only on fields not on properties. Use this if U dont want to serialize any data member of the class.
        //public int no;
        public int ExampleID { get; set; }
        public string Topic { get; set; }
        public int Size { get; set; }
        public string Code { get; set; }

        public override string ToString()
        {
            string code = File.ReadAllText("../../"  + Code);
            return $"Topoc:{Topic}\nCode:\n{code}";
        }
    }
    class SerializationDemo
    {
        const string filename = "Filename.bin";
        static void Main(string[] args)
        {
            //saveingExample();
            //readingExample();
           // xmlserialization();
            xmldeserialization();
        }

        private static void xmldeserialization()
        {
            XmlSerializer format = new XmlSerializer(typeof(Example));
            FileStream fs = new FileStream("Example.xml", FileMode.Open, FileAccess.Read);
            var ex = format.Deserialize(fs) as Example;
            Console.WriteLine(ex);
        }

        private static void xmlserialization()
        {
            //With XML Serialization, U should mark the class as public and need not have Serializable attribute.
            var ex = new Example
            {
                Code = "Utility.cs",
                ExampleID = 2,
                Size = 5,
                Topic = "Helper Classes"
            };
            XmlSerializer format = new XmlSerializer(typeof(Example));
            FileStream fs = new FileStream("Example.xml", FileMode.OpenOrCreate, FileAccess.Write);
            format.Serialize(fs, ex);
            fs.Close();
        }

        private static void readingExample()
        {
            BinaryFormatter fm = new BinaryFormatter();
            var stream = new FileStream(filename, FileMode.Open, FileAccess.Read);
            var storedExample = fm.Deserialize(stream) as Example;
            stream.Close();
            Console.WriteLine(storedExample);
        }

        private static void saveingExample()
        {
            Example ex = new Example
            {
                Code = "SerializationExample.cs",
                ExampleID = 1,
                Size = 10,
                Topic = "Serialization in .NET"
            };
            FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, ex);//object graph means the state of the object along with its hirarchy in inheritance as well as the assembly information about the object.
            fs.Close();
        }
    }
}
