using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Methods_Part_2
{
    class Program
    {
        static void Main(string[] args) //Main Method
        {
            Printer(2);
            Printer(3, 4);

            next();

            Console.WriteLine(Fact(5));

            next();

            DrawPyramid(5);

            Console.ReadLine();
        }

        static void next()
        {
            Console.WriteLine("----------NEXT----------");
        }

        //Overloading Methods

        static void Printer(int a)
        {
            Console.WriteLine(a);
        }

        static void Printer(int b, int c)
        {
            Console.WriteLine(b + ", " + c);
        }

        //^^^^Both methods have the same name, however, they have different parameters, which differentiates them

        //Recursive Methods

        static int Fact(int num)
        {
            if(num == 1)
            {
                return 1;
            }

            return num * Fact(num - 1); //A recursive method is a method that calls itself inside the method
        }

        //Pyramid: Here's a funny game, drawing a pyramid

        static void DrawPyramid(int n)
        {
            for(int i = 1; i <= n; i++)
            {
                for(int j = i; j <= n; j++)
                {
                    Console.Write(" ");
                }

                for(int k = 1; k <= 2 + i - 1; k++)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
