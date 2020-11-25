using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_MoreAboutClasses
{
    class Cat
    {
        public static int count = 0; //Now the member belongs to the entire class, it won't change regardless of the amount of cat object created
        public Cat()
        {
            count++;
            Console.WriteLine(count);
        }
    }
}
