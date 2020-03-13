using System;
//Delegates are functional references that are used to create references for methods. Typically required if U want to create Callback functions, Invoke method thro aliases and event handling features of UI based Applications. 
//Basically they are objects that refer to a method, which means that U R creating a variable that can point to a method. Incidentally U can invoke the method thro the reference. Similar to the function pointer concept of C++ and  C.
//Technically U can create objects of the methods and instantiate it later before U invoke them. 
//System.Delegate which provides the functionalities required for delegate invocation and maintaining scopes of the methods. 
namespace SampleConApp
{
    delegate double operation(double v1, double v2);
    //This is a type which can allow to create reference variables that point to any kind of method that matches the signature of the delegate.
    
        
     class MethodInvocation
    {
        //This method is designed to call other methods of a specific signature. In this case, I wish to pass the method as the arg of the function so that the function invokes that method after certain operations are done.
        internal static void InvokeMethod(operation instance)
        {
            if(instance == null)
            {
                Console.WriteLine("We cannot invoke a delegate object that is not mapped to any function!!!");
                return;
            }
            var v1 = Utility.GetDouble("Enter the First value");
            var v2 = Utility.GetDouble("Enter the Second value");
            var result = instance(v1, v2);
            Console.WriteLine("The result of this operation is " + result);
        }
    }
    class DelegatesAndEvents
    {
        static double addOperation(double v1, double v2) => v1 + v2;
        static double someOperation(double v1, double v2) => v1 + (v2 * (v1 - v2)) / v2 - v1;
        static void Main(string[] args)
        {
            //simpleDelegateExample();
            practicalDelegateExample();
        }

        private static void practicalDelegateExample()
        {
            //operation op = someOperation;
            //MethodInvocation.InvokeMethod(op);
            //MethodInvocation.InvokeMethod(someOperation);
            operation op = (v1, v2) => v2 / v1; //Lambda Expressions....
            //U just created a method that has no name to it. The purpose of this method is only to be used within a delegate instance and there is no need to create an explicit function...
            MethodInvocation.InvokeMethod((a, b) => a -b);//no need for return statement...
        }

        private static void simpleDelegateExample()
        {
            operation op = new operation(addOperation);//old syntax of instantiating delegate...
            op = addOperation; //Simpler and new way of mapping the delegate object with the method..
            //op will be the reference variable of the addOperation. 
            var res = op(123, 234);
            Console.WriteLine(res);
        }
        //Practically used for creating references for methods to invoke them later(on a certain condition). 
    }
}
