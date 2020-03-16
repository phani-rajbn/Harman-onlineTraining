using System;
using System.Collections.Generic;
using System.Reflection;


//Attributes are optional properties  are are injecting into the Application which can be set by the user if required. The optional property will be added to the class only if the user sets it, else the property will not be available to the object. Any additional logic U wish to place to an object or a class or a method could be injected thro attributes. Attributes are added using [] above the code that U wish to add. 
//WCF uses a lot of attributes to set extra logic to Ur code. Serialization also adds extra code to serialize the objects using [Serializable]...
namespace SampleConApp
{
    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    sealed class SampleAttribute : Attribute
    {
        // See the attribute guidelines at 
        //  http://go.microsoft.com/fwlink/?LinkId=85236
        readonly string ourinternalValue;

        // This is a positional argument
        public SampleAttribute(string positionalString)
        {
            ourinternalValue = positionalString;

        }

        public string OurString
        {
            get { return ourinternalValue; }
        }
    }

    [Obsolete("A new version of this class is available at System.Test.Example")]
    [Sample("Some Text toAdd")]
    class AttributeProgramming
    {
        void TestFunc() => Console.WriteLine( "Test Func");
        static void Main(string[] args)
        {
            AttributeProgramming ex = new AttributeProgramming();
            ex.TestFunc();

            //Attributes are accessed using Reflection
            var attribute = ex.GetType().GetCustomAttribute(typeof(SampleAttribute)) as SampleAttribute;
            if (attribute == null) Console.WriteLine("No custom Attributes are set to this class");
            else
            Console.WriteLine(attribute.OurString); 
        }
    }
}
