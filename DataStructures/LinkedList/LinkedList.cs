using System;
using System.Text;

namespace LinkedList
{
    public class LinkedList
    {
        private Node Head;
        public int Length { get; private set; } = 0;

        public LinkedList(int value)
        {
            Head = new Node(value);
            Length++;
        }

        public void Push(int value)
        {
            var node = new Node(value)
            {
                Next = Head
            };

            Head = node;
            Length++;
        }

        public void Append(int value)
        {
            Node node = Head;
            while (node.Next != null)
            {
                node = node.Next;
            }
            node.Next = new Node(value);
            Length++;
        }

        public void Delete(int value)
        {
            Node node = Head;
            if (node == null)
            {
                return;
            }

            if (node.Value.Equals(value))
            {
                if (node?.Next != null)
                {
                    Head = node.Next;
                    Length--;
                    return;
                }

                Head = null;
                Length = 0;
                return;
            }

            while (node.Next != null)
            {
                if (node.Next.Value.Equals(value))
                {
                    if (node.Next?.Next != null)
                    {
                        node.Next = node.Next.Next;
                        return;
                    }

                    node.Next = null;
                    return;
                }

                node = node.Next;
            }
            Length--;
        }

        public void InsertAfter(int valueToFind, int value)
        {
            Node node = Head;
            while (node != null)
            {
                if (node.Value.Equals(valueToFind))
                {
                    var aux = node.Next;
                    node.Next = new Node(value)
                    {
                        Next = aux
                    };
                    break;
                }

                node = node.Next;
            }
            Length++;
        }

        public void InsertAt(int index, int value)
        {
            if (index < 0)
            {
                throw new InvalidOperationException("Index should be positive");
            }

            if (index > Length)
            {
                throw new InvalidOperationException("Index do not exist");
            }

            if (Head == null && index != 0)
            {
                throw new InvalidOperationException("List is empty");
            }

            if (index == 0)
            {
                var temp = Head;
                Head = new Node(value)
                {
                    Next = temp
                };

                Length++;
                return;
            }

            Node node = Head;
            var i = 1;
            while (node.Next != null)
            {
                if (index == i)
                {
                    var temp = node.Next;
                    node.Next = new Node(value)
                    {
                        Next = temp
                    };

                    Length++;
                    return;
                }

                node = node.Next;
                i++;
            }

            if (index == i)
            {
                node.Next = new Node(value);
                Length++;
            }
            
        }

        public bool Exists(int value)
        {
            Node node = Head;
            if (node == null)
            {
                return false;
            }
            while (node != null)
            {
                if (value.Equals(node?.Value))
                {
                    return true;
                }
                node = node.Next;
            }

            return false;
        }

        public int Count()
        {
            Node node = Head;
            if (node == null)
            {
                return 0;
            }
            var count = 0;
            while (node != null)
            {
                node = node.Next;
                count++;
            }

            return count;
        }

        public void Clear()
        {
            Head = null;
            Length = 0;
        }

        public override string ToString()
        {
            Node node = Head;

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
        public int? Value { get; set; }

        public Node()
        {
            Next = null;
            Value = null;
        }

        public Node(int value)
        {
            Value = value;
        }
    }
}

