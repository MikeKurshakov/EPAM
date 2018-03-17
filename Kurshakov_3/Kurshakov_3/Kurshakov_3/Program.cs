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
            ShowArray(array_sort);

            Console.WriteLine("\nFrom min to max");
            SortArray(array_sort, Sort.bottom_up);
            IsSort(array_sort, Sort.bottom_up);
            IsSort(array_sort, Sort.up_bottom);

            Console.WriteLine("\nFrom max to min");
            SortArray(array_sort, Sort.up_bottom);
            IsSort(array_sort, Sort.up_bottom);
            IsSort(array_sort, Sort.bottom_up);


            //TASK 2
            Console.WriteLine("\n\nTASK2\n");

            elements_amount = 5;// amount of elements
            double progression_step = 3;//     t
            double start_element = 2;  //    a1
            double result = 1;

            result = start_element * RecursionCount(start_element + progression_step, progression_step, elements_amount);
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
            result = start_element * RecursionForDownCount(start_element/progression_step, progression_step, element_lim);
            Console.WriteLine("Написать функцию, возвращающую " +
    "произведение n \nэлементов геометрической прогрессии " +
    "чисел с первым элементом a1 и шагом t (an = an-1//t)." +
    "\n Шаг\t{0},\n начальный элемент\t{1}," +
    "\n граничное значение\t{2},\n " +
    "результат\t{3:f4}.", progression_step, start_element
    , element_lim, result);

        }
        static void ShowArray(int[] array_show)
        {
            int i;
            for (i = 0; i < array_show.Length; i++)
                Console.Write(" {0} ", array_show[i]);
            Console.Write("\n");
        }
        static void SortArray(int[] array, Sort sort_criterion)
        {
            switch(sort_criterion)
            {
                case Sort.bottom_up:
                    SortFromBottom(array);
                    break;
                case Sort.up_bottom:
                    SortFromUp(array);
                    break;
            }
        }
        static void IsSort(int[] array, Sort sort_criterion)
        {
            int i;
            bool flag=true;
            switch (sort_criterion)
            {
                case Sort.bottom_up:
                    for (i = 0; i < array.Length - 1; i++)
                        if (array[i + 1] < array[i])
                        {
                            flag = false;
                          break;
                        }
                    if (flag)
                        Console.WriteLine("Массив отсортирован по возростанию");
                    else
                        Console.WriteLine("Ошибка, массив не отсортирован по возростанию");
                    break;
                case Sort.up_bottom:
                    flag = true;
                    for (i = 0; i < array.Length - 1; i++)
                        if (array[i + 1] > array[i])
                        {
                            flag = false;
                            break;
                        }
                    if (flag)
                        Console.WriteLine("Массив отсортирован в порядке убывания");
                    else
                        Console.WriteLine("Ошибка, массив не отсортирован в порядке убывания");
                    break;
            }
        }
        static void SortFromBottom(int[] array)
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
    
            ShowArray(array);     
        }
        static void SortFromUp(int[] array)
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
            ShowArray(array);
        }
        static double RecursionCount(double current_element,double step,int counter)
        {
            double result = 1;
            if (counter > 1)
            {
                result=current_element*RecursionCount(current_element + step, step, counter - 1);
            }
            else
                return 1;
            return result;
        }
        static double RecursionForDownCount(double current_element, double step, double boarder)
        {
            double result = 1;
            if (current_element > boarder)
            {
                result = current_element * RecursionForDownCount(current_element/step, step, boarder);
            }
            else
                return 1;
            return result;
        }
    }
}
