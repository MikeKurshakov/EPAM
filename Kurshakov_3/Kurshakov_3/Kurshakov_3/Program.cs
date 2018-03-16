using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurshakov_3
{
    class Program
    {
        enum Sort { bottom_up, up_bottom}

        static void Main(string[] args)
        {
            int elements_amount = 10,i;
            int[] array_sort = new int[elements_amount];

            //TASK 1
            Console.WriteLine("TASK1\n");


            Random rand = new Random();
            for (i = 0; i < elements_amount; i++)
                array_sort[i]=rand.Next(0, 50);
            Show_array(array_sort);

            Console.WriteLine("From min to max");
            Sort_array(array_sort, Sort.bottom_up);

            Console.WriteLine("From max to min");
            Sort_array(array_sort, Sort.up_bottom);


            //TASK 2
            Console.WriteLine("\n\nTASK2\n");

            elements_amount = 5;// amount of elements
            double progression_step = 3;//     t
            double start_element = 2;  //    a1
            double result = 1;

            result = start_element * Recursion_count(start_element + progression_step, progression_step, elements_amount);
            Console.WriteLine("Написать функцию, возвращающую " +
                "произведение n \nэлементов арифметической прогрессии " +
                "чисел с первым элементом a1 и шагом t (an = an-1 + t)." +
                "\n Шаг\t{0},\n начальный элемент\t{1}," +
                "\n количество елементов\t{2},\n " +
                "результат\t{3}.", progression_step, start_element
                , elements_amount,result);


            progression_step = 3;//     t
            start_element = 3;  //    a1
            double element_lim = 0.1;   //    alim

            result = 1;
            result = start_element * Recursion_for_down_count(start_element/progression_step, progression_step, element_lim);
            Console.WriteLine("Написать функцию, возвращающую " +
    "произведение n \nэлементов геометрической прогрессии " +
    "чисел с первым элементом a1 и шагом t (an = an-1//t)." +
    "\n Шаг\t{0},\n начальный элемент\t{1}," +
    "\n граничное значение\t{2},\n " +
    "результат\t{3:f4}.", progression_step, start_element
    , element_lim, result);

        }
        static void Show_array(int[] array_show)
        {
            int i;
            for (i = 0; i < array_show.Length; i++)
                Console.Write(" {0} ", array_show[i]);
            Console.Write("\n");
        }
        static void Sort_array(int[] array, Sort sort_criterion)
        {
            switch(sort_criterion)
            {
                case Sort.bottom_up:
                    Sort_from_bottom(array);
                    break;
                case Sort.up_bottom:
                    Sort_from_up(array);
                    break;
            }
        }
        static void Sort_from_bottom(int[] array)
        {
            int i,j;
            int buffer;

            for(i=0;i<array.Length;i++)
                for(j=0;j<array.Length-i-1;j++)
                    if(array[j]>array[j+1])
                    {
                        buffer = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = buffer;
                    }
    
            Show_array(array);     
        }
        static void Sort_from_up(int[] array)
        {
            int i, j;
            int buffer;

            for (i = 0; i < array.Length; i++)
                for (j = 0; j < array.Length - i - 1; j++)
                    if (array[j] < array[j + 1])
                    {
                        buffer = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = buffer;
                    }
            Show_array(array);
        }
        static double Recursion_count(double current_element,double step,int counter)
        {
            double result = 1;
            if (counter > 1)
            {
                result=current_element*Recursion_count(current_element + step, step, counter - 1);
            }
            else
                return 1;
            return result;
        }
        static double Recursion_for_down_count(double current_element, double step, double boarder)
        {
            double result = 1;
            if (current_element > boarder)
            {
                result = current_element * Recursion_for_down_count(current_element/step, step, boarder);
            }
            else
                return 1;
            return result;
        }
    }
}
