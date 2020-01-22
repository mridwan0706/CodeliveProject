using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class RightTriangle : Shape
    {
        public double getArea()
        {
            return (0.5 * Base * height);
        }

        public double getSideWay()
        {
            return (Math.Sqrt(Math.Pow(Base, 2) + Math.Pow(height, 2)));
        }

        public double getAround()
        {
            return (Base + height + getSideWay());
        }
    }
}
