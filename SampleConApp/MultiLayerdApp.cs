using System;
using Entities;
using EmpDataLib;
using System.IO;

namespace SampleConApp
{
    class MainProgram
    {
        static IEmpCollection db = EmpFactory.GetComponent();
        //const string filename = @"C:\Users\phani\source\repos\Training\AdvancedCSharp\SampleConApp\EmpMenu.txt";
        static void Main(string[] args)
        {
            var menu = File.ReadAllText(args[0]);
            bool processing = true;
            do
            {
                try
                {
                    var choice = Utility.GetString(menu);
                    processing = processMenu(choice);
                    Utility.ClearScreen();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (processing);
        }

        private static bool processMenu(string choice)
        {
            switch (choice.ToUpper())//User choice could be case insensitive..
            {
                case "N":
                    addingEmpFeature();
                    return true;
                case "U":
                case "D":
                    return true;
                case "F":
                    findingFeature();
                    return true;
                default:
                    return false;
            }
        }

        private static void findingFeature()
        {
            var name = Utility.GetString("Enter the name or part of the name to search");
            foreach(var emp in db)
            {
                if(emp.EmpName.Contains(name))
                    Console.WriteLine($"{emp.EmpName} earns {emp.EmpSalary:C}");
            }
        }

        private static void addingEmpFeature()
        {
            try
            {
                var empid = Utility.GetNumber("Enter the ID of the Employee");
                var empName = Utility.GetString("Enter the Name of the Employee");
                var empSalary = Utility.GetDouble("Enter the Salary");
                db.AddEmployee(empid, empName, empSalary);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}