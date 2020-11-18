using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program19
{
    class Program
    {
        static void Main(string[] args)
        { 
            int[,] numberGrid =
                {
                {1, 2 },
                {3, 4 },
                {5, 6 }
            };

            int[,] myArray = new int[2, 3];

            Console.WriteLine(numberGrid[0, 0]);

            Console.ReadLine();
        }
    }
}
