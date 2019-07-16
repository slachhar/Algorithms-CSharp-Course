using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Algorithms_DataStructure_Lib
{
    class Program
    {
        static void Main(string[] args)
        {
            Sorting.QuickSort(new int[] {44, 88,77,22,66,11,99,55,0,33 });
            
            Console.Read();
        }

        private static unsafe void IterateOver(int[] v)
        {
            fixed (int* b = v)
            {
                int* p = b;
                for (int i = 0; i < v.Length; i++)
                {
                    Console.WriteLine(*p);
                    p++;
                }
            }
        }

        static void ArrayTimeComplexity(object[] array)
        {
            //access by index O(1)
            Console.WriteLine(array[0]);

            int length = array.Length;
            object elementINeedToFind = new object();
            for (int i = 0; i < length; i++)
            {
                if (array[i] == elementINeedToFind)
                {
                    Console.WriteLine("Exists/Found");
                }
            }

            //add to a full array
            var bigArray = new int[length * 2];
            Array.Copy(array, bigArray, length);
            bigArray[length + 1] = 10;

            //add to the end when there's some space
            //O(1)
            array[length - 1] = 10;

            //O(1)
            array[6] = null;
        }

        private static void RemoveAt(object[] array, int index)
        {
            var newArray = new object[array.Length - 1];
        }

        static string TimeConversion(string s)
        {
            /*
             * Write your code here.
             */
            string[] date = s.Split(':');
            //12 AM : 00 constant 
            //12 PM : 12 same
            //01 AM : 01 same
            //01 PM : 13 addition
            //AM -> 12 : 00 , 01 : 01
            //PM -> 12 : 12 , 01 : 13

            string result = date[2].Substring(2, 2) == "AM" ? date[0] == "12" ? "00" : date[0] : date[0] == "12" ? "12" : (Convert.ToInt32(date[0]) + 12).ToString();


            return result;

        }

        private static long RecursiveFactorial(int n)
        {
            long factorial = n;
            if (n == 1)
            {
                return 1;
            }
            else
                return factorial *= RecursiveFactorial(n-1);
        }
    }
}
