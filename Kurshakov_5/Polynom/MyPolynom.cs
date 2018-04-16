using System;

namespace Polynom
{
    public class MyPolynom
    {
        private int[] coeffArray;

        public int PolynomPower { get; private set; }

        public string ShowPolynom
        {
            get
            {
                string result = "Polynom: ", element = null;
                for (int i = coeffArray.Length - 1; i >= 0; i--)
                {
                    if ((coeffArray[i] >= 0) && (i != 0) && (i != coeffArray.Length - 1))
                    {
                        element = string.Concat("+", coeffArray[i].ToString(), "x^", i);
                    }
                    else if ((coeffArray[i] < 0) && (i != 0) && (i != coeffArray.Length - 1))
                    {
                        element = string.Concat("", coeffArray[i].ToString(), "x^", i);
                    }
                    else if ((i == 0) && (coeffArray[i] >= 0))
                    {
                        element = string.Concat("+", coeffArray[i].ToString());
                    }
                    else if ((i == 0) && (coeffArray[i] < 0))
                    {
                        element = string.Concat("", coeffArray[i].ToString());
                    }
                    else if (i == coeffArray.Length - 1)
                    {
                        element = string.Concat("", coeffArray[i].ToString(), "x^", i);
                    }

                    result = string.Concat(result, element);
                }

                return result;
            }
        }


        public MyPolynom(int[] coeffArray)
        {
            this.coeffArray = coeffArray;
            PolynomPower = coeffArray.Length - 1;
        }

        public int this[int index]
        {
            get { return coeffArray[index]; }
            set { coeffArray[index] = value; }
        }

        public static MyPolynom operator +(MyPolynom lPolynom, MyPolynom rPolynom)
        {
            int[] newCoeff = new int[Math.Max(lPolynom.PolynomPower + 1, rPolynom.PolynomPower + 1)];
            for (int i = 0; i < Math.Min(lPolynom.PolynomPower + 1, rPolynom.PolynomPower + 1); i++)
            {
                newCoeff[i] = lPolynom[i] + rPolynom[i];
            }

            if (Math.Max(lPolynom.PolynomPower + 1, rPolynom.PolynomPower + 1) == lPolynom.PolynomPower + 1)
                for (int i = rPolynom.PolynomPower + 1; i < lPolynom.PolynomPower + 1; i++)
                {
                    newCoeff[i] = lPolynom[i];
                }
            else
                for (int i = lPolynom.PolynomPower + 1; i < rPolynom.PolynomPower + 1; i++)
                {
                    newCoeff[i] = rPolynom[i];
                }

            return new MyPolynom(newCoeff);
        }

        public static MyPolynom operator -(MyPolynom lPolynom, MyPolynom rPolynom)
        {
            int[] newCoeff = new int[Math.Max(lPolynom.PolynomPower + 1, rPolynom.PolynomPower + 1)];
            for (int i = 0; i < Math.Min(lPolynom.PolynomPower + 1, rPolynom.PolynomPower + 1); i++)
            {
                newCoeff[i] = lPolynom[i] - rPolynom[i];
            }

            if (Math.Max(lPolynom.PolynomPower + 1, rPolynom.PolynomPower + 1) == lPolynom.PolynomPower + 1)
                for (int i = rPolynom.PolynomPower + 1; i < lPolynom.PolynomPower + 1; i++)
                {
                    newCoeff[i] = lPolynom[i];
                }
            else
                for (int i = lPolynom.PolynomPower + 1; i < rPolynom.PolynomPower + 1; i++)
                {
                    newCoeff[i] = -rPolynom[i];
                }

            return new MyPolynom(newCoeff);
        }

        public static MyPolynom operator *(MyPolynom lPolynom, MyPolynom rPolynom)
        {
            int[] newCoeff = new int[lPolynom.PolynomPower + rPolynom.PolynomPower + 1];
            for (int i = 0; i < lPolynom.PolynomPower + 1; ++i)
            for (int j = 0; j < rPolynom.PolynomPower + 1; ++j)
                newCoeff[i + j] += lPolynom[i] * rPolynom[j];
            return new MyPolynom(newCoeff);

        }
    }
}
