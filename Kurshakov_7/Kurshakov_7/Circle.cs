using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurshakov_7
{
    class Circle:Shape
    {
        public Circle(int radius)
        {
            sideArray = new int[1];
            sideArray[0] = radius;
            GetName = "Circle";
        }

        public override double GetArea()
        {
            return Math.PI*Math.Pow(sideArray[0],2);
        }
    }
}
