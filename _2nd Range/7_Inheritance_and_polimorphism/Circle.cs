using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Inheritance_and_polimorphism
{
    class Circle : Shape
    {
        public override void Draw() //this overrides the method created in the Shape class
        {
            Console.WriteLine("Draw Circle");
        }
    }
}
