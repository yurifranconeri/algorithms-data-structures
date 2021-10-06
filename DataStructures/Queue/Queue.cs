using System;
using System.Text;

namespace Queue
{
    public class Queue
    {
        private Node Rear { get; set; }
        private Node Front { get; set; }

        public Queue()
        {

        }
        ///Front (dequeue) ------ Rear (Enqueue)
        public Queue(int value)
        {
            var node = new Node(value);
            Front = node;
            Rear = node;
        }

        public void Enqueue(int value)
        {
            var temp = Rear;
            Rear = new Node(value)
            {
                Next = temp
            };

            if (temp == null)
            {
                Front = Rear;
            }
        }

        public int Dequeue()
        {
            if (Front == null)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            var data = Front.Value;

            if (Front.Next == null)
            {
                Front = null;
                Rear = null;

                return data;
            }

            Front = Front.Next;
            return data;

        }

        public int Peek()
        {
            if (Front == null)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            return Front.Value;
        }

        public bool IsEmpty()
        {
            return (Front == null);
        }

        public int Count()
        {
            Node node = Rear;

            if (node == null)
            {
                return 0;
            }

            var count = 1;
            while (node.Next != null)
            {
                count++;
                node = node.Next;
            }

            return count;
        }

        public override string ToString()
        {
            Node node = Rear;
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
