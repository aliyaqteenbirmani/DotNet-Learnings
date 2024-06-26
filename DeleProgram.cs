using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    // Step 1: Defining a delegate
    public delegate void AddDelegate(int x, int y);
    public delegate string SayDelegate(string str);
    class DeleProgram
    {
       
        public void AddNums(int a, int b)
        {
            Console.WriteLine(a+b);
        }

        public static string SayHello(string name)
        {
            return "Hello" + name;
        }

        static void Main(string[] args)
        {
            DeleProgram obj = new DeleProgram();
            AddDelegate ad = new AddDelegate(obj.AddNums);
            ad.Invoke(100, 43);

            SayDelegate sd = new SayDelegate(DeleProgram.SayHello);
            string str = sd.Invoke(" Ali Yaqteen");
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
