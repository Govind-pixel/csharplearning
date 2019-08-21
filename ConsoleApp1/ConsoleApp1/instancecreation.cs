using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class instancecreation
    {
        public int x;
        public instancecreation (int x)
        {
            this.x = x; 
            Console.WriteLine("Instance called");
        }
        static void Main()
        {
            instancecreation g1 = new instancecreation(100);// Instance creation method 1
            instancecreation g2; // g2 is a variable of class
            g2 = new instancecreation(200); // g2 in now its the instance of class
            Console.WriteLine(g1.x);
            Console.WriteLine(g2.x);
            Console.ReadLine();
        }
    }
}
