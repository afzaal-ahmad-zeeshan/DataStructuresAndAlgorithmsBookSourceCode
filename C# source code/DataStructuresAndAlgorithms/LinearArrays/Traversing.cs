using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.LinearArrays
{
    class Traversing
    {
        public static int Search(int[] array, int number)
        {
            // Initially
            int location = -1;

            // Run the loop
            for (int i = 0; i < array.Length; i++)
            {
                // If the number is found
                if(array[i] == number)
                {
                    location = i;
                    break;
                }
            }

            // Return the location
            return location;
        }

        public static int BinarySearch(int[] array, int number)
        {
            // Initially
            int location = -1;
            int start = 0;
            int end = array.Length;

            // Start the loop
            while (start <= end)
            {
                int mid = (start + ((start + end) / 2));

                // If number is found
                if(array[mid] == number)
                {
                    location = mid;
                    break;
                } else
                {
                    // Otherwise
                    if(array[number] > number)
                    {
                        end = mid - 1;
                    } else
                    {
                        start = mid + 1;
                    }
                }
            }

            return location;
        }

        public static int Count(int[] array, int number)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                // If the element in the array is larger than the number asked
                if(array[i] > number)
                {
                    // Increase the counter
                    count++;
                }
            }

            // Return the value
            return count;
        }
    }
}
