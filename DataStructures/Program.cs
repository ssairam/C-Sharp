using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{

    /// <summary>
    /// Implement Queue using LinkedList and an array
    /// A Queue follows FIFO
    /// Adding and removing a queue is enqueue and dequeue
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            EnumerateList();
        }


        static void EnumerateList()
        {
            CustomLinkedList<int> cll = AddList();
            foreach (var node in cll)
            {
                Console.WriteLine(node);
            }
        }



        static void TestRemoveLast()
        {
            CustomLinkedList<int> cll = AddList();
            Console.WriteLine("---------First Time Printing-----------");
            cll.PrintList();

            cll.RemoveLast();
            cll.RemoveLast();
            cll.RemoveLast();

            Console.WriteLine("---------Second Time Printing-----------");
            cll.PrintList();
        }

        private static CustomLinkedList<int> AddList()
        {
            CustomLinkedList<int> cll = new CustomLinkedList<int>();
            cll.Add(1);
            cll.Add(2);
            cll.Add(3);
            return cll;
        }

        static void TestRemoveFirst()
        {
            CustomLinkedList<int> cll = AddList();
            Console.WriteLine("---------First Time Printing-----------");
            cll.PrintList();

            cll.RemoveFirst();
            cll.RemoveFirst();
            cll.RemoveFirst();

            Console.WriteLine("---------Second Time Printing-----------");
            cll.PrintList();
        }



        static void CSharpImplementation()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());
        }
    }   
}
