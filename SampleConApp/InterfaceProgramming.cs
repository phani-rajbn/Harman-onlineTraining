using System;
using System.Data;
using System.IO;
//A class which has only abstract methods is called as interface. interface is a better way of creating classes as there will be only declarations but no implementations.
namespace SampleConApp
{
    //interface is similar to abstract class in terms of not having implemented methods but will contain only such methods. An interface can have only abstract methods. It cannot have implementation. Unless U R using C# 8.0 feature called Default interfaces. 
    interface IRepository//It is more like a plan and would be implemented by any class later...
    {
        void AddNewEmployee(int id, string name, double salary);
        void UpdateEmployee(int id, string name, double salary);
        void DeleteEmployee(int id);
        DataTable GetAllEmployees() ;
    }

    class FileRepository : IRepository
    {
        public void AddNewEmployee(int id, string name, double salary)
        {
            
        }

        public void DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable GetAllEmployees()
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployee(int id, string name, double salary)
        {
            throw new NotImplementedException();
        }
    }
    class InterfaceDemo
    {
        static void Main(string[] args)
        {
            IRepository demo = new FileRepository();
            demo.AddNewEmployee(123, "Phaniraj", 45000);
            demo.UpdateEmployee(123, "Phaniraj B.N.", 55000);
            demo.DeleteEmployee(123);
            var table = demo.GetAllEmployees();
            foreach(DataRow row in table.Rows)
                Console.WriteLine(row[1]);
        }
    }
}
