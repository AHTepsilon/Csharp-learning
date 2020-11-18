using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Max is:");
            Console.WriteLine(GetMax(48, 8, 31));
            Console.WriteLine("The Min is:");
            Console.WriteLine(GetMin(48, 8, 31));

            Console.ReadLine();
        }

        static int GetMax(int num1, int num2, int num3)
        {
            int result;

            if(num1 >= num2 && num1 >= num3)
            {
                result = num1;
            }
            else if (num2 >= num1 && num2 >= num3) 
            {
                result = num2;
            }
            else
            {
                result = num3;
            } 

            return result;
        }

        static int GetMin(int num1, int num2, int num3)
        {
            int result;

            if (num1 <= num2 && num1 <= num3)
            {
                result = num1;
            }
            else if (num2 <= num1 && num2 <= num3)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }


            return result;
        }
    }
}
