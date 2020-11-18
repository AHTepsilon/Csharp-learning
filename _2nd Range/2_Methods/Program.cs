using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            next();
            Print(3);

            next();

            int res = Sum(3, 5);
            Console.WriteLine(res);

            next();

            Minus(6);
            Minus(6, 3);

            Console.ReadLine();
        }

        static void next() //You don't need to put "public"
        {
            Console.WriteLine("----------NEXT----------");
        }

        static void Print(int x) //A void method that asks for a parameter
        {
            Console.WriteLine(x);
        }

        static int Sum(int x, int y) //When you have multiple parameters you have to use the type of parameter on the method
        {
            return x + y;
        }

        static int Minus(int x, int y = 2) //If one of the parameters is declared, declaring it when calling the method is optional
        {
            int result = x - y;
            Console.WriteLine("The result is: " + result);
            return result;
        }
    }
}
