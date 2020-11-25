using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_MoreAboutClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Static members
            //Static member belong to a class, instead of belonging to an individual object ---> check the cat class

            Cat cat1 = new Cat();
            Cat cat2 = new Cat();
            Cat cat3 = new Cat();

            Person john = new Person("John", 24);

            Clients clients = new Clients();

            Console.WriteLine("^As you can see, the count won't reset, regardless of the amount of times it's called");

            next("Static classes");

            //Static classes

            Console.WriteLine(Math.Pow(2, 3)); //Math is a static class and Pow is a static method, you can only call static methods for static classes

            next("this and readonly");
            //this and readonly
            //Check class Person

            john.printer();

            next("indexers");

            //Indexers

            String str = "Hello World!"; //Strings are a series of char objects, so you can call any char in a string at any time by indexing
            char x = str[0];
            char x2 = str[1];
            char x3 = str[2];
            char x4 = str[3];
            Console.Write(x);
            Console.Write(x2);
            Console.Write(x3);
            Console.Write(x4);

            Console.WriteLine("");

            //Check the "clients" class

            clients[0] = "Dave";
            clients[1] = "John";

            Console.WriteLine(clients[0]);
            Console.WriteLine(clients[1]); //Now we saved an array of Strings as a string

            next("Overloading operators");

            //Overloading operators
            //Most operators can be overloaded, which means they can be redefined with custom actions - check Box class

            Box b1 = new Box(13, 2);
            Box b2 = new Box(5, 6);

            //If we were to add both boxes, we need to overload the method - check the class again

            Box b3 = b1 + b2; //because the method has been overloaded, we can now use it to add the values of both classes cojoinly

            Console.WriteLine(b3.height); //18
            Console.WriteLine(b3.width); //8

            Console.ReadLine();
        }

        static public void next(String text)
        {
            Console.WriteLine("----------NEXT UP: " + text);
        }
 
    }
}
