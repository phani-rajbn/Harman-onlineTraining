using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
namespace SampleWinApp
{
    class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public int EmpSalary { get; set; }

        public override string ToString()
        {
            return $"{EmpID},{EmpName},{EmpSalary}";
        }
    }

    class EmpDatabase
    {
        private List<Employee> employees = new List<Employee>();
        private readonly string filename = ConfigurationManager.AppSettings["filename"];       
        public EmpDatabase()
        {
            loadDataFromFile();
        }

        private void loadDataFromFile()
        {
            var lines = File.ReadAllLines(filename);
            employees.Clear();//If  there is any data we shall clear it..
            foreach (var line in lines)
            {
                var words = line.Split(',');
                var emp = new Employee
                {
                    EmpID = int.Parse(words[0]),
                    EmpName = words[1],
                    EmpSalary = int.Parse(words[2])
                };
                employees.Add(emp);
            }
        }

        public List<Employee> GetAllEmployees()
        {
            return employees;
        }

        public void UpdateEmployee(Employee emp)
        {
            var selected = employees.Find((e) => e.EmpID == emp.EmpID);
            if (selected == null) throw new Exception($"Employee with id {emp.EmpID} not found to update");
            selected.EmpName = emp.EmpName;
            selected.EmpSalary = emp.EmpSalary;
            saveAllRecords();
        }

        private void saveAllRecords()
        {
            var lines = new List<string>();
            foreach(var emp in employees)
            {
                lines.Add(emp.ToString());
            }
            File.WriteAllLines(filename, lines);
        }

        public void AddNewEmployee(Employee emp)
        {
            employees.Add(emp);
            saveAllRecords();
        }
    }
}
