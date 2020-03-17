using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//The class is declared as public as the default access specifier for the class is internal which is said to be available only within the project. If a class has to be consumed by other projects(Outside the current one), U should create the class as public. Note public or internal could be used for class declaration. 
//private is the default access specifier for members within the class. For the class itself, the access specifier is either public or internal.  
namespace SampleLib
{
   public class MathComponent
    {
        public double AddFunc(double first, double second) => first + second;
        public double SubFunc(double first, double second) => first - second;
        public double MulFunc(double first, double second) => first * second;
        public double DivFunc(double first, double second) => first / second;
    }
}
