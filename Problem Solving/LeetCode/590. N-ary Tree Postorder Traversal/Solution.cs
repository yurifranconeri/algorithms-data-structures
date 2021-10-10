using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            var node6 = new Node(5);
            var node5 = new Node(6);
            var node3List = new List<Node>();
            node3List.Add(node6);
            node3List.Add(node5);
            var node3 = new Node(3, node3List);
            var node2 = new Node(2);
            var node4 = new Node(4);
            var node1List = new List<Node>();
            node1List.Add(node3);
            node1List.Add(node2);
            node1List.Add(node4);
            var node = new Node(1, node1List);
            var result = PostOrder(node);
        }

        public static IList<int> PostOrder(Node root)
        {
            var list = new List<int>();
            if (root == null)
            {
                return list;
            }

            PostOrder(list, root);

            return list;
        }

        public static void PostOrder(List<int> list, Node node)
        {
            if (node == null)
            {
                return;
            }

            if (node.children != null)
            {
                foreach (var item in node.children)
                {
                    PostOrder(list, item);
                }
            }

            list.Add(node.val);
        }

    }

    public static IList<int> PostOrderIteratively(Node root)
        {
            var list = new LinkedList<int>();
            
            if (root == null)
            {
                return list.ToList();
            }
            var stack = new Stack<Node>();
            stack.Push(root);
            while (stack.Count > 0)
            {
                var item = stack.Pop();
                list.AddFirst(item.val);
                if(item.children != null)
                {
                    foreach (var child in item.children)
                    {
                        stack.Push(child);
                    }
                }
                
            }

            return list.ToList();
        }


    // Definition for a Node.
    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }
}
