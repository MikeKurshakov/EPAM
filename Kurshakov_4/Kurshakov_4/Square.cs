using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurshakov_4
{
    class Square
    {
        private double side;

        public Square(double side)
        {
            this.side = side;
        }
        public double CalculatePerimeter()
        {
            return 4 * side;
        }
        public double CalculateSquare()
        {
            return side*side;
        } 
    }
}
