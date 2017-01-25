using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures
{
    public class CustomLinkedList<T>:IEnumerable<T>
    {
        public CustomNode<T> _head;
        public CustomNode<T> _tail;
        private int _counter = 0;

        public void Add(T value)
        {

            CustomNode<T> customNode = new CustomNode<T>();
            customNode.Value = value;

            if (_counter == 0)
            {
                _head = customNode;
                _tail = customNode;
                _counter++;
                return;
            }

            _tail.NextNode = customNode;
            _tail = customNode;
            _counter++;
        }

        internal void RemoveLast()
        {
            if (1 == _counter)
            {
                Console.WriteLine("Removing the last node value:" + _head.Value);
                _head = null; _tail = null;
                _counter--;
                return;
            }

            var tempNode = _head;
            while (tempNode.NextNode != _tail)
            {
                tempNode = tempNode.NextNode;
            }
            Console.WriteLine("Removing the last node value:" + tempNode.NextNode.Value);
            tempNode.NextNode = null;
            _tail = tempNode;
            PrintList();
            _counter--;
        }



        internal void RemoveFirst()
        {
            if (1 == _counter)
            {
                Console.WriteLine("Removing the only node value:" + _head.Value);
                _head = null; _tail = null;
                _counter--;
                return;
            }

            Console.WriteLine("Removing the first node value:" + _head.Value);
            _head = _head.NextNode;
            PrintList();
            _counter--;
        }


        public void Find(int value)
        {

        }

       

        public void PrintList()
        {
            var tempNode = _head;
            while (tempNode != null)
            {
                Console.WriteLine(tempNode.Value);
                tempNode = tempNode.NextNode;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            var tempNode = _head;
            while (null != tempNode)
            {
                yield return tempNode.Value;
                tempNode = tempNode.NextNode;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}