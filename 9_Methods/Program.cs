using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program9
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHi("Mike", 33);
            SayHi("John", 56);
            SayHi("Tom", 12);
            SayBye("Adam");

            Console.ReadLine();
        }

        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age);
        }

        static void SayBye(string name)
        {
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine("Goodbye " + name);
        }
    }
}
