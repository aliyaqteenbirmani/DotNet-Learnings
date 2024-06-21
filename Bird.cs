using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    class Bird:Animal
    {
        public double WingSpan { get; set; }

        public Bird():base("dudi",12)
        {

        }
        public void Fly()
        {
            Console.WriteLine($"{Name} is flying");
        }
    }
}
