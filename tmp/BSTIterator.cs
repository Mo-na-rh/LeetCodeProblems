using System.Collections.Generic;

namespace UnitTestLeetCodeProjects
{
    public class BSTIterator
    {
        Stack<TreeNode> stack;

        public BSTIterator(TreeNode root)
        {
            stack = new Stack<TreeNode>();
            stack.Push(root);
            pushLeft(root, stack);
        }

        void pushLeft(TreeNode root, Stack<TreeNode> stk)
        {
            TreeNode temp = root;
            while (temp.left != null)
            {
                stack.Push(temp.left);
                temp = temp.left;
            }
        }

        public int next()
        {
            TreeNode curr = stack.Pop();
            if (curr.right != null)
            {
                stack.Push(curr.right);
                pushLeft(curr.right, stack);
            }
            return curr.val;
        }

        public bool hasNext()
        {
            return stack.Count > 0;
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
