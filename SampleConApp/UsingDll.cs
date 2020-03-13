using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleLib;

/*
 * Dlls are precompiled units that are designed to be used across multiple projects. The precompiled units with an extension .dll will become UR Deployment unit(Assembly).
 * Classes created inside the DLL are usually public as they are intended to be used in other projects. 
 * Dlls are  not executables, they cannot run!!!.
 * U consume the DLL in other EXE based Applications by adding the reference of the DLL in it. Use the namespace of the class and then consume the class  by creating object of it...
 * In real time, all UR middleware code will be distributed as DLLs and consumed by various .NET Apps like Console, Windows, Web, MVC, WPF and WCF Applications. 
 * Make the Application modular as small DLL units which can be replaced by other without altering the Correctness of the App.
 */
namespace SampleConApp
{
    class UsingDll
    {
        static void Main(string[] args)
        {
            MathComponent com = new MathComponent();
            Console.WriteLine(com.AddFunc(123, 324));
            Console.WriteLine(com.SubFunc(123, 324));
            Console.WriteLine(com.MulFunc(123, 324));
            Console.WriteLine(com.DivFunc(123, 324));
            
        }
    }
}
