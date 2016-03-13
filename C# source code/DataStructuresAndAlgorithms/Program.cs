using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataStructuresAndAlgorithms.LinkedList;

namespace DataStructuresAndAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the list
            var list = new LinkedList.LinkedList<int>();
            list.Add(new Node<int>(63));
            list.Add(new Node<int>(553));
            list.Add(new Node<int>(89));
            list.Add(new Node<int>(34));
            list.Add(new Node<int>(65));

            list.Print();

            Console.WriteLine();
            Console.WriteLine("Removing the element: ");
            Console.WriteLine("List now is: ");
            list.Remove();

            list.Print();

            Console.Read();
        }

        private static void print(int[] a)
        {
            foreach (var item in a)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
