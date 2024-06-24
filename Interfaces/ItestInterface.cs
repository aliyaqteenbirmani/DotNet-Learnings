using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence.Interfaces
{
    interface ItestInterface
    {
        void add(int a, int b);
        void Sub(int a, int b); 
    }

    interface ITest1Interface:ItestInterface
    {
        void Mul(int a, int b);
    }
    class Test: ITest1Interface
    {
        public void add(int a, int b)
        {
            Console.WriteLine(a+b);
        }

        public void Sub(int a, int b)
        {
            Console.WriteLine(a-b);
        }

        public void Mul(int a, int b)
        {
            Console.WriteLine(a*b);
        }
        static void Main(string[] args)
        {
            ITest1Interface test = new Test();
            test.add(5, 6);
            test.Sub(10, 6);
            test.Mul(5,5);
            Console.ReadLine();
        }
    }
}
