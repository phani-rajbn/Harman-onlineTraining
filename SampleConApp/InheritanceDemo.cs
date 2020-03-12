using System;
/*
 * Inheritance is single inheritance: A Class can have only one base class at any level.
 * U can have multi-level Inheritance. A Class can continue its derivation to the other classes...A-->B-->C
 * .NET does not support Multiple Inheritance: A Class will have more than one base class at any level. Only C++ supports this feature. 
 * Why would U extend a class? Add a new feature to the system. Modify the existing feature to the system.
 * Method overriding is used to modify the existing feature.
 * The base class which defines the method must provide permission for the derived classes to be overriden. The base class declares the methods as virtual modifer. 
 * The derived class could modify the function by using override modifier. override can be applied  only to virtual functions or similar to that kind. A function that is already overriden can further be overriden in its derived classes
 * A(virtual a)-->B(override a)--->C(override a)
 * 
 */
namespace SampleConApp
{
    class BaseClass
    {
        public virtual void VirtualFunc() => Console.WriteLine("Virtual Func");
        public void BaseFunc() => Console.WriteLine("base method");
    }

    class DerivedClass : BaseClass
    {
        public override void VirtualFunc() => Console.WriteLine("Reimplemented in the Derived class");
        
        public void DerivedFunc() => Console.WriteLine("Derived method");
    }

    class ComponentFactory
    {
        //Good to return an abstraction instead of a concretion 
        public static BaseClass GetComponent(String arg)
        {
            switch (arg.ToLower())
            {
                case "base":
                    return new BaseClass();
                case "derived":
                    return new DerivedClass();
                default:
                    throw new Exception("Invalid Type");
            }
        }
    }
    class InheritanceDemo
    {
        static void Main(string[] args)
        {
            //DerivedClass cls = new DerivedClass();//creating instance...
            //cls.BaseFunc();
            //cls.DerivedFunc();//new feature is not added to the existing class, but extended to another class and added to it
            string clName = Utility.GetString("What kind of Class U want to use today?base or derived");
            BaseClass cls = ComponentFactory.GetComponent(clName);//Runtime polymorphism 
            //cls.BaseFunc();
            cls.VirtualFunc();//which version of the virtual function be called?

        }
    }
}
