using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.IO;

//steps of creating WCF Service:
/*
 * Data Classes
 * Interface and its methods
 * A Class that implements the interface. 
 * Config file to provide the required configuration
 */
namespace WCFProgramming
{
    [DataContract]
    public class Employee
    {
        [DataMember] public int EmpID { get; set; }
        [DataMember] public string EmpName { get; set; }
        [DataMember] public int EmpSalary { get; set; }
    }

    [ServiceContract]
    public interface IEmpService
    {
        [OperationContract]
        List<Employee> GetAllEmployees();        
    }

    public class EmpService : IEmpService
    {
        public List<Employee> GetAllEmployees()
        {
            var employees = new List<Employee>();
            var filename = @"C:\Users\phani\source\repos\Training\AdvancedCSharp\CommonData\Employees.csv";
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
            return employees;
        }
    }

}