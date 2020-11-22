using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Arrays_and_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] newArray;
            newArray = new int[5];


            for (int i = 0; i < 5; i++)
            {
                newArray[i] = 3;
                Console.WriteLine(newArray[i]);
            }

            //It's also possible to define the elements of an array within the declaration itself

            int[] secondArray = new int[5] { 2, 4, 6, 8, 10 };

            Console.WriteLine(secondArray[3]);

            next("foreach loops");

            //foreach loops
            //this kind of loop allows you to access all the elements in an array

            int[] thirdArray;

            thirdArray = new int[7] {1, 2, 3, 4, 5, 6, 7};
            foreach (int j in thirdArray)
            {
                Console.WriteLine(j);
            }

            next("multidimensional arrays");

            //Multidimensional Arrays

            /*

           | 3    5    2 |
           | 5    2    1 |
           | 7    3    5 |

            */

            int[,] x = new int[1, 2]; //A multidimentional array is an array that extends its contents as a matrix

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    int[,] matrix = new int[i, j];
                }
            }

            next("jagged arrays");

            //Jagged Arrays

            int[][] jaggedArr = new int[3][]; //The first number signalizes the amount of elements in the arr, the second symoblizes the dimensions of the arr

            next("Strings");

            //Strings
            //String objects have a number of useful properties

            string text = "text";

            Console.WriteLine("The length is " + text.Length); //Amount of characters in a string
            Console.WriteLine("The index of e is " + text.IndexOf('e')); //Shows the position of the first appearance of a char in a string
            Console.WriteLine("text with and s inserted in 4 is " + text.Insert(4, "s")); //Adds a specific char or string into the original string
            Console.WriteLine("text with everything after index 2 removed is " + text.Remove(2)); //Removes all the chars after the index
            Console.WriteLine("text with S replacing T is " + text.Replace("t", "s")); //Replaces a specific value in the string for another one

            Console.ReadLine();
        }

        static void next(String topic)
        {
            Console.WriteLine("----------NEXT UP: " + topic);
        }
    }
}
