using System;

//Classes that cannot be extended are called as Sealed Classes. Even though not good for OOP, sealed classes are required when U have created a concrete class and U dont wish to extend it or do any modifications to it.
class BaseClass//This makes the class not inheritable...
{
    public virtual void TestFunc() => Console.WriteLine("Test Func implemented in base class");
}

class DerivedClass : BaseClass 
{
    //new implementation with no reference of its base...
    public override sealed void TestFunc() => Console.WriteLine("Test Func implemented in Derived class");
}

class DerivedV2 : DerivedClass
{
    
}
namespace SampleConApp
{
    class SealedClasses
    {
        static void Main(string[] args)
        {
            BaseClass cls = new DerivedClass();//Runtime polymorphism...
            cls.TestFunc();//Derived version will be hidden..
        }
    }
}
