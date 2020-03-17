using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Entities;

namespace EmpDataLib
{
    class XmlSerialization : IEmpCollection
    {
        private List<Employee> employees = new List<Employee>();
        const string filename = "AllEmployees.xml";
        //for deserialization
        private void loadData()
        {
            if (!File.Exists(filename))
            {
                employees = new List<Employee>();
                return;
            }
            XmlSerializer fm = new XmlSerializer(typeof(List<Employee>));
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            employees = fm.Deserialize(fs) as List<Employee>;
            fs.Close();
        }

        //for serialization
        private void saveData()
        {
            XmlSerializer fm = new XmlSerializer(typeof(List<Employee>));
            FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
            fm.Serialize(fs, employees);
            fs.Close();
        }
        public Employee this[int index] => employees[index];

        public int Total => employees.Count;

        public void AddEmployee(int id, string name, double salary)
        {
            loadData();
            var emp = new Employee { EmpID = id, EmpName = name, EmpSalary = salary };
            employees.Add(emp);
            saveData();//serialization of the complete List of employees..
        }

        public void DeleteEmployee(int id)
        {
            loadData();
            var emp = employees.Find((e) => e.EmpID == id);
            if (emp == null) throw new Exception($"Employee by ID {id} not found to delete");
            employees.Remove(emp);
            saveData();
        }

        public IEnumerator<Employee> GetEnumerator()
        {
            loadData();
            foreach (var emp in employees)
                yield return emp;//yeild is a keyword that returns the iterator of the object which U return
        }

        public void UpdateEmployee(int id, string name, double salary)
        {
            loadData();
            var foundEmp = employees.Find((emp) => emp.EmpID == id);
            if (foundEmp == null)
                throw new Exception("Employee not found to update");
            //Id is the way to identify the employee and assumed that id is not modifiable...
            foundEmp.EmpSalary = salary;
            foundEmp.EmpName = name;
            saveData();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
