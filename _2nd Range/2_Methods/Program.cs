using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            next();
            Print(3);

            next();

            int res = Sum(3, 5);
            Console.WriteLine(res);

            next();

            Minus(6);
            Minus(6, 3);

            next();

            inta();
            inta2();

            Console.ReadLine();
        }

        static void next() //You don't need to put "public"
        {
            Console.WriteLine("----------NEXT----------");
        }

        static void Print(int x) //A void method that asks for a parameter
        {
            Console.WriteLine(x);
        }

        static int Sum(int x, int y) //When you have multiple parameters you have to use the type of parameter on the method
        {
            return x + y;
        }

        static int Minus(int x, int y = 2) //If one of the parameters is declared, declaring it when calling the method is optional
        {
            int result = x - y;
            Console.WriteLine("The result is: " + result);
            return result;
        }

        //Passing arguments

        //As value
        static void Sqr(int x)
        {
            x = x * x;
        }

        static void inta()
        {
            int a = 3;
            Sqr(a); // Will execute the command but will not change it in the method

            Console.WriteLine(a);
        }

        //As reference
        static void Sqr2(ref int x) //to be able to change the value, you'd need to use the keyword "ref"
        {
            x = x * x;
        }

        static void inta2()
        {
            int a = 3;
            Sqr2(ref a); //it has to be called as a "ref"

            Console.WriteLine(a);
        }

        //As exit
        static void getValues(out int x, out int y) //When you set the parameters as exit parameters, you can use the declared variables inside it to call it in another method
        {
            x = 5;
            y = 42;
        }

        static void inta3()
        {
            int a, b;
            getValues(out a, out b); //The method will be called and the asigned values will be the ones defined inside the method

            Console.WriteLine(a + "," + b);
        }

        //This project is very bloated and filled already, Continuation in part 2
    }
}
