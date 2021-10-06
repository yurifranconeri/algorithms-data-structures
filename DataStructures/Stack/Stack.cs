using System;
using System.Text;

namespace Stack
{
    public class Stack
    {
        private Node Head;

        public Stack()
        {

        }

        public Stack(int value)
        {
            Head = new Node(value);
        }

        public void Push(int value)
        {
            var temp = Head;
            Head = new Node(value)
            {
                Next = temp
            };
        }

        public int Pop()
        {
            if (Head == null)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            var valueToReturn = Head.Value;
            Head = Head?.Next;

            return valueToReturn;
        }

        public int Peek()
        {
            if (Head == null)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return Head.Value;
        }

        public void Clear()
        {
            Head = null;
        }

        public bool IsEmpty()
        {
            return Head == null;
        }

        public override string ToString()
        {
            var node = Head;
            var sb = new StringBuilder();
            while (node != null)
            {
                sb.Append(node.Value);
                sb.Append(' ');
                node = node.Next;
            }
            return sb.ToString();
        }
    }

    internal class Node
    {
        public Node Next { get; set; }
        public int Value { get; set; }

        public Node(int value)
        {
            Value = value;
        }
    }
}
