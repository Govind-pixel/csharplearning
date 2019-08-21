using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Accesschildclass:Accessspecifier // childclass of Accessspecifer of the same project
    {
        static void Main ()
        {
            Accesschildclass m = new Accesschildclass();
            m.test2(); // internal access allowed
            m.test3();// protected access allowed
            m.test4();// protected internal method allowed
            m.test5();// public access allowed
            Console.ReadLine();

        }
  
    }
    }

