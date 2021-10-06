using System;
using System.Collections.Generic;

namespace BinaryTree
{
    public class BinaryTree
    {
        private Node Root;

        public BinaryTree()
        {
        }

        public BinaryTree(int value)
        {
            Root = new Node(value);
        }


        public bool IsFull()
        {
            throw new NotImplementedException();
        }

        public bool IsComplete()
        {
            throw new NotImplementedException();
        }

        public bool IsPerfect()
        {
            throw new NotImplementedException();
        }

        public bool IsBalanced()
        {
            throw new NotImplementedException();
        }

        public List<int> InOrderList()
        {
            var node = Root;
            if (node == null)
            {
                return new List<int>();
            }

            var result = new List<int>();
            InOrder(Root, result);
            return result;
        }

        private void InOrder(Node node, List<int> result)
        {
            if (node == null)
            {
                return;
            }

            InOrder(node.Left, result);
            result.Add(node.Value);
            InOrder(node.Right, result);
        }

        public List<int> PreOrderList()
        {
            var node = Root;
            if (node == null)
            {
                return new List<int>();
            }

            var result = new List<int>();
            PreOrder(Root, result);
            return result;
        }

        private void PreOrder(Node node, List<int> result)
        {
            if (node == null)
            {
                return;
            }

            result.Add(node.Value);
            PreOrder(node.Left, result);
            PreOrder(node.Right, result);
        }

        public List<int> PostOrderList()
        {
            var node = Root;
            if (node == null)
            {
                return new List<int>();
            }

            var result = new List<int>();
            PostOrder(Root, result);
            return result;
        }

        private void PostOrder(Node node, List<int> result)
        {
            if (node == null)
            {
                return;
            }

            PostOrder(node.Left, result);
            PostOrder(node.Right, result);
            result.Add(node.Value);
        }

        public List<int> BreadthFirstList()
        {
            var node = Root;
            if (node == null)
            {
                return new List<int>();
            }

            var heigth = Height(Root);
            var result = new List<int>();
            for (int i = 0; i <= heigth; i++)
            {
                BreadthFirst(Root, result, i);
            }

            return result;
        }

        private void BreadthFirst(Node node, List<int> result, int level)
        {
            if (node == null)
            {
                return;
            }

            if (level == 1)
            {
                result.Add(node.Value);
                return;
            }

            BreadthFirst(node.Left, result, --level);
            BreadthFirst(node.Right, result, --level);
        }

        public void Insert(int value)
        {
            if (Root == null)
            {
                Root = new Node(value);
                return;
            }

            var node = Root;
            var queue = new Queue<Node>();
            queue.Enqueue(node);

            while (queue.Count != 0)
            {
                node = queue.Dequeue();

                if (node.Left == null)
                {
                    node.Left = new Node(value);
                    return;
                }

                queue.Enqueue(node.Left);

                if (node.Right == null)
                {
                    node.Right = new Node(value);
                    return;
                }

                queue.Enqueue(node.Right);

            }

        }

        public void Delete(int value)
        {
            if (Root == null)
            {
                return;
            }

            var node = Root;
            var queue = new Queue<Node>();
            queue.Enqueue(node);

            while (queue.Count != 0)
            {
                node = queue.Dequeue();

                if (node.Value == value)
                {
                    node = null;
                }

                queue.Enqueue(node.Left);

                if (node.Right == null)
                {
                    node.Right = new Node(value);
                    return;
                }

                queue.Enqueue(node.Right);

            }

        }

        public int Count()
        {
            return CountAll(Root);
        }

        public int CountAll(Node node)
        {
            if (node == null)
            {
                return 0;
            }

            var count = 0;
            if (node.Left != null)
            {
                count++;
            }

            if (node.Right != null)
            {
                count++;
            }

            count += (CountAll(node.Left) + CountAll(node.Right));

            return count;
        }

        public int Height(Node node)
        {
            if (node == null)
            {
                return 0;
            }

            int leftHeight = Height(node.Left);
            int rigthHeight = Height(node.Right);

            return (leftHeight > rigthHeight) ? leftHeight + 1 : rigthHeight + 1;

        }

        public override string ToString()
        {
            return string.Join(' ', InOrderList());
        }

        public string ToStringInOrder()
        {
            return string.Join(' ', InOrderList());
        }

        public string ToStringPostOrder()
        {
            return string.Join(' ', PostOrderList());
        }

        public string ToStringBreadthFirst()
        {
            return string.Join(' ', BreadthFirstList());
        }


        public string ToStringPreOrder()
        {
            return string.Join(' ', PreOrderList());
        }

    }

    public class Node
    {
        public Node Left { get; set; }
        public Node Right { get; set; }
        public int Value { get; }

        public Node(int value)
        {
            Value = value;
        }

    }
}
