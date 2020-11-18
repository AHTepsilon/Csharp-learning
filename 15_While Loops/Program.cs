using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program15
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;

            //A while loop repeats an action while certain conditions are true
                while (number != 4)
                {
                    Console.Write("What is the solution for 2+2?: ");
                    number = int.Parse(Console.ReadLine());

                    switch (number)
                    {
                        case 4:
                            Console.WriteLine("Good Job!");
                            break;
                        default:
                            Console.WriteLine("That was not correct, please try again :)");
                            break;
                    }
                }

                Console.ReadLine();
        }
    }
}
