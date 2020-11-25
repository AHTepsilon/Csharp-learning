using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_MoreAboutClasses
{
    class Person
    {
        private String name;
        private readonly int age; //readonly makes it so the variable can only be modified in the constructor

        public Person(String name, int age)
        {
            this.name = name; //this is used to call the current instance of a variable to establish it
            this.age = age;
        }

        public void printer()
        {
            Console.WriteLine(name + " " + age);
        }
    }
}
