using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Inheritance_and_polimorphism
{
    class Dog: Animal //Here, I reference the Animal class
    {
        public Dog()
        {
            Legs = 4;
            Age = 8;
            name = "Max";

        }

        public void bark()
        {
            Console.WriteLine("Woof");
        }

        public void giveName()
        {
            Console.WriteLine(name);
        }
    }
}
