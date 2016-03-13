using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Stack
{
    class Stack
    {
        // Public property
        public static int Top { get; set; } = -1;
        public static int Max { get; set; } = 10; // Just for the sake of assignemnt, I set 10 as max.

        // Just to hold the referece
        private static int[] _stack { get; set; } = new int[Max];
        
        // Sub-algorithms
        public static bool IsEmpty() { return _stack.Count() == 0; }
        public static int Peek() { return _stack[Top]; }
        public static bool IsFull() { return Top == 9; }

        public static void Push (int data)
        {
            if(!IsFull())
            {
                // Add the data and increment the Top variable.
                Top++;
                _stack[Top] = data;
            } else
            {
                // throw new Exception("Stack full.");
            }
        }

        public static int Pop ()
        {
            int temp = 0;

            // Check if empty
            if (!IsEmpty())
            {
                // Get the value
                temp = _stack[Top];

                // This is optional. Either do this, or leave this and use Top to check where the data is available. 
                _stack[Top] = 0;

                // Decrement the Top
                Top--;
            } else
            {
                // throw new Exception("Stack empty.");
            }

            return temp;
        }

        public static void Print()
        {
            if(IsEmpty())
            {
                Console.WriteLine("Stack empty.");
                return;
            }

            foreach (var item in _stack)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
        }
    }
}
