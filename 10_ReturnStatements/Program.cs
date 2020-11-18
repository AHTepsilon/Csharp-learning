using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program10
{
    class Program
    {
        static void Main(string[] args)
        {
            int cubedNumber = Cube(5);
            Console.WriteLine(cubedNumber);

            Console.ReadLine();
        }

        static int Cube(int num)
        {
            int result = num * num * num;
            return result;
        }
    }
}
