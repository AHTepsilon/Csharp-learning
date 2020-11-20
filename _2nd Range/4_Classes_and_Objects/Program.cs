using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Classes_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount1 = new BankAccount("Wallace", 8433256, 2551);
            BankAccount bankAccount2 = new BankAccount("Roderick", 1421446, 823);
            BankAccount bankAccount3 = new BankAccount("Linda", 05431405, 2924);

            bankAccount1.printer();
            bankAccount2.printer();
            bankAccount3.printer();

            bankAccount1.id = 64332834; //A public variable in the class can be changed as you please
            bankAccount1.Name = "Johnathan"; //When the set and get are added, the private variable can be modified with the normal method for modifying
            bankAccount1.AmountSaved = 1000;

            bankAccount1.printer();

            Console.ReadLine();

            //get and set
        }
    }
}
