using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    class Mammal:Animal
    {
        public bool HasFur { get; set; }

        public Mammal(string name,int age):base(name, age)
        {
                
        }
        public void Run()
        {
            Console.WriteLine($"{Name} is runnig");
        }

    }


}
