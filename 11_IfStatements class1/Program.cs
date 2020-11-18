using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program11
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isHungry = true;
            bool isClean = true;
            bool willDie = false;
            bool looksNice = false;
            bool isCloudy = false;

            Console.WriteLine("I woke up");

            if (isHungry && isClean)
            {
                Console.WriteLine("I ate breakfast");
            }
            else
            {
                Console.WriteLine("I didn't ate breakfast");
            }
            
            if (willDie || looksNice)
            {
                Console.WriteLine("I charged my phone");
            }
            else
            {
                Console.WriteLine("I didn't charge my phone");
            }

            if (isCloudy)
            {
                Console.WriteLine("I took my umbrella");
            }
            else
            {
                Console.WriteLine("I broguth my sunglasses");
            }

            Console.ReadLine();
        }
    }
}
