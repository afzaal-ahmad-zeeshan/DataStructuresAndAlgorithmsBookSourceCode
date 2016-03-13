using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.LinearArrays
{
    class Sorting
    {
        public static int[] BubbleSort(int[] a)
        {
            // Sentinel
            bool sorted = false;

            while (!sorted)
            {
                // Maybe!
                sorted = true;

                // Run the test
                for (int i = 0; i < a.Length - 1; i++)
                {
                    if(a[i] > a[i + 1])
                    {
                        // Save
                        int temp = a[i];

                        // Interchange
                        a[i] = a[i + 1];
                        a[i + 1] = temp;

                        // Array is not sorted, run loop again.
                        sorted = false;
                    }
                }
            }

            return a;
        }

        // Function to be used with the Quick Sort algorithm.
        private static int Partition(int[] array, int left, int right)
        {
            int start = left;
            int pivot = array[start];
            left++;
            right--;

            while (true)
            {
                while (left <= right && array[left] <= pivot)
                    left++;

                while (left <= right && array[right] > pivot)
                    right--;

                if (left > right)
                {
                    array[start] = array[left - 1];
                    array[left - 1] = pivot;

                    return left;
                }


                int temp = array[left];
                array[left] = array[right];
                array[right] = temp;

            }
        }

        // Algorithm itself.
        public static void QuickSort(int[] a, int left, int right)
        {
            if (left < right)
            {
                int pivotIdx = Partition(a, left, right);

                QuickSort(a, left, pivotIdx - 1);
                QuickSort(a, pivotIdx, right);
            }
        }
    }
}
