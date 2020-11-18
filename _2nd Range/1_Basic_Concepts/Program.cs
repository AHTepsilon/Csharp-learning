using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Concepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name: "); //Asks for user entry
            String name = Console.ReadLine(); //Saves user entry as a variable

            Console.Write("Can you please write your age?: ");
            int age = Int32.Parse(Console.ReadLine()); //Convert String into int

            Console.WriteLine("Hello " + name + "! " + "You are " + age + " years old!"); //Prints this stuff

            //if else statements
            if (age >= 18 && age <= 24)
            {
                Console.WriteLine("You are an adult!! :O");
            }
            else if (age >= 25)
            {
                Console.WriteLine("You are ancient!!!");
            }
            else
            {
                Console.WriteLine("Woah you are a child!! :o");
            }

            Console.WriteLine("---------NEXT----------");

            int x = 5;

            //switch statements
            switch (x)
            {
                case 0:
                    Console.WriteLine("it is 0");
                    break;
                case 1:
                    Console.WriteLine("it is 1");
                    break;
                case 2:
                    Console.WriteLine("it is 2!!! :D");
                    break;
                default:
                    Console.WriteLine("it is not 0 or 1 or 2 what");
                    break;
            }

            Console.WriteLine("---------NEXT----------");

            //while loops

            int num = 0;

            while (num < 10)
            {
                num++;
                Console.WriteLine(num);
            }

            Console.WriteLine("---------NEXT----------");

            //for loops

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("---------NEXT----------");

            //do while loops

            int a = 1;

            do
            {
                Console.WriteLine(a);
                a++;

            } while (a < 10);

            Console.ReadLine();
        }
    }
}
