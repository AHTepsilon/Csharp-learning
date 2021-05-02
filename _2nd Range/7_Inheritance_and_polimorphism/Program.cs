using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Inheritance_and_polimorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inheritance
            //Inheritance allows a class to be defined based on another class

            Dog dog1 = new Dog();

            dog1.bark();

            next("Protected members");
            //Protected members - check Animal class
            //Protected members can only be accessed by a class and its derivatives

            Console.WriteLine(dog1.Age);
            Console.WriteLine(dog1.Legs);
            //Console.WriteLine(dog1.name);   <-- This won't work because it's protected

            dog1.giveName();

            //Polimorphism

            Circle circ = new Circle();
            circ.Draw();

            Square squ = new Square();
            squ.Draw();

            //Abstract classes

            Triangle tri = new Triangle();
            tri.Draw();

            //Interfaces and anidated classes

            Trapezoid trap = new Trapezoid();
            trap.draw();

            Console.ReadLine();
        }   

        static public void next(String topic)
        {
            Console.WriteLine("----------NEXT UP: " + topic);
        }
                  
    }
}
