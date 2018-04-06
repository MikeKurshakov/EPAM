using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Kurshakov_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //TASK1
            double side = 3;

            Square Figure = new Square();
            Figure.SetSide(side);

            double perimeterSquare = Figure.CalculatePerimeter();
            double squareCvadr = Figure.CalculateSquare();

            //TASK2
            double firstElement=1;
            double progressionStep=2;
            int elementsAmount=5;

            ArithmeticProgression Progression = new ArithmeticProgression(firstElement, progressionStep, elementsAmount);

            double avgValue = Progression.AvaregeValue();
            double summValue = Progression.ProgressionSum();
        }
    }
}
