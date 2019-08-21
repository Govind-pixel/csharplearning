using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public int x;
    }
    class second
    {
        public int x;
        public second(int x)
        {
            this.x = x;

        }
    }
    class Testclass
    {

        static void Main(string[] args)
        {
            Program f1 = new Program();
            Program f2 = new Program();
            Program f3 = new Program();
            Console.WriteLine(f1.x + " " + f2.x + " " + f3.x + " ");
            second s1 = new second(100);
            second s2 = new second(200);
            second s3 = new second(300);
            Console.WriteLine(s1.x + " " + s2.x + " " + s3.x + " ");
            Console.ReadLine();
                   }
    }
    }


