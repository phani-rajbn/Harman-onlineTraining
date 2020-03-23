using System;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

//Async and await are keywords that are used to create Async programming introduced in .NET 4.0. The idea is to create and allow functions to await for any asycn operation that could be done without a need of a thread or any kernal based objects. It internally uses the multi cores available in the hardware to perform async tasks. The Task is a built in class provided by .NET to perform async programming using multi core facility provided by the Hardware of UR machine.  
//However the usage of the cores are dependent on the OS as well as the hardware configuration of the machine.

    //create the prgoram to call 2 method in a sync manner, then add async and await operations on which U could see the difference. 
    //if a method that is called async has to get a result which any other function needs, then use await to make the main program wait till the operation is complete and use the return value to the other function
namespace SampleConApp
{
    class AsyncAwaitProgram
    {
        static async Task Main()//Main being async method came only from C# 6.0
        {
            Task<int> t = readingFile();//It makes the next line of the program to wait till the operation is complete. U do this when there is a return value that U wish to use in the next function that U wish to invoke.
            smallOtherOperations();
            int noOfwords = await t;//await will make the execution wait t o get the result of the task, in this case the int value...      
            dosomethingwhileReadingfile(noOfwords);
        }

        private static void smallOtherOperations()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Doing small task!!!");
            }
        }

        private static void dosomethingwhileReadingfile(int no)
        {
            for (int i = 0; i < no; i++)
            {
                Thread.Sleep(100);
                Console.WriteLine("Doing some work!!!");
            }
        }

        //Mark the function with a modifier called async and perform the async task using await followed by calling the static method of the Task class called Run. Run taks the lambda expression of the task that U wish to perform. 
        private static async Task<int> readingFile()
        {
            string data = File.ReadAllText("../../Utility.cs");
            await Task.Run(() =>
            {
                for (int i = 0; i < data.Length; i++)
                {
                    Console.Write(data[i]);
                    Thread.Sleep(20);
                }
            });
            return data.Length;
        }
    }
}
