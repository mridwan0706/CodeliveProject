using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Rectangle : Shape
    {
        public int getArea()
        {
            return (height * width);
        }
        public int getAround()
        {
            return ((2 * height) + (2 * width));
        }
    }

}
