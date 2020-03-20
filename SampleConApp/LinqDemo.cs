using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;//For XLINQ features(LINQ for XML)...
/*
 * LINQ is a framework to allow queries to be performed on Collections. 
 * It will lead to the ORM features that is provided in Entity Framework and LINQ to SQL Classes. 
 * ORM is a design pattern to deal with DB programming in the form of collection classes and objects where there will be no need to write any form of SQL Queries. All the CRUD operations will happen thro the collection objects that are generated from the DB schema. 
 * Examples of ORM are Hibernate(Java), NHibernate(.NET), Mongoose(MongoDB) and EF along with LINQ To SQL(MS products).
 * LINQ need not be with DB only, U can have LINQ on Collections, XML, DataTables and ORMs. 
 */
namespace SampleConApp
{
    //Contact class represent each contact in a phone book...
    class Contact
    {
        public long ContactNo { get; set; }//Phone no
        public string Name { get; set; }//Name of the contact
        public string Address { get; set; }//City
        public override bool Equals(object obj)
        {
            if (obj is Contact)
            {
                var copy = obj as Contact;
                return copy.ContactNo == ContactNo;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return ContactNo.GetHashCode();
        }
        public override string ToString()
        {
            return Name;
        }
    }

    class PhoneBook
    {
        public static HashSet<Contact> AllContacts { get; private set; }

        static PhoneBook()
        {
            initialize();
        }

        public static int Count => AllContacts.Count;

        private static void initialize()
        {
            AllContacts = new HashSet<Contact>();
            AllContacts.Add(new Contact { ContactNo = 9945205684, Address = "Bangalore", Name = "Phaniraj" });
            AllContacts.Add(new Contact { ContactNo = 2342343243, Address = "Bangalore", Name = "Ananth" });
            AllContacts.Add(new Contact { ContactNo = 3453454356, Address = "Mysore", Name = "Aravind" });
            AllContacts.Add(new Contact { ContactNo = 2345342556, Address = "Hassan", Name = "Krishan" });
            AllContacts.Add(new Contact { ContactNo = 3454367756, Address = "Mangalore", Name = "Gopal" });
            AllContacts.Add(new Contact { ContactNo = 7645656673, Address = "Hassan", Name = "Vinod" });
            AllContacts.Add(new Contact { ContactNo = 6345676568, Address = "Hassan", Name = "Chandra" });
            AllContacts.Add(new Contact { ContactNo = 4676756865, Address = "Mysore", Name = "Shekar" });
            AllContacts.Add(new Contact { ContactNo = 5646456456, Address = "Mangalore", Name = "Ravi" });
            AllContacts.Add(new Contact { ContactNo = 1234123434, Address = "Mysore", Name = "Nagaraj" });
            AllContacts.Add(new Contact { ContactNo = 9865875683, Address = "Hassan", Name = "Lohith" });
            AllContacts.Add(new Contact { ContactNo = 4563467835, Address = "Mysore", Name = "Puneeth" });
            AllContacts.Add(new Contact { ContactNo = 3443455677, Address = "Hassan", Name = "Shivkumar" });
            AllContacts.Add(new Contact { ContactNo = 9879868758, Address = "Mysore", Name = "Raghunandhan" });
            AllContacts.Add(new Contact { ContactNo = 6675432298, Address = "Hassan", Name = "Pradhyumna" });
            AllContacts.Add(new Contact { ContactNo = 8765632199, Address = "Mysore", Name = "Vasistachar" });
            AllContacts.Add(new Contact { ContactNo = 9876365432, Address = "Mangalore", Name = "Sanjay Sahu" });
            AllContacts.Add(new Contact { ContactNo = 8764443325, Address = "Mysore", Name = "Gorpade" });
            AllContacts.Add(new Contact { ContactNo = 9988776655, Address = "Bangalore", Name = "Vasudev Rao" });
            AllContacts.Add(new Contact { ContactNo = 4433224433, Address = "Mangalore", Name = "Mohan" });
            AllContacts.Add(new Contact { ContactNo = 3334445644, Address = "Mangalore", Name = "Hanumatha Rao" });
            AllContacts.Add(new Contact { ContactNo = 6665554345, Address = "Mysore", Name = "Anandathirtha" });
            AllContacts.Add(new Contact { ContactNo = 7776655567, Address = "Mangalore", Name = "Bheemasena Rao" });
            AllContacts.Add(new Contact { ContactNo = 3452342222, Address = "Mysore", Name = "Srinivas" });
            AllContacts.Add(new Contact { ContactNo = 5675788888, Address = "Bangalore", Name = "Manjunath" });
            AllContacts.Add(new Contact { ContactNo = 4567435622, Address = "Hassan", Name = "Savithri" });
            AllContacts.Add(new Contact { ContactNo = 4321567889, Address = "Bangalore", Name = "Ananth Krishna" });
            AllContacts.Add(new Contact { ContactNo = 9945684179, Address = "Bangalore", Name = "Bijoy" });
            AllContacts.Add(new Contact { ContactNo = 9944453345, Address = "Mysore", Name = "Santosh" });
            AllContacts.Add(new Contact { ContactNo = 9877654332, Address = "Hassan", Name = "Ramesh" });
            AllContacts.Add(new Contact { ContactNo = 6788956332, Address = "Mangalore", Name = "Mahesh Gowda" });
            AllContacts.Add(new Contact { ContactNo = 9848022221, Address = "Hassan", Name = "Sanjana" });
            AllContacts.Add(new Contact { ContactNo = 9845978654, Address = "Hassan", Name = "Chaitra" });
            AllContacts.Add(new Contact { ContactNo = 9844049492, Address = "Mysore", Name = "Savitri" });
            AllContacts.Add(new Contact { ContactNo = 9944322116, Address = "Mangalore", Name = "Binu George" });
            AllContacts.Add(new Contact { ContactNo = 9845256564, Address = "Mysore", Name = "Ram gopal" });
            AllContacts.Add(new Contact { ContactNo = 9945698765, Address = "Hassan", Name = "Nagarjuna" });
            AllContacts.Add(new Contact { ContactNo = 9944565432, Address = "Mysore", Name = "Krishnaveni" });
            AllContacts.Add(new Contact { ContactNo = 8766544332, Address = "Hassan", Name = "Usha Rao" });
            AllContacts.Add(new Contact { ContactNo = 5544398765, Address = "Mysore", Name = "Asha Rao" });
            AllContacts.Add(new Contact { ContactNo = 9876556789, Address = "Hassan", Name = "Sriraj" });
            AllContacts.Add(new Contact { ContactNo = 3456776543, Address = "Mysore", Name = "Amit Shah" });
            AllContacts.Add(new Contact { ContactNo = 2345679876, Address = "Mangalore", Name = "Suresh Kumar" });
            AllContacts.Add(new Contact { ContactNo = 4321223211, Address = "Mysore", Name = "Jagadish" });
            AllContacts.Add(new Contact { ContactNo = 8760098700, Address = "Bangalore", Name = "Vasuki" });
            AllContacts.Add(new Contact { ContactNo = 9800199001, Address = "Mangalore", Name = "Vital Rao" });
            AllContacts.Add(new Contact { ContactNo = 7789644300, Address = "Mangalore", Name = "Vyasa raja" });
            AllContacts.Add(new Contact { ContactNo = 4432908711, Address = "Mysore", Name = "Subhud" });
            AllContacts.Add(new Contact { ContactNo = 8976443211, Address = "Mangalore", Name = "Sampath" });
            AllContacts.Add(new Contact { ContactNo = 9877655443, Address = "Mysore", Name = "Ajay Rao" });
            AllContacts.Add(new Contact { ContactNo = 9845072321, Address = "Bangalore", Name = "Rajesh" });
            AllContacts.Add(new Contact { ContactNo = 9845143789, Address = "Hassan", Name = "Anupama" });
        }
    }

