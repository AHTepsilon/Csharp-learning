using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Inheritance_and_polimorphism
{
    class Trapezoid : IShape
    {
        public void draw()
        {
            Console.WriteLine("Draw trapezoid");
            IrregularTrapezoid irrTrap = new IrregularTrapezoid("Irregular Trapezoid");
            irrTrap.printIt();
        }
    }

    public class IrregularTrapezoid
    {
        String text;

        public IrregularTrapezoid(String text)
        {
            this.text = text;
        }

        public void printIt()
        {
            Console.WriteLine(text);
        }
    }
}
