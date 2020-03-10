using System;

namespace SampleConApp
{
    class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; } = "Bangalore";
        public double BillAmount { get; set; }
        public DateTime DateOfBill { get; set; } = DateTime.Now;

        public Customer()
        {

        }

        //public Customer(int id, string name, string address, double amount, DateTime date)
        //{
        //    CustomerID = id; CustomerName = name; CustomerAddress = address; BillAmount = amount; DateOfBill = date;
        //}
        public override string ToString()
        {
            return $"The Name:{CustomerName}\nThe Address:{CustomerAddress}\nDate:{DateOfBill.ToLongDateString()}";
        }
    }
    class TypeInitializerDemo
    {
        static void Main(string[] args)
        {
            var cst = new Customer { };//Initializes to default values if not set....
            //Console.WriteLine(cst);
            //cst = new Customer();
            //cst.CustomerID = 123;
            //cst.CustomerName = "Phaniraj";
            //cst.CustomerAddress = "Bangalore";
            //cst.BillAmount = 5600;
            //cst.DateOfBill = DateTime.Now;
            //Console.WriteLine(cst);
            //New in C# 4.0, type  initialization syntax helps in initializing the data for the object during its creation without an explicit need of a constructor...
            cst = new Customer { CustomerID = 111, BillAmount = 400, CustomerName = "Superman"};
            Console.WriteLine(cst);
        }
    }
}
