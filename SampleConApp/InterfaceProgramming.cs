using System;
using System.Data;
using System.IO;
//Demo to manipulate a CSV file: CSV, JSON, XML...
//A class which has only abstract methods is called as interface. interface is a better way of creating classes as there will be only declarations but no implementations.
namespace SampleConApp
{
    //Interfaces are similar to abstract classes where the interface contains only abstract methods in them. U cannot have methods that are implemented inside an interface. The idea is to cleanly seperate the Declaration and Implementation. 
    //PLAN(Interface)-->IMPLEMENT(Class)
    //Interface members are all public. There is no scope of providing access specifier for the interface members. 
    //The class that implements the interface must provide public defns for all the interface methods. The class must implement the methods..
    //A class can implement multiple interfaces at the same level...
    interface IRepository//It is more like a plan and would be implemented by any class later...
    {
        void AddNewEmployee(int id, string name, double salary);
        void UpdateEmployee(int id, string name, double salary);
        void DeleteEmployee(int id);
        DataTable GetAllEmployees();//DataTable is an object in .NET to provide table like structure where the table has rows and columns..
    }

    class FileRepository : IRepository
    {
        const string filename = "SampleData.csv";
        private void saveDataToFile(DataTable table)
        {
            string contents = string.Empty;
            foreach(DataRow row in table.Rows)
            {
                string line = $"{row[0]},{row[1]},{row[2]}\n";
                contents += line;
            }
            File.WriteAllText(filename, contents);
        }
        public void AddNewEmployee(int id, string name, double salary)
        {
            //data will be in the form of Comma seperated values...  
            var line = $"{id},{name},{salary}";
            StreamWriter writer = new StreamWriter(filename, true);//true will append the existing file..
            writer.WriteLine(line);
            writer.Close();
        }

        public void DeleteEmployee(int id)
        {
            var table = GetAllEmployees();
            var row = table.Rows.Find(id);
            row.Delete();
            table.AcceptChanges();
            saveDataToFile(table);
            //populate back to the file...
        }

        public DataTable GetAllEmployees()
        {
            //Create a table
            var table = createTable();
            //read all the lines of the CSV file
            var lines = File.ReadAllLines(filename);//returns a String[] 
            //iterate thro each line and convert the data to a DataRow
            foreach(var line in lines)
            {
                //split the line into words based on ,
                var words = line.Split(',');//3 words with index starting with 0...
                var row = table.NewRow();
                for (int i = 0; i < words.Length; i++)
                {
                    row[i] = words[i];
                }
                table.Rows.Add(row);//Add the row to the table
            }
            table.AcceptChanges();
            return table;//Finally return the table...
        }

        private DataTable createTable()
        {
            DataTable table = new DataTable("Employees");
            table.Columns.Add("EmpID", typeof(int));
            table.Columns.Add("EmpName", typeof(string));
            table.Columns.Add("EmpSalary", typeof(double));
            table.PrimaryKey = new DataColumn[] { table.Columns[0] };
            table.AcceptChanges();
            return table;
        }

        public void UpdateEmployee(int id, string name, double salary)
        {
            //get the table
            var table = GetAllEmployees();
            //find the matching row
            var row = table.Rows.Find(id);
            //populate the row with new data
            row[1] = name;
            row[2] = salary;
            //save the changes to the file..
            table.AcceptChanges();
            saveDataToFile(table);
        }
    }
    /*
     * Collections
     * File IO
     * Serialization
     * Connected Model
     * Disconnected Model
     * LINQ to SQL
     * Entity Framework
     */
     static class RepositoryFactory
    {
        public static IRepository GetRepository(string type)
        {
            switch (type)
            {
                default:
                    return new FileRepository();
            }
        }
    }
    class InterfaceDemo
    {
        static IRepository demo = RepositoryFactory.GetRepository("");
        static void addEmployeeFeature()
        {
            var id = Utility.GetNumber("Enter the ID of the Employee");
            var name = Utility.GetString("Enter the Name of the Employee");
            var salary = Utility.GetDouble("Enter the salary");
            demo.AddNewEmployee(id, name, salary);
        }
        static void Main(string[] args)
        {
            //addEmployeeFeature();

            demo.UpdateEmployee(123, "Phaniraj B.N.", 55000);
            //deletingFeature();
            var table = demo.GetAllEmployees();
            foreach (DataRow row in table.Rows)
                Console.WriteLine($"{row[1]} earns a salary of {row["EmpSalary"]}");
        }

        private static void deletingFeature()
        {
            int id = Utility.GetNumber("Enter the ID of the Employee U wish to delete");
            demo.DeleteEmployee(123);
        }
    }
}
