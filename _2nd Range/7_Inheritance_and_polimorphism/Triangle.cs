using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Inheritance_and_polimorphism
{
    class Triangle : AbstractShapes
    {
        public override void Draw()
        {
            Console.WriteLine("Triangle Draw");
        }
    }
}
