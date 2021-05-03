using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        //Structures are a special value types that can be used to encapsulate a small group of related variables
        //Unlike classes, they can be instanced without using "new" although they are more limited
        //They can't be abstract, they can't have inheritance, polimorphism, etc.
        struct Book
        {
            public String title;
            public String author;
            public int year;
            public int pages;

            public void printData()
            {
                Console.WriteLine(title);
                Console.WriteLine(author);
                Console.WriteLine(year);
                Console.WriteLine(pages);
            }
        }

        //enum can be used to save a series of ennumerated values, they can be assigned when declared
        enum Days { mon = 2, tue, wed, thu, fri, sat, sun };

        static void Main(string[] args)
        {
            Book book1;
            Book book2;

            book1.title = "Lord of The Rings";
            book1.author = "JR Tolkien";
            book1.year = 1954;
            book1.pages = 861;

            book2.title = "The Metamorphosis";
            book2.author = "Franz Kafka";
            book2.year = 1915;
            book2.pages = 354;

            book1.printData();
            book2.printData();

            next();

            int firstDay = (int)Days.mon;
            int thirdDay = (int)Days.wed;

            if(firstDay == 2)
            {
                Console.WriteLine("Monday");
            }

            Console.WriteLine(thirdDay);

            //Exceptions are meant to handle errors in the program

            try
            {
                int[] arr = new int[] { 4, 6, 7 };
                Console.WriteLine(arr[8]);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();

        }

        public static void next()
        {
            Console.WriteLine("----------NEXT----------");
        }
    }
}

