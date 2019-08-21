using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    class instanceoproject
    {
        static void Main()
        {
            ConsoleApp1.Accessspecifier p = new ConsoleApp1.Accessspecifier();
            p.test5();
            Console.WriteLine("Public is only accessible for instance in another project");
            Console.ReadLine();
        }
    }
}
