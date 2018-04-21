using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurshakov_7
{
    class Square:Rectangle
    {
        public Square(int side):base(side,side)
        {
            sideArray = new int[1];
            sideArray[0] = side;
            GetName = "Square";
        }

        public override double GetArea()
        {
            return (Math.Pow(sideArray[0],2));
        }
    }
}
