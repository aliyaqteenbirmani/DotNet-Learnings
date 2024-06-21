using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    class Fish:Animal
    {
        public double SwimSpeed { get; set; }
        public Fish():base("dudi 1",13)
        {

        }
        public void Swim()
        {
            Console.WriteLine($"{Name} is swimming");
        }
    }
}
