using System;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace ArrayClass
{
    public class MyArray
    {
        private int[] builtArray;

        public int LowLim { get; private set; }
        public int UppLim { get; private set; }
        public int GetLength { get; private set; }

        public MyArray(int low, int high)
        {
            builtArray = new int[high - low+1];

            GetLength = high - low+1;
            LowLim = low;
            UppLim = high;
        }




        public int this[int index]
        {
            get { return builtArray[index - UppLim]; }
            set
            {
               builtArray[index - LowLim] = value;
            }
        }
    }
}
