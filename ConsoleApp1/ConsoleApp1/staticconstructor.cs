using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class staticconstructor
    {
        static staticconstructor ()
        {
            Console.WriteLine("Static constructor is called"); //static constructor
            
        }
        public staticconstructor ()
        {
            Console.WriteLine("Non-static constructor is called"); //Non-static constructor
        }

        static void Main()
        {
            Console.WriteLine("Main program executed"); //Main program
            staticconstructor t = new staticconstructor(); //Instance is required to call Non-static constructor
            Console.ReadLine();
        }
    }
}
