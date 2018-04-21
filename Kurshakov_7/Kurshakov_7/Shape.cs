using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurshakov_7
{
    abstract class Shape
    {
        protected int[] sideArray;
        abstract public double GetArea();
        public string GetName { get; protected set;}
    }
}
