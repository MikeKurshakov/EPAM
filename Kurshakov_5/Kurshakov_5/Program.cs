using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using ArrayClass;


namespace Kurshakov_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int lowLim = 10,uppLim=20,i;
            MyArray myArr = new MyArray(lowLim, uppLim);
            int length,low,upp;

            for (i = lowLim; i < uppLim+1; i++)
            {
                myArr[i] = i;
            }

            low = myArr.LowLim;
            upp = myArr.UppLim;
            length = myArr.GetLength;

        }
    }
}
