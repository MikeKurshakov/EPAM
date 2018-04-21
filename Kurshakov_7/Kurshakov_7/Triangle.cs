using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurshakov_7
{
    class Triangle : Shape
    {
        public Triangle(int side1, int side2, int side3)
        {
            sideArray = new int[3];
            sideArray[0] = side1;
            sideArray[1] = side2;
            sideArray[2] = side3;
            GetName = "Triangle";
        }

        public override double GetArea()
        {
            return (Math.Sqrt(ArraySum() * (ArraySum() - sideArray[0]) * (ArraySum() - sideArray[1]) *
                              (ArraySum() - sideArray[2])));
        }

        private int ArraySum()
        {
            int summ = 0;
            foreach (int element in sideArray)
            {
                summ += element;
            }
            return summ;
        }
    }
}
