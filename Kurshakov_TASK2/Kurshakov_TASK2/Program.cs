using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurshakov_TASK2
{
    class Program
    {
        static void Main(string[] args)
        {
            //TASK1
            Console.WriteLine("TASK1");

            double result;
            int border = 5, elements_amount = 10, i;
            int[] array = new int[elements_amount];

            for (i = 0; i < elements_amount; i++)
            
                array[i] = i+1;
            
            result = (double)Matematic.Summ(array, border)/(elements_amount-border+1);
            Console.WriteLine("Awarage between {0} and {1} is {2}", border, elements_amount,result);
            Console.WriteLine();


            result = 0;
            int couple_counter = 4;

            result = Matematic.Pair_summ(couple_counter, elements_amount);
            Console.WriteLine("Summ of pair elemets between 0 and {0} is {1}", couple_counter, result);
            Console.WriteLine();


            result = 0;
            int left_lim = 4, rigth_lim=6;

            result = Matematic.Pair_summ_between_elements(left_lim, rigth_lim, elements_amount);
            Console.WriteLine("Summ of pair elemets between {0} and {1} is {2}", left_lim, rigth_lim, result);
            Console.WriteLine();



            //TASK2
            Console.WriteLine();
            Console.WriteLine("TASK2");

            elements_amount = 15;
            int buffer;
            int[] array_revers = new int[elements_amount];
            for (i = 0; i < elements_amount; i++)
            {
                array_revers[i] = i+1;
                Console.Write(" {0}",array_revers[i]);
            }
            Console.WriteLine();
            for (i = 0; i < (int)elements_amount / 2; i++)
            {
                buffer = array_revers[i];
                array_revers[i] = array_revers[elements_amount - i-1];
                array_revers[elements_amount - i-1] = buffer;
            }
            for (i = 0; i < elements_amount; i++)
            {
                Console.Write(" {0}", array_revers[i]);
            }
            Console.WriteLine();
            Console.WriteLine();


            int[] array_for_distance = new int[20];
            Random rand = new Random();
            for (i = 0; i < array_for_distance.Length; i++)
            {
              array_for_distance[i] = rand.Next(0, 10);
              Console.Write(" {0}", array_for_distance[i]);
            }
            Console.WriteLine();
            int max_element = array_for_distance.Max();
            int max_element_first_index= Array.IndexOf(array_for_distance, max_element);
            int max_element_last_index=0;
            for(i=max_element_first_index+1; i<array_for_distance.Length;i++)
            {
                if (array_for_distance[i] == max_element)
                    max_element_last_index = i;
            }
            Console.WriteLine("Max element is {0}. Distance {1}",max_element,Math.Abs(max_element_last_index-max_element_first_index));
            Console.WriteLine();



            //TASK3
            Console.WriteLine();
            Console.WriteLine("TASK3");

            int[,] matrix = new int[5, 5];
            int j;
            Random rand_new = new Random();
            for (i=0; i< matrix.GetLength(0);i++)
            {
                for (j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rand_new.Next(2, 10);
                    Console.Write("   {0}",matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (i = 0; i < matrix.GetLength(0); i++)
            {
                for (j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i < j)
                        matrix[i, j] = 1;
                    if (i > j)
                        matrix[i, j] = 0;
                    Console.Write("   {0}", matrix[i, j]);
                }
                Console.WriteLine();
            }




        }
    }
}
