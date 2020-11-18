using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program22
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car; //calling the class defined lower from here

            car = new Car("Red"); //creates a new object of the class "Car"
            Console.WriteLine(car.Describe()); //Prints car.Describe()
            car = new Car("Blue");
            Console.WriteLine(car.Describe());

            Console.ReadLine();
        }
    }

    class Car //Here we define a brand new class
    {
        private string color;

        public Car(string color)
        {
            this.color = color;
        }

        public string Describe() 
        {
            return "This car is " + Color;
        }

        public string Color 
        {
            get { return color; }
            set { color = value; }
        }
    }       
}

//I'd suggest coming back to this later when more information has been granted