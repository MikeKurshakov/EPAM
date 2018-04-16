using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using ArrayClass;
using Polynom;


namespace Kurshakov_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //TASK 1
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

            //TASK 2
            int[] coeffArray1 = new int[] { 1, -3, -5, 7, 9 };
            int[] coeffArray2 = new int[] { 7, 2, 4, 3 };
            int power1,power2;
            string showPolynom1,showPolynom2;

            MyPolynom polynom1=new MyPolynom(coeffArray1);
            MyPolynom polynom2 = new MyPolynom(coeffArray2);

            power1 = polynom1.PolynomPower;
            power2 = polynom2.PolynomPower;

            showPolynom1 = polynom1.ShowPolynom;
            showPolynom2 = polynom2.ShowPolynom;

            MyPolynom polynomAdd = polynom1 + polynom2;
            MyPolynom polynomSub = polynom1 - polynom2;
            MyPolynom polynomMult = polynom1 * polynom2;



        }
    }
}
