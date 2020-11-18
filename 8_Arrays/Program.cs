using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luckyNumbers = {4, 8, 15, 16, 23, 42};
            string[] friends = new string[5];
            friends[0] = "Jim";
            friends[1] = "Kevin";

            luckyNumbers[2] = 900;

            Console.WriteLine(luckyNumbers[1]);
            Console.WriteLine(friends[1]);

            Console.ReadLine();
        }
    }
}
