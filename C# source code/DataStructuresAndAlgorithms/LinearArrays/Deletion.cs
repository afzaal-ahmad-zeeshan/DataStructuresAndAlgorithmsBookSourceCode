using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.LinearArrays
{
    class Deletion
    {
        public static int[] Delete(int[] array, int index)
        {
            // New array
            int[] b = new int[array.Length - 1];

            for (int i = 0; i < array.Length - 1; i++)
            {
                if(i < index)
                {
                    b[i] = array[i];
                }
                else
                {
                    b[i] = array[i + 1];
                }
            }

            return b;
        }
    }
}
