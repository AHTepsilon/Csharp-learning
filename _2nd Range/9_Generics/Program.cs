using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Generics
{
    class Program
    {
        //When you reference a generic type, you can be flexible with the kind of data you're handling
        static void print<T>(ref T x)
        {
            Console.WriteLine(x);
        }

        static void printTwo<T, U>(ref T x, ref U y)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }

        static void Main(string[] args)
        {
            int x = 5;
            print<int>(ref x);

            String y = "Hello World";
            print<String>(ref y);

            printTwo<int, String>(ref x, ref y);

            next();

            Stack<int> intStack = new Stack<int>();

            intStack.push(4);
            intStack.push(6);

            Stack<String> stringStack = new Stack<String>();

            stringStack.push("Hello");
            stringStack.push("World");

            Console.WriteLine(stringStack.get(0) + " " + stringStack.get(1) + " " + intStack.get(0) + "" + intStack.get(1));

            next();

            // lists are used to save objects dynamically

            List<int> li = new List<int>();

            li.Add(59); li.Add(12); li.Add(76); li.Add(4);

            for(int i = 0; i < li.Count; i++)
            {
                Console.WriteLine(li[i] + " ");
            }

            li.Sort();

            for (int i = 0; i < li.Count; i++)
            {
                Console.WriteLine("Sorted: " + li[i] + " ");
            }
        }

        static void next()
        {
            Console.WriteLine("----------NEXT----------");
        }
    }
}
