using System;
using System.Xml.Linq;
using System.Linq;
namespace SampleConApp
{
    class XLinqExample
    {
        //How to delete and update. RemoveAfterSelf and RemoveBeforeSelf and Remove. 
        const string filename = "PhoneBook.xml";
        static void Main(string[] args)
        {
            //readXmlFile();
            //insertRecord();
            XDocument doc = XDocument.Load(filename);
            var last = doc.Descendants("Contact").Last();
            last.AddAfterSelf(new XElement("Contact",
                                        new XElement("PhoneNo", 1122334345),
                                        new XElement("Name", "Thompson"),
                                        new XElement("City", "NewYork")
                ));
            doc.Save(filename);
        }

        private static void insertRecord()
        {
            //load the xml document
            XDocument doc = XDocument.Load(filename);
            //find the element from where U wish to add(Before it or after it).
            var selected = (from element in doc.Descendants("Contact")
                           where element.Element("Name").Value == "Nagarjuna"
                           select element).FirstOrDefault();//LINQ always returns a collection
            if(selected == null)
            {
                throw new Exception("No name found in the phonebook");
            }
            var newElement = new XElement("Contact",
                                        new XElement("PhoneNo", 9765412322),
                                        new XElement("Name", "Donald Trump"),
                                        new XElement("City", "NewYork")
                );
            //create new xml element with similar schema.
            //add the new element 
            selected.AddAfterSelf(newElement);
            //save the file...
            doc.Save(filename);
        }

        private static void readXmlFile()
        {
            XDocument doc = XDocument.Load(filename);
            var names = from element in doc.Descendants("Contact")
                        select element.Element("Name");
            foreach (var name in names) Console.WriteLine(name.Value);
        }
    }
}