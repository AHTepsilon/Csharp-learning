using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fields
{
    class Program
    {
        static void Main(string[] args)
        {
            this.Describe();
        }
    }
    public class FieldSample
    {

        private string name = "John Doe";
        private int age = 32;

        public void Describe()
        {
            string description = this.name + "name" + this.age + "years old";
            Console.WriteLine(description);
        }
    
    }
    
}
