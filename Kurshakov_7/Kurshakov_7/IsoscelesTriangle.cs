using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurshakov_7
{
    class IsoscelesTriangle:Triangle
    {
        public IsoscelesTriangle(int baseSide, int isoscelesSide):base(baseSide,isoscelesSide,isoscelesSide)
        {
            sideArray = new int[2];
            sideArray[0] = baseSide;
            sideArray[1] = isoscelesSide;
            GetName = "Isosceles triangle";
        }

        public override double GetArea()
        {
            return (0.5*Math.Pow(sideArray[0],2)*Math.Sqrt(Math.Pow(sideArray[1], 2)/ Math.Pow(sideArray[0], 2)-0.25));
        }
    }
}
