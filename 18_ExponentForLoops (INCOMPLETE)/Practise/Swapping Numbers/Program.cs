using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapping_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the first number ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Oops, they got swapped :)");

            Console.WriteLine(num2);
            Console.WriteLine(num1);

            Console.ReadLine();
        }
    }
}
