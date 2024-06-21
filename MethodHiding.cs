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
            base.Test2();
            Console.WriteLine("Method Test 2 from Child Class.");
        }

        static void Main()
        {
            DerivedClass child = new DerivedClass();
            child.Test1();
            child.Test2();

            Console.ReadLine();
        }
    }
}
