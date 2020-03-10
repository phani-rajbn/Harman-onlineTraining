using System;
//using System.Collections.Generic;
//using System.Linq;

//Sealed classes in .NET does not allow the class to be inherited.

//This class will contain all the methods that U want to extend for a given set of classes. The methods of this class are static always.
namespace MyExtensionDemo
{
    static class MyExtensions
    {
        public static int GetNoOfWords(this string arg)
        {
            //U R adding this method to the class called String represented by variable called arg. 
            var words = arg.Split(' ', ';', ',');//splits the string based on the delimiters provided and returns an array..
            return words.Length;
        }

        public static string GetTypeInfo(this object arg)
        {
            return arg.GetType().FullName;
        }
    }
}

namespace SampleConApp
{
    using MyExtensionDemo;//For extension methods....
    using System.Collections;

    class ExtensionDemo
    {
        static void Main(string[] args)
        {
            //extensionDemo();
            string[] data = new string[] { "Apple", "Mango", "Orange" };
            var iterable = (IEnumerable)data;//Upcasting....
            var iterator = iterable.GetEnumerator();
            while(iterator.MoveNext())
                Console.WriteLine(iterator.Current);
        }

        private static void extensionDemo()
        {
            string notes = "This class will contain all the methods that U want to extend for a given set of classes. The methods of this class are static always";
            //get the no of words in this string...
            var no = notes.GetNoOfWords();//If the extension methods are created in seperate namespace, U must include that namespace to use the method in ur code...
            Console.WriteLine("The no of words: " + no);
            Console.WriteLine(notes.GetTypeInfo());
        }
    }
}
/*
 * Points to remember:
 * Extension methods are static methods used to extend a functionality to an instance of the class, not to the class itself. 
 * Extension methods are scoped to the namespace it is declared. The class has no effect of the extension method if the namespace where the method is created is not used.
 * Extension methods are not the replacement of inheritance. The OOP features will not be applicable to the extension methods.(Runtime polymorphism, Inheritance, Abstraction).
 * For the .NET, Extension methods were created to add new features of LINQ operations on Collection classes. A Class which implements IEnumerable interface. 
 */