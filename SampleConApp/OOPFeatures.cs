using System;
using System.Collections.Generic;
using System.IO;
//class and objects. SOLID Principle of OOP?
/*
 * Single Responsibility Principle: A Class should do only one job. Dont mix everything into one class. Clean seperation of concerns. Single responsibility is  applicable at project, class, method level also.  The idea is to make the code look modular in nature. 
 * Open Closed Principle:A Class is Closed for modification but open for Extension.  A Class is immutable in nature. Inheritance feature of OOP is because of this principle...  
 * Liskov's Substitution principle: A base type object could be substituted by any of the sub types without altering the correctness of the program. Runtime polymorphism is because of this principle...
 * Dependency Inversion princple: When U create an object, it is good to have an abstract object rather than a concrete object. UR code should depend on abstractions, not concretions. 
 */


namespace SampleConApp
{
    //Entities
    class Employee//A class that represents a single employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public double EmpSalary { get; set; }

        //overriding: Overriding is a feature of OOP where a method that is implemented in the base class will be redefined in the derived class with the same signature...
        public override string ToString()
        {
            return $"The Name:{EmpName} Earns a Salarys of {EmpSalary:C}";
        }
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
            //Find the matching employee
            //Set the new values to the found employee
            //exit the function
            //Else throw an Exception if no Emp record is found...
            foreach (var temp in _employees)//Forward only and read only...
            {
                if(temp.EmpID == emp.EmpID)
                {
                    temp.EmpName = emp.EmpName;
                    temp.EmpSalary = emp.EmpSalary;
                    return;//If U dont exit the function or the loop, throws an Exception....
                }
            }
            throw new Exception("Employee not found to update");
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
                Utility.ClearScreen();
            } while (processing);
        }
        //A function should be modular in nature. Dont write a method which is more than 10 lines of code. Maintaining becomes easier with better modularity..
        private static bool processMenu(string choice)
        {
            switch (choice)
            {
                case "1":
                    addingEmployeeFeature();
                    return true;
                case "2":
                    updatingEmployeeFeature();
                    return true;
                case "3":
                    findingEmpByID();
                    return true;
                case "4":
                    findingEmpByName();
                    return true;
                default:
                    return false;
            }
        }

        private static void findingEmpByID()
        {
            throw new NotImplementedException("Do it Urself!!!!");
        }

        private static void findingEmpByName()
        {
            string name = Utility.GetString("Enter the name or part of name of the Employee to search");
            var list = repository.GetEmployee(name);
            foreach(var emp in list)
                Console.WriteLine(emp);//Console's WriteLine evaluates the data to string. The object here will be evaluated to string using ToString method of the Object class which is the base class for all types in .NET.
        }

        private static void updatingEmployeeFeature()
        {
            try
            {
                var emp = createEmployee();
                repository.UpdateEmployee(emp);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static Employee createEmployee()
        {
                var empId = Utility.GetNumber("Enter the ID of the Employee");
                var empName = Utility.GetString("Enter the name of the Employee");
                var empSalary = Utility.GetDouble("Enter the salary of the Employee");
                //create the object
                var emp = new Employee { EmpID = empId, EmpName = empName, EmpSalary = empSalary };
                return emp;
        }
        private static void addingEmployeeFeature()
        {
            try
            {
                var emp = createEmployee();
                //call the repository's add method. handle exceptions if any...
                repository.AddEmployee(emp);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
