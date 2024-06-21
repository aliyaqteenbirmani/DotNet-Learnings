using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    class Polymorphism
    {
        public void Test1()
        {
            Console.WriteLine("Parent class Test1 method is called.");
        }

        public void Test2()
        {
            Console.WriteLine("Parent class Test2 method is called.");
        }

        public virtual void Show()
        {
            Console.WriteLine("Parent Show method is called");
        }

    }

    class ChildClass:Polymorphism
    {
        public void Test1(int i)
        {
            Console.WriteLine("Child class Test1 method id called.");
        }

        public void Show()
        {
            Console.WriteLine("Child Show method is called");
        }
        //static void Main()
        //{
        //    ChildClass c = new ChildClass();
        //    c.Test1();
        //    c.Test2();
        //    c.Test1(10);
        //    c.Show();
        //    Console.ReadLine();
        //}
    }
}
