using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = "Travis";
            string name2 = "Mark";
            string name3 = "Tom";
            bool isHappy = true;
           bool isUnsure = false;
           int happinessValue = 5;

            Console.WriteLine("This is the tale of " + name1 + ", " + name2 + " and " + name3);
            Console.WriteLine("They were all walking home when they saw a stange man");
            Console.Write("What was the name of the strange man?: ");

           string name4= (Console.ReadLine());

            Console.WriteLine("The strange man said his name was " + name4);

            Console.Write("How old was the strange man?: ");

            int manAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("He was " + manAge + " years old");

            Console.WriteLine("Was the strange man happy to see them? y/n");

            string firstAnswer = (Console.ReadLine());

            if (firstAnswer == "y")
            {
                Console.WriteLine("The strange man was happy to see them");
                isHappy = true;
                
            }
            else if (firstAnswer == "n") 
            {
                Console.WriteLine("The strange man was not happy to see them");
                isHappy = false;
            }
            else
            {
                Console.WriteLine("The strange man was unsure about the three men");
                isUnsure = true;
            }
            
            

            Console.ReadLine();
        }

    }
}
