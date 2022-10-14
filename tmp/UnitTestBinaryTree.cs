using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLeetCodeProjects
{
    [TestClass]
    public class UnitTestBinaryTree
    {
        [TestMethod]
        public void TestMethodHasPathSum()
        {
            var childRight = new TreeNode(3);
            var childLeft = new TreeNode(1);
            var root = new TreeNode(2, childLeft, childRight);

            var actual = HasPathSum(root, 5);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void TestMethodBuildTreeInPost()
        {
            int[] inorder = new int[5] { 9, 3, 15, 20, 7 };
            int[] postorder = new int[5] { 9, 15, 7, 20, 3 };

            var actual = BuildTreeInPost(inorder, postorder);

            Assert.AreEqual(9, actual.left.val);
        }

        [TestMethod]
        public void TestMethodBuildTreeInPost1()
        {
            int[] inorder = new int[2] { 2, 1 };
            int[] postorder = new int[2] { 2, 1 };

            var actual = BuildTreeInPost(inorder, postorder);

            Assert.AreEqual(2, actual.left.val);
        }

        [TestMethod]
        public void TestMethodBuildTreePreIn()
        {
            int[] preorder = new int[5] { 3, 9, 20, 15, 7 };
            int[] inorder = new int[5] { 9, 3, 15, 20, 7 };

            var actual = BuildTree(preorder, inorder);

            Assert.AreEqual(9, actual.left.val);
        }

        [TestMethod]
        public void TestMethodlevelOrder()
        {
            var childRight = new TreeNode(3);
            var childLeft = new TreeNode(1);
            var root = new TreeNode(2, childLeft, childRight);

            var actual = levelOrder(root);

            Assert.AreEqual(1, actual.Last()[0]);
        }

        [TestMethod]
        public void TestMethodConnect()
        {
            var childRight = new Node(3);
            var childLeft = new Node(1);
            var root = new Node(2);
            root.left = childLeft;
            root.right = childRight;
            

            var actual = Connect(root);

            Assert.AreEqual(2, actual.val);
        }

        [TestMethod]
        public void TestMethodLowestCommonAncestor()
        {
            var childRight = new TreeNode(1);
            var childLeft = new TreeNode(5);
            var root = new TreeNode(3);
            root.left = childLeft;
            root.right = childRight;

            var actual = LowestCommonAncestor(root,childLeft, childRight);

            Assert.AreEqual(3, actual.val);
        }

        [TestMethod]
        public void TestMethodSerialize()
        {
            var actual = serialize(null);

            Assert.AreEqual("", actual);

            var origin = deserialize(actual);

            Assert.AreEqual(null, origin);
        }

        [TestMethod]
        public void TestMethodSerialize1()
        {
            TreeNode childRight = new TreeNode(5);
            var childLeft = new TreeNode(1);
            var root = new TreeNode(3);

            root.left = childLeft;
            root.right = childRight;

            var actual = serialize(root);

            Assert.AreEqual("3,1,null,null,5,null,null", actual);

            var origin = deserialize(actual);

            Assert.AreEqual(5,origin.right.val);
        }

        [TestMethod]
        public void TestMethodSerialize2()
        {
            TreeNode childRight = null;
            var childLeft = new TreeNode(1);
            var root = new TreeNode(3);

            root.left = childLeft;
            root.right = childRight;

            var actual = serialize(root);

            Assert.AreEqual("3,1,null,null,null", actual);

            var origin = deserialize(actual);

            Assert.AreEqual(null, origin.right);
        }

        [TestMethod]
        public void TestMethodSerialize3()
        {
            var left = new TreeNode(4);
            var right = new TreeNode(5);
            var childRight = new TreeNode(3,left,right);
            var childLeft = new TreeNode(2);
            var root = new TreeNode(1,childLeft,childRight);

            var actual = serialize(root);

            Assert.AreEqual("1,2,null,null,3,4,null,null,5,null,null", actual);

            var origin = deserialize(actual);

            Assert.AreEqual(null, origin.left.left);
        }

        [TestMethod]
        public void TestMethodDeserialize()
        {
            var l = new TreeNode(6);
            var r = new TreeNode(7);
            var left = new TreeNode(4,l,r);
            var right = new TreeNode(5);
            var childRight = new TreeNode(3, left, right);
            var childLeft = new TreeNode(2);
            var root = new TreeNode(1, childLeft, childRight);

            var actual = serialize(root);

            Assert.AreEqual("1,2,null,null,3,4,6,null,null,7,null,null,5,null,null", actual);

            var origin = deserialize(actual);

            Assert.AreEqual(6, origin.right.left.left.val);
        }

        [TestMethod]
        public void TestMethodDeleteNode()
        {
            var rr = new TreeNode(7);
            var childRight = new TreeNode(6,null,rr);

            var r = new TreeNode(4);
            var l = new TreeNode(2);
            var childLeft = new TreeNode(3, l, r);

            var root = new TreeNode(5, childLeft, childRight);

            var actual = DeleteNode(root,3);

            Assert.AreEqual(6, actual.right.val);
        }


        [TestMethod]
        public void KeyDontExist_DELETE_ShouldReturnSameNode()
        {
            var rr = new TreeNode(7);
            var childRight = new TreeNode(6, null, rr);

            var r = new TreeNode(4);
            var l = new TreeNode(2);
            var childLeft = new TreeNode(3, l, r);

            var root = new TreeNode(5, childLeft, childRight);

            var actual = DeleteNode(root, 0);

            Assert.AreEqual(6, actual.right.val);
        }

        [TestMethod]
        public void TestMethodDeleteNode2()
        {
            var rr = new TreeNode(7);
            var childRight = new TreeNode(6, null, rr);

            var r = new TreeNode(4);
            var l = new TreeNode(2);
            var childLeft = new TreeNode(3, l, r);

            var root = new TreeNode(5, childLeft, childRight);

            var actual = DeleteNode(root, 5);

            Assert.AreEqual(6, actual.val);
            Assert.AreEqual(7, actual.right.val);
        }

        [TestMethod]
        public void TestMethodDeleteNode3()
        {
            var root = new TreeNode(5);

            var actual = DeleteNode(root, 5);

            Assert.AreEqual(null, actual);
        }

        [TestMethod]
        public void TestMethodDeleteNode4()
        {
            var rr = new TreeNode(8);
            var ll = new TreeNode(6);
            var childRight = new TreeNode(7, ll, rr);

            var r = new TreeNode(4);
            var childLeft = new TreeNode(3, null, r);

            var root = new TreeNode(5, childLeft, childRight);

            var actual = DeleteNode(root, 5);

            Assert.AreEqual(6, actual.val);
            Assert.AreEqual(null, actual.right.left);
        }

        [TestMethod]
        public void TestMethodDeleteNode5()
        {
            var childLeft = new TreeNode(1);

            var root = new TreeNode(2, childLeft);

            var actual = DeleteNode(root, 2);

            Assert.AreEqual(1, actual.val);
        }

        [TestMethod]
        public void TestMethodIsBalanced()
        {
            var childRight = new TreeNode(2);
            var childLeft = new TreeNode(1);

            var root = new TreeNode(2, childLeft, childRight);

            var actual = IsBalanced(root);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void TestMethodIsBalanced1()
        {

            var childRight = new TreeNode(2);
            var childLeft = new TreeNode(1, childRight);

            var root = new TreeNode(2, childLeft, null);

            var actual = IsBalanced(root);

            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void TestMethodIsBalanced2()
        {
            var left = new TreeNode(6);
            var childRight = new TreeNode(3, left, null);
            var ll = new TreeNode(8);
            var l = new TreeNode(4,ll);
            var r = new TreeNode(5);
            var childLeft = new TreeNode(2,l,r);
            var node = new TreeNode(1, childLeft, childRight);
            var act = serialize(node);

            var root = deserialize(act);

            var actual = IsBalanced(root);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void TestMethodIsBalanced3()
        {
            var l = new TreeNode(3);
            var childLeft = new TreeNode(2,null, l);

            var root = new TreeNode(1,null, childLeft);

            var actual = IsBalanced(root);

            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void TestMethodContainsNearbyAlmostDuplicate()
        {
            int[] nums = new int[4] { 1, 2, 3, 1 };

            var actual = ContainsNearbyAlmostDuplicate(nums, 3, 0);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void TestMethodContainsNearbyAlmostDuplicate1()
        {
            int[] nums = new int[6] { 1, 5, 9, 1, 5, 9 };

            var actual = ContainsNearbyAlmostDuplicate(nums, 2, 3);

            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void TestMethodContainsNearbyAlmostDuplicate2()
        {
            int[] nums = new int[7] { 1, 2, 5, 6, 7, 2, 4 };

            var actual = ContainsNearbyAlmostDuplicate(nums, 4, 0);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void TestMethodContainsNearbyAlmostDuplicate3()
        {
            int[] nums = new int[2] { -2147483648, 2147483647 };

            var actual = ContainsNearbyAlmostDuplicate(nums, 1, 1);

            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void TestMethodContainsNearbyAlmostDuplicate4()
        {
            int[] nums = new int[4] { 1, 3, 6, 2 };

            var actual = ContainsNearbyAlmostDuplicate(nums, 1, 2);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void TestMethodIsSameTree()
        {
            var left = new TreeNode(6);
            var childRight = new TreeNode(3, left);

            var ll = new TreeNode(6);
            var childLeft = new TreeNode(3, ll);

            var actual = IsSameTree(childRight, childLeft);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void TestMethodIsSameTree1()
        {
            var left = new TreeNode(5);
            var childRight = new TreeNode(3, left);

            var ll = new TreeNode(6);
            var childLeft = new TreeNode(3, ll);

            var actual = IsSameTree(childRight, childLeft);

            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void TestMethodMinDepth()
        {
            var childL = new TreeNode(1);
            var childLeft = new TreeNode(1,childL);

            var childRight = new TreeNode(1);

            var root = new TreeNode(2, childLeft, childRight);

            var actual = MinDepth(root);

            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        public void TestMethodMinDepth1()
        {
            var childL = new TreeNode(4);
            var childR = new TreeNode(5);
            var childLeft = new TreeNode(2, childL,childR);

            var childRight = new TreeNode(3);

            var root = new TreeNode(1, childLeft, childRight);

            var actual = MinDepth(root);

            Assert.AreEqual(2, actual);
        }

        
        [TestMethod]
        public void TestMethodIncreasingBST()
        {
            var childL = new TreeNode(3);
            var childR = new TreeNode(6);
            var root = new TreeNode(5, childL, childR);

            var actual = IncreasingBST(root);

            Assert.AreEqual(3, actual.val);
        }

        [TestMethod]
        public void TestMethodDiameterOfBinaryTree()
        {
            var l = new TreeNode(4);
            var r = new TreeNode(5);

            var childL = new TreeNode(2, l, r);
            var childR = new TreeNode(3);
            var root = new TreeNode(1, childL, childR);

            var actual = DiameterOfBinaryTree(root);

            Assert.AreEqual(3, actual);
        }

        [TestMethod]
        public void TestMethodDiameterOfBinaryTree1()
        {
            var childL = new TreeNode(2);
            var root = new TreeNode(1, childL);

            var actual = DiameterOfBinaryTree(root);

            Assert.AreEqual(1, actual);
        }

        public int DiameterOfBinaryTree(TreeNode root)
        {
            var max = 0;
            maxDepth(root,ref max);
            return max;
        }

        private int maxDepth(TreeNode root,ref int max)
        {
            if (root == null) return 0;

            int left = maxDepth(root.left,ref max);
            int right = maxDepth(root.right,ref max);

            max = Math.Max(max, left + right);

            return Math.Max(left, right) + 1;
        }

        public TreeNode IncreasingBST(TreeNode root)
        {
           var ans = new TreeNode();
           
           var lst =  InorderTraversal( root);

            for(var i = 0; i < lst.Count; i++)
            {
                ans.right = new TreeNode(lst[i]);
            }

            return ans.right;
        }

        IList<int> InorderTraversal(TreeNode root)
        {
            var ans = new List<int>();

            InOrderTraversal1(root, ans);

            return ans;
        }

        void InOrderTraversal1(TreeNode root, List<int> ans)
        {
            // base case 
            if (root == null)
                return;

            // recurrence relation
            InOrderTraversal1(root.left, ans);

            ans.Add( root.val);

            InOrderTraversal1(root.right, ans);
        }


    public int MinDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            else if (root.left == null && root.right != null)
            {
                return 1 + MinDepth(root.right);
            }
            else if (root.left != null && root.right == null)
            {
                return 1 + MinDepth(root.left);
            }
            else
            {
                return 1 + Math.Min(MinDepth(root.left), MinDepth(root.right));
            }
        }

        public int MinDepth1(TreeNode root)
        {
            if (root == null) return 0;
            var q = new Queue<TreeNode>();
            q.Enqueue(root);
            var cnt = 1;
            while (q.Count > 0)
            {
                var node = q.Dequeue();

                if (node.left == null && node.right == null)
                    return cnt;
                if (node.left != null)
                    q.Enqueue(node.left);
                if (node.right != null)
                    q.Enqueue(node.right);
                cnt++;
            }
            return cnt;
        }



        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null) return true;

            if ((p == null || q == null)||(p.val != q.val)) return false;

            return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        }

        public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t)
        {
            var set = new SortedList<int, int>(k);

            for (int left = 0, right = 0; right < nums.Length; right++)
            {
                if (right > k)
                {
                    set.Remove(nums[left++]); // remove leaving num value
                }

                var adding = nums[right];

                // if have duplicate in window in means diff = 0 and will work for any t
                if (set.ContainsKey(adding))
                {
                    return true;
                }

                set[adding] = right;

                var idx = set.IndexOfKey(adding); // get inserted number's index

                // check values diff with lesser value at previous index
                if (idx > 0 && (long)adding - set.Keys[idx - 1] <= t)
                {
                    return true;
                }

                // check values diff with greater value at next index
                if (idx < set.Count - 1 && (long)set.Keys[idx + 1] - adding <= t)
                {
                    return true;
                }
            }

            return false;
        }


        [TestMethod]
        public void CheckKthLargest()
        {
            var sortedSet = new SortedDictionary<int, int>();

            KthLargest kthLargest = new KthLargest(3, new int[] { 4, 5, 8, 2 });
            var r1 = kthLargest.add(3);   // return 4
            Assert.AreEqual(4, r1);

            var r2 = kthLargest.add(5);   // return 5
            Assert.AreEqual(5, r2);
            var r3 = kthLargest.add(10);  // return 5
            Assert.AreEqual(5, r3);
            var r4 = kthLargest.add(9);   // return 8
            var r5 = kthLargest.add(4);

            Assert.AreEqual(3, sortedSet[0]);
        }

        class KthLargest
        {
            private static int _k;
            private SortedDictionary<int, int> heap;

            public KthLargest(int k, int[] nums)
            {
                _k = k;
                heap = new SortedDictionary<int, int>();

                foreach (int num in nums)
                {
                    if (!heap.ContainsKey(num))
                        heap.Add(num, num);
                }

                while (heap.Count > k)
                {
                    heap.Remove(heap.Keys.First());
                }
            }

            public int add(int val)
            {
                heap.Add(val, val);
                if (heap.Count > _k)
                {
                    heap.Remove(heap.Keys.First());
                }

                return heap[heap.Keys.First()];
            }
        }

        public bool IsBalanced(TreeNode root)
        {
            if (root == null) return true;

            var lDepth = GetMaxDepth(root.left);

            var rDepth = GetMaxDepth(root.right);

            return (IsBalanced(root.left) && IsBalanced(root.right)) && (Math.Abs(lDepth - rDepth) <= 1);
        }

        int GetMaxDepth(TreeNode root)
        {
            if (root == null) return 0;

            var l = GetMaxDepth(root.left);
            var r = GetMaxDepth(root.right);

            return l > r ? ++l : ++r;
        }

        public TreeNode DeleteNode(TreeNode root, int key)
        {
            if (root == null)
                return root;

            if (root.val == key)
            {
                // first case if childs is null
                if (root.left == null && root.right == null)
                {
                    return null;
                }

                // second case  left child is not null
                if (root.left != null && root.right == null)
                {
                    return root.left;
                }

                // third case  right child is not null
                if (root.right != null && root.left == null) 
                {
                    return root.right;
                }

                // fourth case both of child is not null
                if (root.right.left == null)
                {
                    var res = root.right;
                    res.left = root.left;
                    return res;
                }

                var replace = GetRightLeast(root.right);
                replace.left = root.left;
                replace.right = root.right;

                return replace;

            }
            else
            {
                if (root.val > key)
                {
                    root.left = DeleteNode(root.left, key);
                }
                else
                {
                    root.right = DeleteNode(root.right, key);
                }
            }

            return root;  
        }

        TreeNode GetRightLeast(TreeNode root)
        {
            if (root.left == null) return root;

            var prev = root;
            var curr = root.left;

            while (curr.left != null)
            {
                prev = curr;
                curr = curr.left;
            }

            prev.left = curr.right;
            return curr;
        }

        // Binry search tree
        public TreeNode InsertIntoBST(TreeNode root, int val)
        {
            if (root == null)
                return new TreeNode(val);

            _insertInBST(root, val);
            return root;
        }

        void _insertInBST(TreeNode root, int val)
        {
            // base case
            if (root == null) return;

            if (val <= root.val)
            {
                if (root.left == null)
                {
                    root.left = new TreeNode(val);
                    return;
                }

                _insertInBST(root.left, val);
            }
            else
            {
                if (root.right == null)
                {
                    root.right = new TreeNode(val);
                    return;
                }
                _insertInBST(root.right, val);
            }
        }

        // Binary search tree

        // Encodes a tree to a single string.
        // serealize by level from left to right
        public string serialize(TreeNode root)
        {
            if (root == null) return string.Empty;

            var sb = new StringBuilder();
            PreOrderTraversal(root, sb);
            return sb.ToString().TrimEnd(',');
        }

        // recursive pre-order approach 
        void PreOrderTraversal(TreeNode root, StringBuilder sb)
        {
            if (root == null)
            {
                sb.Append("null");
                sb.Append(",");
                return;
            }

            sb.Append(root.val);
            sb.Append(",");
            PreOrderTraversal(root.left, sb);
            PreOrderTraversal(root.right, sb);
        }

        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data)
        {

            if (data == string.Empty) return null;

            var arr = data.Split(',');
            int.TryParse(arr[0], out var res);
            var i = -1;
            var root = CreateNode(arr, ref i);
            return root;
        }


        // Function to insert nodes in level order
        TreeNode CreateNode(string[] arr, ref int i)
        {
            i++;
            // base case  
            if (arr[i] == "null")
            {
                return null;
            }


            int.TryParse(arr[i], out var res);
            var root = new TreeNode(res);

            root.left = CreateNode(arr, ref i);

            root.right = CreateNode(arr, ref i);

            return root;
        }

        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        { 
            if (root == null || root == p || root == q) return root;

            var left = findLCA(root.left, p, q);
            var right = findLCA(root.right, p, q);
            var ans = root;
            if (left != right)
            {
                if (left)
                    ans = LowestCommonAncestor(root.left, p, q);
                else
                    ans = LowestCommonAncestor(root.right, p, q);
            }
            return ans;
        }

        bool findLCA(TreeNode root, TreeNode p, TreeNode q)
        {
            // base case
            if (root == null) return false;

            if (root.val == p.val || root.val == q.val)
                return true;

            return findLCA(root.left, p, q) || findLCA(root.right, p, q);
        }

        public Node Connect(Node root)
        {
            if (root == null) return root;

            Queue<Node> queue = new Queue<Node>();
            Stack<Node> stack = new Stack<Node>();

            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int ct = queue.Count;
                while (ct > 0)
                {
                    Node cur = queue.Dequeue();

                    stack.Push(cur);

                    if (cur.left != null)
                    {
                        queue.Enqueue(cur.left);
                    }
                    if (cur.right != null)
                    {
                        queue.Enqueue(cur.right);
                    }

                    ct--;
                }

                Node right = null;
                while (stack.Count > 0)
                {
                    Node top = stack.Pop();

                    top.next = right;
                    right = top;
                }
            }

            return root;
            /*if (root == null || root.left == null || root.right == null) return root;
            root.left.next = root.right;
            root.right.next = root.next != null ? root.next.left : null;
            Connect(root.left);
            Connect(root.right);
            return root;*/
            /*
            // base cases
            if (root == null) return root;
            if (root.left == null && root.right == null) return root;

            var treeBylvls = levelOrder(root);

            Node prev = null;
            foreach (var lvl in treeBylvls)
            {
                prev = null;
                foreach(var node in lvl)
                {
                    if (prev != null) prev.next = node;

                    prev = node;
                }
            }

            return root;*/
        }

        public List<List<Node>> levelOrder(Node root)
        {
            var ret = new List<List<Node>>();
            var q = new Queue<(Node, int)>();

            if (root == null)
                return ret;

            q.Enqueue((root, 1));

            while (q.Count > 0)
            {
                var el = q.Dequeue();

                if (ret.Count < el.Item2)
                {
                    ret.Add(new List<Node>());
                }

                ret.Last().Add(el.Item1);

                if (el.Item1.left != null)
                    q.Enqueue((el.Item1.left, el.Item2 + 1));
                if (el.Item1.right != null)
                    q.Enqueue((el.Item1.right, el.Item2 + 1));

            }
            return ret;
        }

        public List<List<int>> levelOrder(TreeNode root)
        {
            var ret = new List<List<int>>();
            var q = new Queue<(TreeNode, int)>();

            if (root==null)
                return ret;

            q.Enqueue((root, 1));

            while (q.Count>0)
            {
                var el = q.Dequeue();

                if (ret.Count < el.Item2)
                {
                    ret.Add(new List<int>());
                }

                ret.Last().Add(el.Item1.val);

                if (el.Item1.left!=null)
                    q.Enqueue(( el.Item1.left, el.Item2 + 1));
                if (el.Item1.right != null)
                    q.Enqueue((el.Item1.right, el.Item2 + 1));
                
            }
            return ret;
        }

        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            return helper(0, 0, inorder.Length - 1, preorder, inorder);
        }

        public TreeNode helper(int preStart, int inStart, int inEnd, int[] preorder, int[] inorder)
        {
            if (preStart > preorder.Length - 1 || inStart > inEnd)
            {
                return null;
            }
            TreeNode root = new TreeNode(preorder[preStart]);
            int inIndex = 0; // Index of current root in inorder
            for (int i = inStart; i <= inEnd; i++)
            {
                if (inorder[i] == root.val)
                {
                    inIndex = i;
                }
            }
            root.left = helper(preStart + 1, inStart, inIndex - 1, preorder, inorder);
            root.right = helper(preStart + inIndex - inStart + 1, inIndex + 1, inEnd, preorder, inorder);
            return root;
        }

        public TreeNode BuildTreeInPost(int[] inorder, int[] postorder)
        {
            if (inorder.Length == 0) return null;
            if (inorder.Length == 1) return new TreeNode(inorder[0]);

            var last = inorder.Length - 1;

            // root value of tree that must be built 
            var rootVal = postorder[last];
            var root = new TreeNode(rootVal);

            var rootIndx = Array.IndexOf(inorder, rootVal);

            // initialize arrays
            var leftInOrder = new int[rootIndx];
            var leftPostOrder = new int[rootIndx];
            for (var i = 0; i < rootIndx; i++)
            {
                leftInOrder[i] = inorder[i];
                leftPostOrder[i] = postorder[i];
            }

            var rightInOrder = new int[last - rootIndx];
            var rightPostOrder = new int[last - rootIndx];
            for (var i = 0; i < last - rootIndx; i++)
            {
                rightInOrder[i] = inorder[i + rootIndx + 1];
                rightPostOrder[i] = postorder[i + rootIndx];
            }

            root.left = BuildTreeInPost(leftInOrder, leftPostOrder);
            root.right = BuildTreeInPost(rightInOrder, rightPostOrder);

            return root;
        }

        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null) return false;

            targetSum = targetSum - root.val;
            if (targetSum == 0 && root.left == null && root.right == null) return true;

            return HasPathSum(root.left,targetSum) || HasPathSum(root.right, targetSum);
        }



        /*public IList<int> InorderTraversal(TreeNode root)
        {
            var ans = new Stack<int>();

            var res = InOrderTraversal1(null, root);

            return res;
        }

        bool InOrderTraversal1(TreeNode prev, TreeNode root)
        {
            // base case 
            if (root == null)
            {
                return true;
            }

            
            // recurrence relation
            InOrderTraversal1(root, root.left);

            if (prev.val < root.val)
                return false;

            InOrderTraversal1(root.right, stk);
        }*/

        // Utilities
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

        public class Node
        {
            public int val;
            public Node left;
            public Node right;
            public Node next;

            public Node() { }

            public Node(int _val)
            {
                val = _val;
            }

            public Node(int _val, Node _left, Node _right, Node _next)
            {
                val = _val;
                left = _left;
                right = _right;
                next = _next;
            }
        }

        public class ExamRoom
        {
            bool[] _seats;

            public ExamRoom(int n)
            {
                _seats = new bool[n];
            }

            public int Seat()
            {
                return 0;
            }

            public void Leave(int p)
            {

            }
        }
    }
}
