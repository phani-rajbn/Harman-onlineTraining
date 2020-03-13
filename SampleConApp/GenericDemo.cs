using System;
using System.Collections.Generic;

//Collections Framework of .NET is designed for handling complex data structures in UR application which cannot be done using simpliest version of data: Arrays.. Arrays are faster but has limitations: Like creating dynamic array, modifying array like adding, removing or updating, then arrays are not for U....
//Collections were available since the inception of .NET 1.0. But in the v2.0, there was much improvised type safe collections called Generics. 
namespace SampleConApp
{
    class GenericDemo
    {
        static void Main(string[] args)
        {
            //listExample();
            hashSetExample();
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
