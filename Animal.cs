using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    class Animal
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping");
        }
    }


}
