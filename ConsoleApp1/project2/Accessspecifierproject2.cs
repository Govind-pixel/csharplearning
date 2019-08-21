using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    class Accessspecifierproject2:ConsoleApp1.Accessspecifier  // Childclass is created in another project to check access specifier
        //Note refrence must be added in the properties ; // the target file chosen shold be consoleapp1 .exe file
    {
        static void Main(string[] args)
        {
            Accessspecifierproject2 o = new Accessspecifierproject2();
            o.test3(); //protected method is allowed
            o.test4(); //protected internal is alowed
            o.test5(); // protected public is allowed 
            Console.ReadLine();  
        }
    }
}
