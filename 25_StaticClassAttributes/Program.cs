using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program25
{
    class Program
    {
        static void Main(string[] args)
        {
            Song holiday = new Song("Holiday", "Green Day", 200);
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
            Song buddyHolly = new Song("Buddy Holly", "Weezer", 300);

            Console.WriteLine(Song.songCount);

            Console.ReadLine();
        }
    }
}
