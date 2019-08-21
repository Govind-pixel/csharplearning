using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Accessbyinstance // Access by instance of the same project
    {
        static void Main()
        {
            Accessspecifier n = new Accessspecifier();
            n.test2();// internal access allowed
            n.test4();// proteted intrnl access allowed
            n.test5();// public access allowed 
            Console.ReadLine(); 
        }
    }
}
