using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurshakov_7
{
    interface IShape
    {
        double GetArea();
        string GetName { get; set; }
    }

    class TriangleI:IShape
    {
        private int[] sideArray = new int[3];

        public TriangleI(int side1, int side2, int side3)
        {
            sideArray[0] = side1;
            sideArray[1] = side2;
            sideArray[2] = side3;
            GetName = "Triangle";
        }
        public string GetName { get; set; }

        public double GetArea()
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
    class IsoscelesTriangleI : TriangleI, IShape
    {
        private int[] sideArray = new int[2];

        public IsoscelesTriangleI(int baseSide, int isoscelesSide) : base(baseSide, isoscelesSide, isoscelesSide)
        {
            sideArray = new int[2];
            sideArray[0] = baseSide;
            sideArray[1] = isoscelesSide;
            GetName = "Isosceles triangle";
        }
        public string GetName { get; set; }

        public double GetArea()
        {
            return (0.5 * Math.Pow(sideArray[0], 2) * Math.Sqrt(Math.Pow(sideArray[1], 2) / Math.Pow(sideArray[0], 2) - 0.25));
        }
    }

}
