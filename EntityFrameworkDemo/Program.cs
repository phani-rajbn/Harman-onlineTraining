using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new MyDbEntities();
            var patients = context.PatientTables.Select((p) => p.PatientName).ToList();
            foreach (var p in patients) Console.WriteLine(p);

            Console.WriteLine("Enter the name or part of name");
            string name = Console.ReadLine();
            var selected = context.PatientTables.Where((p) => p.PatientName.Contains(name)).ToArray();
            foreach (var p in selected) Console.WriteLine(p.PatientName);
        }
    }
}
