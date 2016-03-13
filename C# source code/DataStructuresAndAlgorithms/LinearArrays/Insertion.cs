using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.LinearArrays
{
    class Insertion
    {
        public static int[] Insert(int[] array, int index, int number)
        {
            // Create a new array of bigger size.
            int[] a = new int[array.Length + 1];

            // Temporarily store the value, save the value too.
            int temp = array[index];

            // Run the loops
            for (int i = 0; i < array.Length; i++)
            {
                if(i < index)
                {
                    // Add the previous data to the array.
                    a[i] = array[i];
                } else if(i == index)
                {
                    // Add the number
                    a[i] = number;
                    a[i + 1] = array[i];
                } else {
                    // Push the values downwards
                    a[i + 1] = array[i];
                }
            }
            return a;
        }
    }
}
