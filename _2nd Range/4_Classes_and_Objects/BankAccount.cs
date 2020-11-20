using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Classes_and_Objects
{
    class BankAccount
    {
        private String name;

        public String Name //getters and setters for private values are set in a special type of constructor
        {
            get { return name; }
            set { name = value; }
        }

        public int id;

        private int amountSaved;

        public int AmountSaved
        {
            get { return amountSaved; }
            set { amountSaved = value; }
        }

        public BankAccount(String name, int id, int amountSaved)
        {
            this.name = name;
            this.id = id;
            this.amountSaved = amountSaved;
        }

        public void printer()
        {
            Console.WriteLine("name: " + name);
            Console.WriteLine("id: " + id);
            Console.WriteLine("amount saved in the bank: " + amountSaved);
        }
    }
}
