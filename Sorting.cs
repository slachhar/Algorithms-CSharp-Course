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

        public static void MergeSort(int[] array)
        {
            int[] aux = new int[array.Length];

            Sort(0, array.Length - 1);

            void Sort(int low, int high)
            {
                if (high <= low)
                    return;

                int mid = (high + low) / 2;

                Sort(low, mid);
                Sort(mid + 1, high);
                Merge(low, mid, high);
            }

            void Merge(int low, int mid, int high)
            {
                if (array[mid] < array[mid + 1])
                    return;

                int i = low;
                int j = mid + 1;
                Array.Copy(array, low, aux, low, high - low + 1);

                for (int k = i; k <= high; k++)
                {
                    if (j < array.Length && j <= high && aux[i] > aux[j])
                    {
                        array[k] = aux[j++];
                    }
                    else
                        array[k] = aux[i++];
                }
            }
        }

        public static void QuickSort(int[] array)
        {
            int[] aux = new int[array.Length];
            int count = 0;
            Sort(0, 0, 1, array.Length);
            //Console.Read();

            void print(int[] arr, int start, int end)
            {
                for (int i = start; i < end; i++)
                {
                    Console.Write(arr[i] + "  ");
                }
                Console.WriteLine();
            }

            void Sort(int pivot, int swapPoint, int movingPoint, int arrayLength)
            {
                //Console.WriteLine(string.Format("{0} => {1},{2},{3}, {4}", count++, pivot, swapPoint, movingPoint, arrayLength));

                //Console.WriteLine("");
                //Console.Read();
                if (arrayLength <= 1 || swapPoint > movingPoint || movingPoint > array.Length)
                    return;


                int i = swapPoint;
                int j = movingPoint;

                for (int k = 0; k < arrayLength - 1 && i <= array.Length - 1 && j <= array.Length - 1; k++)
                {
                    if (array[pivot] > array[j])
                    {
                        if (i + 1 != j)
                        {
                            Swap(array, i + 1, j);
                        }
                        i += 1;
                    }
                    j += 1;
                }

                Swap(array, pivot, i);

                //Console.WriteLine("Going Left :");
                //print(array, pivot, i);

                Sort(pivot, swapPoint, movingPoint, i - swapPoint);

                //foreach (int num in array)
                //{
                //    Console.Write(num + ",");
                //}
                //Console.WriteLine(" ");

                //Console.WriteLine("Going Right :");
                //print(array, i + 1, arrayLength - i - 1);

                Sort(i + 1, i + 1, i + 2, array.Length - i - 1);

                //foreach (int num in array)
                //{
                //    Console.Write(num + ",");
                //}
                //Console.WriteLine(" ");
            }
        }
    }
}
