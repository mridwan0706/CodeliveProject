using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Square: Shape
    {
        public int getArea()
        {
            return (side * side);
        }
        public int getAround()
        {
            return (4 * side);
        }
    }
}
