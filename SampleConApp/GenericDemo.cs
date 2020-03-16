using System;
using System.Collections.Generic;
using System.Linq;
//Collections Framework of .NET is designed for handling complex data structures in UR application which cannot be done using simpliest version of data: Arrays.. Arrays are faster but has limitations: Like creating dynamic array, modifying array like adding, removing or updating, then arrays are not for U....
//Collections were available since the inception of .NET 1.0. But in the v2.0, there was much improvised type safe collections called Generics. 
namespace SampleConApp
{
    class GenericDemo
    {
        static void Main(string[] args)
        {
            //listExample();
            //hashSetExample();
            //customhashSetExample();
            //dictionaryExample();
            //queueExample();
            //StackExample
        }
        private static void StackExample()
        {
            throw new Exception("Try it URself!!!");
        }

        private static void queueExample()
        {
            //First In-FirstOut scenario...
            Queue<string> recentItems = new Queue<string>();
            while (true)
            {
                var item = Utility.GetString("Enter the Item U wish to see today?");
                if (recentItems.Count == 5)
                    recentItems.Dequeue();//Removes the first element from the queue..
                recentItems.Enqueue(item);//Adds to the bottom of the Queue.
                Console.WriteLine("\n\n\n");
                Console.WriteLine("UR recent List of items:");
                var content = recentItems.Reverse();//Reverse is needed as items  are added to the bottom of the queue...
                foreach (var e in content) Console.WriteLine(e);
            }//U cannot remove/add any item in between the collection. UR adding will always be to the bottom and UR removal will always be at the begining of  the queue. 
        }

        //Develop an App that allows users to register to UR Application with unique username and password. U should develop an interactive Console app that allows the users to signin or signup and maintain the app...
        private static void dictionaryExample()
        {
            //Dictionary is a DS to store the data as key-value pairs. key is unique to the dictionary and the value associated with the key may or may not be unique. real time example will be username-password: usename is unique for  the collection but passwords may or may not be unique. 
            Dictionary<string, string> users = new Dictionary<string, string>();
            users.Add("phaniraj", "apple123");//adds the key-pair to the collection...
           // users.Add("phaniraj", "apple123");//add throws an Exception if the key already exists....
            users["suresh"] = "mango123";//this is another syntax of adding a record to the collection: In this case, if the key already exists it simply replaces the value of the existing key, else adds a new key-value pair. 
            users["suresh"] = "orange123";
            if (users.ContainsKey("phaniraj"))//ContainsKey is used to determine whether a key already exists or not...
                Console.WriteLine("User is already registered");
            else
                users["phaniraj"] = "temp123";
            foreach(var pair in users)
            {
                Console.WriteLine($"{pair.Key}-{pair.Value}");
            }

        }

        private static void customhashSetExample()
        {
            //As the uniqueness of the object is determined by the hashcode hense the name hashset. however if 2 objects share the same hashcode then the object equivalence is also checked thro the Equals method which determines whether the objects are same or not. 
            HashSet<Trainee> _trainees = new HashSet<Trainee>();
            _trainees.Add(new Trainee { TraineeID = 123, EmailAddress = "phanirajbn@gmail.com", Name = "Phaniraj" });
            _trainees.Add(new Trainee { TraineeID = 124, EmailAddress = "samuel@yahoo.in", Name = "Samuel" });
            _trainees.Add(new Trainee { TraineeID = 125, EmailAddress = "niki@gmail.com", Name = "Nikita" });
            _trainees.Add(new Trainee { TraineeID = 126, EmailAddress = "phanirajbn@gmail.com", Name = "Phaniraj" });//This will never get added as the emal ids are same for the 1 and 4th object...
            //This Hashset is not considering the duplicates as the reference types are considered duplicate only if it shares the same reference. new operator creates an new memory and an object, so they are considered unique. 
            
//            Console.WriteLine($"The Total Trainees in the course :{_trainees.Count}");
            foreach(var tr in _trainees)
                Console.WriteLine(tr.GetHashCode());

        }

        //Try using HashSet to store employees in UR app so that there are no duplicate Employees.
        //Dictionary, Queue, Stack and Custom Collections for Monday!!!!
        private static void hashSetExample()
        {
            string choice = string.Empty;
            //hashset is similar to List exception that it stores only unique values....
            HashSet<string> basket = new HashSet<string>();
            do
            {
                string fruit = Utility.GetString("Enter the fruit to the basket");
                if(basket.Add(fruit))
                    Console.WriteLine("Added fruit!!!");
                else
                    Console.WriteLine("Basket already contains the fruit!!!");
                 choice = Utility.GetString("Press Y to add new Fruit or any other key to check out!!!!").ToLower();
            } while (choice == "y");
            foreach (var fruit in basket) Console.WriteLine( fruit);
        }

        private static void listExample()
        {
            List<string> fruits = new List<string> { "Mango", "Oranges", "Apples", "Bananas" };//List is similar to array exception its dynamic. U have methods to add, remove, find and do many operations. 
            fruits.Add("PineApple");//Add method adds the element to the bottom of the list....
            fruits.Remove("Oranges");
            Console.WriteLine("the total: " + fruits.Count);
            foreach (var ex in fruits) Console.WriteLine(ex);
        }
    }
}
