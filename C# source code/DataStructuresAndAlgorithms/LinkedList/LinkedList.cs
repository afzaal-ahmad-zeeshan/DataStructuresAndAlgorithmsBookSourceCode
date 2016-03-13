using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.LinkedList
{
    class LinkedList<T>
    {
        // The first one
        public Node<T> Head { get; set; } = null;
        public Node<T> Tail { get; set; } = null;

        private int Count = 0;

        public LinkedList()
        {
        }

        public void Add(Node<T> node)
        {
            if(Count == 0)
            {
                // First item
                Head = node;
                Tail = node;
            } else if(Count == 1)
            {
                // Just a single item
                Head.Next = node;
                Tail = node;
            } else
            {
                // Add to the end
                var current = Head;
                while (current.Next != Tail)
                {
                    // Select the next
                    current = current.Next;
                }

                // Now, attach the item.
                var temp = Tail;
                temp.Next = node;
                Tail = node;
            }

            // Increment the coutner.
            Count++;
        }

        public void Remove()
        {
            if(Count == 1)
            {
                // If there is only one element, remove it.
                Head = null;
                Tail = null;
            } else
            {
                var current = Head;
                while(current.Next != Tail)
                {
                    current = current.Next;
                }

                current.Next = null;
                Tail = current;
            }

            Count--;
        }

        public void Print()
        {
            if(Head != null)
            {
                // Print the head
                Console.WriteLine(Head);

                // Continue.
                Node<T> node = Head.Next;

                // Iterate
                while (node != null)
                {
                    Console.WriteLine(node.ToString());
                    node = node.Next;
                }
            }
        }
    }

    // Create the Node class
    class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }

        // Constructor
        public Node(T data)
        {
            Data = data;
            Next = null;
        }

        public override string ToString()
        {
            string exists = Next == null ? "Doesn't exist" : "Exists";
            return $"{{ '{Data}', {exists} }}";
        }
    }
}
