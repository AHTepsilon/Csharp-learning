using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_MoreAboutClasses
{
    class Clients
    {
        private String[] names = new string[10]; //You can save Strings as arrays
        
        public string this[int index]
        {
            get { return names[index]; }
            set { names[index] = value; }
        }

    }
}
