using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_MoreAboutClasses
{
    class Box
    {
        public int height { get; set; }
        public int width { get; set; }
        public Box(int h, int w)
        {
            height = h;
            width = w;
        }

        public static Box operator+ (Box a, Box b) //Here, the operator+ method is overloaded, which means we have custom parameters for it now
        {
            int h = a.height + b.height;
            int w = a.width + b.width;
            Box res = new Box(h, w);
            return res;
        }
    }
}
