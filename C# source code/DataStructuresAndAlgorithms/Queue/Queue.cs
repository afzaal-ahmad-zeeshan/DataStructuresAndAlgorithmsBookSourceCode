using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Queue
{
    class Queue
    {
        private static int _min { get; set; } = 0;
        private static int _max { get; set; } = 10;

        private static int _front { get; set; } = _max - 1;
        private static int _rear { get; set; } = _front;

        private static int[] _queue { get; set; } = new int[_max]; // Create the array

        // Function
        public static int Peek() { return _queue[_front]; } // Get the value
        public static bool IsFull() { return (_rear == _min); } // Just check rear, because we don't move front part at all.
        public static bool IsEmpty() { return (_front == _rear); }


        /* "Enqueue function"
         * One thing to note here, we implemented the data structure in a way
         * that our front is fixed to the maximum index, but rear moves up and
         * down to ensure we have to process just one end. 
         */
        public static void Enqueue(int data)
        {
            if(IsFull())
            {
                // throw new Exception("Queue is full.");
                return;
            }

            // If initial
            if(IsEmpty())
            {
                _front = _max - 1;

                // Enter the data
                _queue[_front] = data;
            } else
            {
                // Add data to the rear
                _queue[_rear] = data;
            }
            _rear--;
        }

        public static int Dequeue()
        {   
            // There is no item, if the queue is empty.
            if(IsEmpty())
            {
                // throw new Exception("Queue is empty.");
                return 0;
            }

            // Fetch the item
            int item = _queue[_front];
            moveUpwards(); // Clear the queue from top.

            // Return the value.
            return item;
        }

        private static void moveUpwards()
        {
            for (int i = _max - 1; i > 1; i--)
            {
                // Push the previous item to next location in array; linear array.
                _queue[i] = _queue[i - 1];
            }
        }

        public static void Print()
        {
            foreach (var item in _queue)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
        }
    }
}
