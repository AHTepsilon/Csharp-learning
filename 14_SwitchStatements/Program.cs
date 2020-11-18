using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Do you enjoy C#? (yes/no/maybe)");
            string input = Console.ReadLine();

            //A switch statement is kind of like a quick if statement that requires less memory and looks nicer :)

            switch (input.ToLower()) //The ToLower makes it so that it's not affected by uppercase or lowercase
            {
                case "yes":
                    Console.WriteLine("That is very good to hear");
                    break; //Always end these with break
                case "no":
                    Console.WriteLine("That is very unfortunate to hear");
                    break;
                case "maybe":
                    Console.WriteLine("You will grow to enjoy it");
                    break;
                default: //default is used when none of the other cases work
                    Console.WriteLine("Please write something I can undertstand :)");
                    break;
            }

            Console.ReadLine();
        }
    }
}
