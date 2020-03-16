using System;
using System.Collections.Generic;
namespace Entities
{
    class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public double EmpSalary { get; set; }
    }
}
//IEnumerable -> ICollection -> IList(ILIst will make the objects bind to UI Elements like Listbox, DropDownList, DataGridView and many more data bound controls..

namespace DalLayer
{
    using System.Collections;
    using Entities;
    interface IEmpCollection : IEnumerable<Employee>
    {
        void AddEmployee(int id, string name, double salary);
        void UpdateEmployee(int id, string name, double salary);
        void DeleteEmployee(int id);
        int Total { get; }

        Employee this[int index] { get; }

    }
    class EmployeeCollection : IEmpCollection
    {
        private List<Employee> _employees = new List<Employee>();

        public Employee this[int index]
        {
            get
            {
                if (index < Total)
                    return _employees[index];
                else
                    throw new IndexOutOfRangeException($"Employee not available at index {index}");
            }
        }

        public int Total => _employees.Count;

        public void AddEmployee(int id, string name, double salary)
        {
            //check for UR business rules...
            var emp = new Employee { EmpID = id, EmpName = name, EmpSalary = salary };
            _employees.Add(emp);
        }

        public void DeleteEmployee(int id)
        {
            var foundEmp = _employees.Find((emp) => emp.EmpID == id);
            if (foundEmp == null)
                throw new Exception("Employee not found to delete");
            _employees.Remove(foundEmp);
        }

        public IEnumerator<Employee> GetEnumerator()
        {
            //GetEnumerator method returns an IEnumerator object throw which I could perform iterations using foreach statement. IEnumerator has a property called Current to access the current object and MoveNext method that allows to move to the next element in the collection.
            return _employees.GetEnumerator();
        }

        public void UpdateEmployee(int id, string name, double salary)
        {
            var foundEmp = _employees.Find((emp) => emp.EmpID == id);
            if (foundEmp == null)
                throw new Exception("Employee not found to update");
            //Id is the way to identify the employee and assumed that id is not modifiable...
            foundEmp.EmpSalary = salary;
            foundEmp.EmpName = name;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

namespace UILayer
{
    using DalLayer;
    using Entities;
    class CustomCollectionDemo
    {
        static IEmpCollection collection = new EmployeeCollection();
        static void Main()
        {
            collection.AddEmployee(123, "Phaniraj", 45000);
            collection.AddEmployee(124, "Robert", 35000);
            collection.AddEmployee(125, "Zaheer", 25000);
            collection.AddEmployee(126, "Robin", 40000);

            //A Collection class is one that allows its object to be used in a foreach statement. foreach internally uses IEnumerator object thro' which it iterates. The function called GetEnumerator of the IEnumerable interface will allow to return this IEnumerator object. An ability to iterate is given by the interface called IEnumerable and the iterating feature is obtained by IEnumerator interface object.

            // foreach (Employee emp in collection) Console.WriteLine(emp.EmpName);
            //var iterator = collection.GetEnumerator();
            //while(iterator.MoveNext())
            //    Console.WriteLine(iterator.Current.EmpName);
            foreach (var emp in collection) Console.WriteLine(emp.EmpName);

            for (int i = 0; i <collection.Total; i++)
            {
                Console.WriteLine(collection[i].EmpName);
            }
         }
    }
}
