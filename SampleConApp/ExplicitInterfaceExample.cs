using System;

namespace SampleConApp
{

    interface ISimple
    {
        void Create(string value);
    }

    interface IExample
    {
        void Create(string value);
    }

    class SimpleExample : ISimple, IExample
    {
        public void Create(string value)
        {
            Console.WriteLine("The Function is implemented as " + value);
        }
        //Explicit implementation is a feature where I can implement the interface method explicitly to the interface itself...
        void IExample.Create(string value)
        {
            Console.WriteLine("Example's version of " + value);
        }

        void ISimple.Create(string value)
        {
            Console.WriteLine("Simple's version of " + value);
        }
    }

    //C#8 has a feature called Default interfaces. An interface can have one method implemented. 
    //interface ExampleInterface
    //{
    //    public void SimpleFunction() => Console.WriteLine("Implemented in the interface");
    //}

    class InterfaceExample
    {
        static void Main(string[] args)
        {
            ISimple sim = new SimpleExample();
            sim.Create("Simple");

            IExample ex = new SimpleExample();
            ex.Create("Example");

            SimpleExample simEx = new SimpleExample();
            simEx.Create("Simple and Example");
        }
    }
}