    class LinqDemo
    {
        static void Main(string[] args)
        {
            //simpleExample();
            //listAllNames();
            //listNamesAndPhone();
            //orderByClause();
            //groupByClause();
            //XML(File) or LINQ to SQL(For Database)
            storeAsXml();
            //XPath will now be replaced by XLINQ which is optimized as well as faster way of reading xml documents...
        }

        private static void storeAsXml()
        {
            var elements = new XElement("PhoneBook", from c in PhoneBook.AllContacts
                                                       select new XElement("Contact",
                                                       new XElement("PhoneNo", c.ContactNo),
                                                       new XElement("Name", c.Name),
                                                       new XElement("City", c.Address)
                                                       ));
            Console.WriteLine(elements);
            elements.Save("PhoneBook.xml");
        }

        //assignment: try it: Group based on 1st Alphabet of the contact name... 
        private static void groupByClause()
        {
            var cityGroups = from c in PhoneBook.AllContacts
                             orderby c.Name
                             group c by c.Address into gr
                             orderby gr.Key
                             select gr;
            //U have created a collection of groups where each group has a collection of contacts...
            foreach(var gr in cityGroups)
            {
                Console.WriteLine("Contacts from " + gr.Key);
                foreach(var item in gr)
                {
                    Console.WriteLine($"{item.Name}:{item.ContactNo}");
                }
                Console.WriteLine("\n\n");
            }
        }

        private static void orderByClause()
        {
            var data = PhoneBook.AllContacts;
            var contacts = from c in data
                           orderby new { c.Name, c.ContactNo } descending
                           select new { ContactName = c.Name, PhoneNo = c.ContactNo };
            foreach (var c in contacts) Console.WriteLine(c);
        }

        private static void listNamesAndPhone()
        {
            var data = PhoneBook.AllContacts;
            var list = from c in data
                       select new { c.Name, c.ContactNo };//practical requirement of Anonymous Types...
            foreach (var item in list) Console.WriteLine($"{item.Name} can be called on {item.ContactNo}");
        }

        private static void listAllNames()
        {
            var data = PhoneBook.AllContacts;
            var names = from contact in data
                        select contact.Name;//select name from contacttable.....
            foreach (var name in names) Console.WriteLine(name);

        }

        private static void simpleExample()
        {
            var array = new int[] { 12, 23, 23, 74, 85, 95, 44, 42, 34, 45, 56, 66, 55, 44, 33, 22 };
            //Extract a set of data which are less than 35....
            var subset = from item in array
                                 where item < 35
                                 select item;
            //LINQ query starts with a from clause and ends with a select clause supported by various other conditions like where, order by group by join and few more. 
            //LINQ expression always returns a IEnumerable<T> even if its a single record. In this case, the return data will be a collection whose size is 1. 

            foreach (var subitem in subset) Console.WriteLine(subitem);
        }
    }
}
