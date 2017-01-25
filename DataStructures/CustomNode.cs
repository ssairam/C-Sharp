using System;

namespace DataStructures
{
    public class CustomNode<T>
    {
        public T Value { get; set; }
        public CustomNode<T> NextNode { get; set; }       
    }
}