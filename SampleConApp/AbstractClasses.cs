/*
 * Abstract classes are those which has atleast one abstract method is it. Abstract method is one which will not have any implementation. 
 * As one or more methods are not implemented, the class is incomplete, hense not usable, so they cannot be instantiated. Abstract classes cannot be instantiated....
 * When a class implements the abstract class, it must implement all the abstract methods of the base class, else it should also be marked as abstract....
 */
using System;
namespace SampleConApp
{
    abstract class Account
    {
        public int AccountNo { get; set; }
        public string AccountName { get; set; }
        public int Balance { get; private set; }//Balance can be set only within the class....
        public void Credit(int amount) => Balance += amount;
        public void Debit(int amount)
        {
            if (amount > Balance)
                throw new Exception("Insufficient Funds");
            Balance -= amount;
        }
        //How to calculate interest for different kinds of account that my bank has?
        public abstract void CalculateInterest();//Not clear on how to implement this. I am expecting my derived classes to implement this method and it must be implemented... 
    }

    class SBAccount : Account
    {
        //override is applied on abstract methods also. override is a formal way to tell that this method does not belong to this class but is implemented from the base class..
        public override void CalculateInterest()
        {
            var interest = (int)(Balance * 1 / 12 * 6.5 / 100);
            Credit(interest);
        }
    }

    //Implement the FD Account
    //class FDAccout : Account
    //{

    //}
    ////Implement the RDAccount
    //class RDAccount : Account
    //{
        
    //}

    //Create a Factory class that returns the object of account based on the value provided by the user.
    //Create the object thro factory and call the members of the class....
    class AbstractExample
    {
        static void Main(string[] args)
        {
            Account acc = new SBAccount { AccountNo = 1111, AccountName ="Phaniraj" };//Dependency inversion principle...
            acc.Credit(50000);
            acc.CalculateInterest();
            Console.WriteLine("The Current balance is " + acc.Balance);
        }
    }
}