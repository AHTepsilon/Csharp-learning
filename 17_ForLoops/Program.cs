using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program17
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;

            //here, I establish three factors (create the variable / give the condition / do the action)
            for (int i = 0; i < number; i++)
                Console.WriteLine(i);

            ForEach();
            //here, I'm calling the ForEach() method found lower from here

            Console.ReadLine();
        }

        public static void ForEach() 
        {
            System.Collections.ArrayList list = new System.Collections.ArrayList();
            //no idea why I needed to put the System.Collections thing before the ArrayList but whatever, it works

            list.Add("John Doe");
            list.Add("Jane Doe");
            list.Add("Someone Else");

            foreach (string name in list)
                Console.WriteLine(name);

            //here, I'm printing each name in the ArrayList I previoulsy created

            Console.ReadLine();
        }
    }
}
