using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
        public class  Accessspecifier // class can be declared as only internal or public
        {
            private void test1 ()
            {
                Console.WriteLine("The private method is called"); //Accessible only in the same class
            }
            internal void test2()
            {
                Console.WriteLine("The internal method is called"); //Accessible in same class,child class of same project,as an instance in same project
            }
            protected void test3()
            {
                Console.WriteLine("The protected method is called");//Accessible in same class,child class of same project,child class in different project (note:not as an instance)
        }
            protected internal void test4()
            {
                Console.WriteLine("The protect internal method is called");//Accessible in same class,child class of same project,instance as same project,child class in different project
        }
            public void test5()
            {
            Console.WriteLine("the public method is called");//Accessible in same class,child class of same project,instance as same project,child class in different project,As instance in different project
        }
        static void Main ()
        {
            Accessspecifier g = new Accessspecifier();
            g.test1();// private accessible only in the same class
            g.test2();//Internal accessible in same class
            g.test3();//protected accessible in same class
            g.test4();//Internal protected accessible in same class
            g.test5();//public accessible in same class
            Console.ReadLine();
        }
        }
    }

