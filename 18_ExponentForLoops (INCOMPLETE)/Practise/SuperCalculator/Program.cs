using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Super Calculator!");
            Console.WriteLine("Coded by Alejandro Hernández Toro");
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Is there a third number? yes/no: ");
            string answer = (Console.ReadLine());

            if (answer == "yes") 
            {
                Console.Write("Enter the third number: ");
                double num3 = Convert.ToDouble(Console.ReadLine());
            } else
            {
                Console.WriteLine("There seems to be no third number, proceeding");
            }

            Console.Write("Enter the first operator: ");
            string firstOperator = (Console.ReadLine());

            if (answer == "yes")
            {
                Console.WriteLine();
                Console.Write("Enter the second operator: ");
                string secondOperator = (Console.ReadLine());
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("It seems you have not chosen a third number, proceeding");
            }

            if (firstOperator == "+") 
            {
                
                Console.WriteLine(num1+num2);
            }
        }
    }
}
