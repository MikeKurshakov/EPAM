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

        public void SetSide(double side)
        {
            this.side = side;
        }

        public double GetSide()
        {
            return side;
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
