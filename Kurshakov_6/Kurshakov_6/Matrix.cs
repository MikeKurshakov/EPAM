using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurshakov_6
{
    class Matrix
    {
        private int[,] coeffArray;

        public Matrix(int[,] coeffArray)
        {
            this.coeffArray = coeffArray;
        }
        public int this[int index1, int index2]
        {
            get { return coeffArray[index1,index2]; }
            set { coeffArray[index1,index2] = value; }
        }

        public int[] GetDimentional()
        {
            return new int[] {coeffArray.GetLength(0), coeffArray.GetLength(1)};
        }
        public static Matrix operator +(Matrix lMatrix,Matrix rMatrix)
        {
            int[,] newCoeff = new int[lMatrix.coeffArray.GetLength(0), lMatrix.coeffArray.GetLength(1)];
            for (int i = 0; i < lMatrix.coeffArray.GetLength(0); i++)
            {
                for (int j = 0; j < lMatrix.coeffArray.GetLength(1); j++)
                {
                    newCoeff[i, j] = lMatrix[i, j] + rMatrix[i, j];
                }
                
            }
            return new Matrix(newCoeff);
        }
        public static Matrix operator -(Matrix lMatrix, Matrix rMatrix)
        {
            int[,] newCoeff = new int[lMatrix.coeffArray.GetLength(0), lMatrix.coeffArray.GetLength(1)];
            for (int i = 0; i < lMatrix.coeffArray.GetLength(0); i++)
            {
                for (int j = 0; j < lMatrix.coeffArray.GetLength(1); j++)
                {
                    newCoeff[i, j] = lMatrix[i, j] - rMatrix[i, j];
                }

            }
            return new Matrix(newCoeff);
        }
        public static Matrix operator *(Matrix lMatrix, Matrix rMatrix)
        {
            int[,] newCoeff = new int[lMatrix.coeffArray.GetLength(0), rMatrix.coeffArray.GetLength(1)];
            int summ = 0;
            for (int i = 0; i < newCoeff.GetLength(0); i++)
            {
                for (int j = 0; j < newCoeff.GetLength(1); j++)
                {
                    for (int k = 0; k < Math.Max(rMatrix.coeffArray.GetLength(0),rMatrix.coeffArray.GetLength(1)); k++)
                    {
                        newCoeff[i, j] += lMatrix[i, k] * rMatrix[k, j];
                    }
                }
            }
            return new Matrix(newCoeff);
        }
    }
}
