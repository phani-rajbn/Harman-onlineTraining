using System;
namespace SampleConApp
{
    /*
     * Anonymous types will allow to create objects using new operator without an explicit Type declaration.
     * These objects dont have any name while creating, they are called  as Anonymous Types. 
     * They are data carriers. They have only properties to hold the data that they wish to carry.
     * Anonymous types are popular for LINQ Expression results.
     */
    class AnonymousExample
    {
        static void Main(string[] args)
        {
            var emp = new { EmpID = 123, Empname = "Phaniraj", EmpAddress = "Bangalore" };
            //We need to create these anonymous types when we wish to extract parts of the information from an existing data structure. 
            Console.WriteLine(emp);
            Console.WriteLine($"The data type is {emp.GetType().Name}" );
            Console.WriteLine($"The Name:{emp.Empname} from {emp.EmpAddress} with ID:{emp.EmpID}");
        }
    }
}
