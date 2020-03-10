using System;
using System.Collections.Generic;
using System.IO;
//class and objects. SOLID Principle of OOP?
/*
 * Single Responsibility Principle: A Class should do only one job. Dont mix everything into one class. Clean seperation of concerns. Single responsibility is  applicable at project, class, method level also.  The idea is to make the code look modular in nature. 
 */
namespace SampleConApp
{
    //Entities
    class Employee//A class that represents a single employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public double EmpSalary { get; set; }
    }

    //Dal Layer
    class EmpRepository
    {
        private List<Employee> _employees = new List<Employee>();
        public void AddEmployee(Employee emp)
        {
            _employees.Add(emp);
        }

        public void DeleteEmployee(int id)
        {
            foreach(var emp in _employees)
            {
                if(emp.EmpID == id)
                {
                    _employees.Remove(emp);
                    return;
                }
            }
            throw new Exception($"Employee with Id {id} not found to delete");
        }

        public void UpdateEmployee(Employee emp)
        {
            throw new Exception("Do it urself!!!!");
        }

        public List<Employee> GetEmployee(string name)
        {
            List<Employee> tempList = new List<Employee>();
            foreach(var emp in _employees)
            {
                if (emp.EmpName.Contains(name))
                    tempList.Add(emp);
            }
            return tempList;
        }

        public Employee GetEmployee(int id)
        {
            foreach (var emp in _employees)
            {
                if (emp.EmpID == id)
                    return emp;
            }
            throw new Exception("Employee not found!!!!!");
        }
    }

    //UI layer
    class OOPFeatures
    {
        static EmpRepository repository = new EmpRepository();
        static string getMenu()
        {
            string file = @"C:\Users\phani\source\repos\Training\AdvancedCSharp\SampleConApp\Menu.txt";
            return File.ReadAllText(file);
        }
        static void Main(string[] args)
        {
            string menu = getMenu();
            var processing = true;
            do
            {
                string choice = Utility.GetString(menu);
                processing = processMenu(choice);      
            } while (processing);
        }

        private static bool processMenu(string choice)
        {
            switch (choice)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                    return true;
                default:
                    return false;
            }
        }
    }
}
