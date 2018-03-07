using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurshakov_TASK2
{
    class Matematic
    {
        public static int Summ(int[] array, int rigth_lim)
        {
            int i, summ = 0;
            for (i = rigth_lim - 1; i < array.Length; i++)
                summ = summ + array[i];
            return summ;
        }
        public static int Pair_summ(int rigth_lim, int elements_amount)
        {
            int i, summ = 0;
            int[] array = new int[elements_amount];

            for (i = 0; i < elements_amount; i++)
                array[i] = i;

            i = 0;
            while (i < rigth_lim + 1)
            {
                summ = summ + array[i];
                i += 2;
            }
            return summ;
        }
        public static int Pair_summ_between_elements(int left_lim, int rigth_lim, int elements_amount)
        {
            int i, summ = 0;
        int[] array = new int[elements_amount];

            for (i = 0; i<elements_amount; i++)
            {
            array[i] = i;
                if ((array[i] % 2 == 0) && (array[i] >= left_lim) && (array[i] <= rigth_lim))
                    summ = summ + array[i];
            }
            return summ;
            
        }
    }
}
