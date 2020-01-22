using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Circle : Shape
    {
        public double getArea()
        {
            return (getPhi() * Radius * Radius);
        }
        public double getAround()
        {
            return (2 * setPhi() * Radius);
        }
    }
}
