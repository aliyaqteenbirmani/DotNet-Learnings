using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    class MethodHiding
    {
        public virtual void Test1()
        {
            Console.WriteLine("Method Test 1 from Parent Class.");
        }
        public void Test2()
        {
            Console.WriteLine("Method Test 2 from Parent Class.");
        }
    }


    class DerivedClass : MethodHiding
    {

        public override void Test1()    // Method Overriding
        {
            Console.WriteLine("Method Test 1 from Child Class.");
        }

        public new void Test2()       // Method Hiding / Shadowing
        {
            Console.WriteLine("Method Test 2 from Child Class.");
        }

        public void ParentTest1()
        {
            base.Test1();
        }
        public void ParentTest2()
        {
            base.Test2();
        }

        public void Display()
        {
            Console.WriteLine("Display Method is called.");
        }
        //static void Main()
        //{
        //    DerivedClass child = new DerivedClass();
        //    //child.Test1();
        //    //child.Test2();
        //    //child.ParentTest1 ();
        //    //child.ParentTest2 ();

        //    MethodHiding methodHiding = child;
        //    methodHiding.Test1();
        //    methodHiding.Test2();

        //    Console.ReadLine();
        //}
    }
}
