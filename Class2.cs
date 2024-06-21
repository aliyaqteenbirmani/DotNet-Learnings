using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    class Class2:Class1
    {
        Class2()
        {
            Console.WriteLine("CLass 2 constructor is called");
        }
        public void Test3()
        {
            Console.WriteLine("Method 3");
        }

    }
}
