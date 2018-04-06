using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurshakov_4
{
    class ArithmeticProgression
    {
        private double firstElement;
        private double progressionStep;
        private int elementsAmount;

        public ArithmeticProgression(double firstElement, double progressionStep)
        {
            this.firstElement = firstElement;
            this.progressionStep = progressionStep;
            this.elementsAmount = elementsAmount;
        }

        public void SetElementsAmount(int elementsAmount)
        {
            this.elementsAmount = elementsAmount;
        }

        public double AvaregeValue()
        {
            return (2*firstElement+(elementsAmount-1)*progressionStep)/2;
        }

        public double ProgressionSum()
        {
            int newElementsAmount = elementsAmount;
            return (newElementsAmount > 1)
                ? firstElement + ProgressionSum(firstElement + progressionStep, --newElementsAmount)
                : firstElement;
        }
        private double ProgressionSum(double currentElement,double elementsAmount)
        {
            return (elementsAmount > 1)
                ? currentElement + ProgressionSum(currentElement + progressionStep, --elementsAmount)
                : currentElement;
        }


    }
}
