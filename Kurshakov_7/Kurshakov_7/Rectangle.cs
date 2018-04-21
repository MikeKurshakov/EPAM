using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurshakov_7
{
    class Rectangle:Shape
    {
        public Rectangle(int side1, int side2)
        {
            sideArray = new int[2];
            sideArray[0] = side1;
            sideArray[1] = side2;
            GetName = "Rectangle";
        }

        public override double GetArea()
        {
            return (sideArray[0]*sideArray[1]);
        }

    }
}
