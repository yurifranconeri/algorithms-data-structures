using System;
using System.Collections.Generic;

namespace Program
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            var rigth = new TreeNode(2, new TreeNode(3));
            var root = new TreeNode(1, null, rigth);
            var result = InorderTraversal(root);
        }

        public static IList<int> InorderTraversal(TreeNode root)
        {
            var list = new List<int>();
            if (root == null)
            {
                return new List<int>();
            }

            InOrder(list, root);

            return list;
        }

        private static void InOrder(List<int> list, TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            InOrder(list, node.left);
            list.Add(node.val);
            InOrder(list, node.right);
        }

        public static IList<int> InOrderTraversalIteratively(TreeNode root)
        {
            var list = new List<int>();
            if (root == null)
            {
                return new List<int>();
            }
            var temp = root;
            var stack = new Stack<TreeNode>();

            while (temp != null || stack.Count > 0)
            {
                while (temp != null)
                {
                    stack.Push(temp);
                    temp = temp.left;
                }

                temp = stack.Pop();
                list.Add(temp.val);
                temp = temp.right;
            }

            return list.ToList();
        }

    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

}

