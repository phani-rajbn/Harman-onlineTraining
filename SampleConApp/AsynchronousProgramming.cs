using System;
using System.Threading;
//Func and Action are 2 delegates provided by .NET to perform any kind of delegate operations: Func is for methods that return a value and Action is for void methods.
//U can use delegate instances for invoking methods asychronously without threads. 
namespace SampleConApp
{
    class AsynchronousProgramming
    {
        static int doSomething()
        {
            int value = 0;
            for (int i = 0; i < 10; i++)
            {
                value += i;
                Console.WriteLine("Doing some thing big!!!");
                Thread.Sleep(1000);
            }
            return value;
        }
        static void Main(string[] args)
        {
            Func<int> func = doSomething;
            IAsyncResult ex =  func.BeginInvoke((exArg)=>
            {
                var result = func.EndInvoke(exArg);
                Console.WriteLine("The Result thro callback func is :" + result);
            }, null);//BeginInvoke is used to invoke  method async....

 //           var res = doSomething();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Main is also doing some thing big!!!");
                Thread.Sleep(1000);
            }
            while (!ex.IsCompleted)
            {
                Console.WriteLine("Please wait till our operation is done!!!");
                Thread.Sleep(1000);
            }
            //            var res = func.EndInvoke(ex);//Makes the caller of the function wait till the async operation is completed!!!
            //   Console.WriteLine($"The rsult:{res}");
            Thread.Sleep(2000);
            Console.WriteLine("Completed the program!!!");
        }
    }
}
