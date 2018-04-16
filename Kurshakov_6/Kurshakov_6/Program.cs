using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurshakov_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] coeffArray1 = new int[,] { { 1, 2,3 }, { 4,5,6 }};
            int [,] coeffArray2 = new int[,] { { 9, 1 } , { 2, 3 }, {4, 5} };
            Matrix matrix1= new Matrix(coeffArray1);
            Matrix matrix2 = new Matrix(coeffArray2);

            try
            {
                Matrix matrixAdd = matrix1 + matrix2;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Размерность матриц должна совпадать.");
            }
            try
            {

                Matrix matrixSub = matrix1 - matrix2;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Размерность матриц должна совпадать.");
            }
            try
            {
                if (matrix1.GetDimentional()[1] != matrix2.GetDimentional()[0])
                {
                    throw new IndexOutOfRangeException("Размерность матриц должна согласовываться [n;m] и [m;k].");
                }
                Matrix matrixMult = matrix1 * matrix2;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
