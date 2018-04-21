using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurshakov_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //TASK 1.1

            Triangle triangle = new Triangle(1,2,3);
            double area;
            string figureName;
            area = triangle.GetArea();
            figureName = triangle.GetName;

            Circle circle = new Circle(2);
            area = circle.GetArea();
            figureName = circle.GetName;

            Rectangle rectangle = new Rectangle(2,4);
            area = rectangle.GetArea();
            figureName = rectangle.GetName;

            IsoscelesTriangle isoscelesTriangle = new IsoscelesTriangle(2, 4);
            area = isoscelesTriangle.GetArea();
            figureName = isoscelesTriangle.GetName;

            Square square = new Square(4);
            area = square.GetArea();
            figureName = square.GetName;

            //TASK 1.2 (Just showed that I know how to use it.)
            TriangleI triangleI =new TriangleI(1,2,3);
            area = triangleI.GetArea();
            figureName = triangleI.GetName;

            IsoscelesTriangleI isoscelesTriangleI = new IsoscelesTriangleI(2, 4);
            area = isoscelesTriangleI.GetArea();
            figureName = isoscelesTriangleI.GetName;

            //TASK2

            Animals[] animalsArray = new Animals []{new Wolf(),new Fox(),new Hare(),new Deer()};
            int wolfAmount = 0;
            int foxAmount = 0;
            int hareAmount = 0;
            int deerAmount = 0;
            int predatorAmount = 0;
            int herbivorousAmount = 0;
            int animalsAmount = 0;

            foreach (Animals item in animalsArray)
            {
                if (item is Wolf)
                    wolfAmount++;
                if (item is Fox)
                    foxAmount++;
                if (item is Hare)
                    hareAmount++;
                if (item is Deer)
                    deerAmount++;
                if (item is Predator)
                    predatorAmount++;
                if (item is Herbivorous)
                    herbivorousAmount++;
                if (item is Animals)
                    animalsAmount++;
            }

        }
    }
}
