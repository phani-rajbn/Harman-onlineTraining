using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * var keyword.
 * Lambda Expressions
 * Extension methods.
 * Intro to LINQ.
 */
namespace SampleConApp
{
    class Program
    {
        static void Main(string[] args)
        {
            object example = "123";
            Console.WriteLine($"The data type of example is {example.GetType().Name}");
            example = 123;
            Console.WriteLine($"The data type of example is {example.GetType().Name}");
            int temp = (int)example;//Converting an object to the type that the variable holds is called as UNBOXING....
            temp += (int)234.345;
            example =temp;
            Console.WriteLine($"The data type of example is {example.GetType().Name}");

            //implicit typed local variables. To create local variables with level of simplicity and convinience.
            var strVar = "Simple Example";
            Console.WriteLine(strVar.GetType().Name);
            strVar = "123";//The variable will hold the data type and its features implicitly based on the value U assign while U declare it. 
            Console.WriteLine(strVar);
            /*
             * Rules:
             * U cannot use var for fields, return type or parameters of a function...
             * It is specifically designed to holding local variables. 
             * The variable will hold the type to which it is assigned..
             * There is no scope of boxing or unboxing when var is used
             * object is similar to void* of C++ where object is reference type to hold any of data and needs to be casted explicitly while working with its type. 
             */
        }
    }
}
