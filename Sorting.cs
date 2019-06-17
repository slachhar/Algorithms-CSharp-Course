using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_DataStructure_Lib
{
    public class Sorting
    {
        public static void BubbleSort(int[] array)
        {
            for (int partindex = array.Length - 1; partindex > 0; partindex--)
            {
                for (int i = 0; i < partindex; i++)
                {
                    if (array[i] > array[i + 1])
                        Swap(array, i, i + 1);
                }
            }
        }

        public static void SelectionSort(int[] array)
        {
            for (int partindex = array.Length - 1; partindex > 0; partindex--)
            {
                int largest = 0;
                for (int i = 1; i < partindex; i++)
                {
                    if (array[largest] <= array[i + 1])
                    {
                        largest = i + 1;
                    }
                }
                Swap(array, largest, partindex);
            }
        }

        public static void InsertionSort(int[] array)
        {
            for (int partindex = 1; partindex < array.Length; partindex++)
            {
                int curUnsorted = array[partindex];
                int i = 0;
                for (i = partindex; i > 0 && curUnsorted < array[i - 1]; i--)
                {
                    array[i] = array[i - 1];
                }
                array[i] = curUnsorted;
            }
        }

        public static void ShellSort(int[] array)
        {
            int gap = 1;
            if (gap < array.Length / 3)
            {
                gap = 3 * gap + 1;
            }

            while (gap >= 1)
            {
                for (int i = 1; i < array.Length; i++)
                {
                    for (int j = i; j >= gap && array[j] < array[j - gap]; j -= gap)
                    {
                        Swap(array, j, j - gap);
                    }

                }
                gap /= 3;
            }
        }

        private static void Swap(int[] array, int i, int j)
        {
            if (i == j)
                return;

            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
