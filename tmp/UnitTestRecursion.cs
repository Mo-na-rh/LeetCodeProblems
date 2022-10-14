using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLeetCodeProjects
{
    [TestClass]
    public class UnitTestRecursion
    {

        [TestMethod]
        public void TestMethodMissingNumber()
        {
            var childRight = new TreeNode(3);
            var childLeft = new TreeNode(1);
            var left = new TreeNode(2, childLeft, childRight);
            var right = new TreeNode(7);
            var node = new TreeNode(4, left, right);

            var root = SearchBST(node, 2);

            Assert.AreEqual(1, root.left.val);
        }

        [TestMethod]
        public void TestMethodPascalTriangle()
        {
            var actual = GetRow(3);

            Assert.AreEqual(3, actual[1]);
        }

        [TestMethod]
        public void TestMethodFib()
        {
            var actual = Fib(12);

            Assert.AreEqual(144, actual);
        }

        [TestMethod]
        public void TestMethodFib1()
        {
            var actual = Fib(4);

            Assert.AreEqual(3, actual);
        }

        [TestMethod]
        public void TestMethodUniquePaths()
        {
            var actual = UniquePaths(3, 2);

            Assert.AreEqual(3, actual);
        }

        [TestMethod]
        public void TestMethodUniquePaths1()
        {
            var actual = UniquePaths(3, 7);

            Assert.AreEqual(28, actual);
        }

        [TestMethod]
        public void TestMethodUniquePaths2()
        {
            var actual = UniquePaths(1, 1);

            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void TestMethodUniquePaths3()
        {
            var actual = UniquePaths(2, 2);

            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        public void TestMethodNumDecodings()
        {
            var actual = NumDecodings("12");

            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        public void TestMethodNumDecodings1()
        {
            var actual = NumDecodings("226");

            Assert.AreEqual(3, actual);
        }

        [TestMethod]
        public void TestMethodNumDecodings2()
        {
            var actual = NumDecodings("06");

            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void TestMethodNumDecodings3()
        {
            var actual = NumDecodings("11106");

            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        public void TestMethodNumDecodings4()
        {
            var actual = NumDecodings("0000");

            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void TestMethodNumDecodings5()
        {
            var actual = NumDecodings("1000");

            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void TestMethodNumDecodings6()
        {
            var actual = NumDecodings("27");

            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void TestMethodNumDecodings7()
        {
            var actual = NumDecodings("2727");

            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void TestMethodNumDecodings8()
        {
            var actual = NumDecodings("272711");

            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        public void TestMethodClimbStairs()
        {
            var actual = ClimbStairs(3);

            Assert.AreEqual(3, actual);
        }

        [TestMethod]
        public void TestMethodClimbStairs1()
        {
            var actual = ClimbStairs(4);

            Assert.AreEqual(5, actual);
        }

        [TestMethod]
        public void TestMethodPow()
        {
            double expected = 0.25;
            var actual = MyPow(2, -2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodPow1()
        {
            double expected = 1024;
            var actual = MyPow(2, 10);

            Assert.AreEqual(expected, actual);
        }

        //0.00001
        //2147483647
        [TestMethod]
        public void TestMethodPow2()
        {
            double expected = 0;
            var actual = MyPow(2.00000, -2147483648);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodKthGrammar()
        {
            double expected = 1;
            var actual = KthGrammar(2, 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodKthGrammar1()
        {
            double expected = 0;
            var actual = KthGrammar(3, 4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodKthGrammar2()
        {
            double expected = 0;
            var actual = KthGrammar(4, 4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodGenerateTrees()
        {
            var actual = GenerateTrees(3);

            Assert.AreEqual(5, actual.Count);
        }

        [TestMethod]
        public void TestMethodInorderTraversal()
        {
            var childRight = new TreeNode(3);
            var childLeft = new TreeNode(1);
            var left = new TreeNode(2, childLeft, childRight);
            var right = new TreeNode(7);
            var node = new TreeNode(4, left, right);

            var res = InorderTraversal(node);

            Assert.AreEqual(7,res[4]);
        }

        [TestMethod]
        public void TestMethodPostorderTraversal()
        {
            var childRight = new TreeNode(3);
            var childLeft = new TreeNode(1);
            var left = new TreeNode(2, childLeft, childRight);
            var right = new TreeNode(7);
            var node = new TreeNode(4, left, right);

            var res = contPostOrder(node);

            Assert.AreEqual(4, res[4]);
        }

        [TestMethod]
        public void TestMethodLevelOrder()
        {
            var childRight = new TreeNode(3);
            var childLeft = new TreeNode(1);
            var left = new TreeNode(2, childLeft, childRight);
            var right = new TreeNode(7);
            var node = new TreeNode(4, left, right);

            var res = LevelOrder(node);

            Assert.AreEqual(3, res[2][1]);
        }

        [TestMethod]
        public void TestMethodCombinationSum4()
        {
            int[] nums = new int[3] { 1, 2, 3 };

            var actual = CombinationSum4(nums, 4);

            Assert.AreEqual(7, actual);
        }

        public int CombinationSum4(int[] nums, int target)
        {

            int?[] memo = new int?[target + 1];
            return recurse(nums, target, memo);
        }

        // recursion 
        public int recurse(int[] nums, int remain, int?[] memo)
        {
            // if remain less than zero
            if (remain < 0) return 0;

            if (memo[remain] != null)
                return memo[remain].GetValueOrDefault();


            if (remain == 0) return 1;

            int ans = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                ans += recurse(nums, remain - nums[i], memo);
            }

            memo[remain] = ans;
            return memo[remain].GetValueOrDefault(); ;
        }


        // Функция для вывода обхода заданного бинарного дерева по порядку уровней iteratively
        // Iterate approach
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            var res = new List<IList<int>>();

            if (root == null) return res;

            TreeNode curr_node = null;

            var q = new Queue<TreeNode>();

            q.Enqueue(root);

            while (q.Count > 0)
            {
                var tmp = new List<int>();
                int queue_size = q.Count;

                // цикл по уровню дерева
                for (int idx = 0; idx < queue_size; idx++)
                {
                    curr_node = q.Dequeue();
                    tmp.Add(curr_node.val);

                    if (curr_node.left != null) q.Enqueue(curr_node.left);
                    if (curr_node.right != null) q.Enqueue(curr_node.right);

                }

                res.Add(tmp);
            }

            return res;

        }

        static IList<int> contPostOrder(TreeNode root)
        {
            var res = new List<int>();

            if (root == null) return res;

            var stack = new Stack<TreeNode>();

            while (root != null || stack.Count>0)
            {
                // если стэк пуст пропускаем
                if (stack.Count > 0)
                {
                    root = stack.Pop();
                    if (stack.Count > 0 && root.right == stack.Peek())
                    {
                        root = stack.Pop();
                    }
                    else
                    {
                        res.Add(root.val);
                        root = null;
                    }
                }
                // цикл по дереву  идём по всем левым детям
                // также внутри цикла у текущего узла есть правый ребёнок его и его родителя фиксируем в стэке
                while (root != null)
                {
                    stack.Push(root);
                    if (root.right != null)
                    {
                        stack.Push(root.right);
                        stack.Push(root);
                    }
                    root = root.left;
                }
            }
            return res;
        }

        public IList<int> InorderTraversal(TreeNode root)
        {
            var res = new List<int>();

            if (root == null) return res;

            // Iterative approach
            // root указатель на текущий узел
            var stk = new Stack<TreeNode>();

            while (stk.Count > 0 || root != null)
            {
                if (root != null)
                {
                    stk.Push(root);
                    root = root.left;
                }
                else
                {
                    root = stk.Pop();
                    res.Add(root.val);
                    root = root.right;
                }
            }

            return res;
        }

        public IList<int> PreorderTraversal(TreeNode root)
        {
            var res = new List<int>();

            //Traversal(root, res);
            var stk = new Stack<TreeNode>();
            stk.Push(root);
            while (stk.Count > 0)
            {
                var cur = stk.Pop();
                res.Add(cur.val);

                if (cur.left != null)
                {
                    stk.Push(cur.left);
                }
                else if(cur.right != null)
                {
                    stk.Push(cur.right);
                }
            }

            return res;
        }

        // recursion pre-order
        public void Traversal(TreeNode root, IList<int> arr)
        {
            if (root == null) return;

            arr.Add(root.val);
            Traversal(root.left, arr);
            Traversal(root.right, arr);
        }

        public IList<TreeNode> GenerateTrees(int n)
        {
            // generate treeNodelist
            return generateTree(1, n);
        }

        // рекурсивное построение всех возможных бинарных деревьев поиска
        List<TreeNode> generateTree(int from, int to)
        {
            var ret = new List<TreeNode>();
            if (to < from)
                ret.Add(null);
            else if (to == from)
                ret.Add(new TreeNode(from));
            else if (to > from)
            {
                // цикл по всем возможным корням
                for (int i = from; i <= to; i++)
                {
                    // generate left subtree
                    var l = generateTree(from, i - 1);
                    // generate right subtree
                    var r = generateTree(i + 1, to);

                    for (int j = 0; j < l.Count; j++)
                    {
                        for (int k = 0; k < r.Count; k++)
                        {
                            // create node
                            var h = new TreeNode(i);
                            // left node
                            h.left = l[j];
                            // right node
                            h.right = r[k];

                            ret.Add(h);
                        }
                    }
                }
            }
            return ret;
        }


        public int KthGrammar(int n, int k)
        {
            // base case
            if (n == 1) return 0;

            // recurrent relation
            if (k % 2 == 0)
            {
                return KthGrammar(n - 1, k/2)==0 ? 1 : 0;
            }
            else
            {
                return KthGrammar(n - 1, (k + 1) / 2);
            }   
        }

        public double MyPow(double x, int n)
        {
            /*double res = 1;

            for (var i = 1; i <= Math.Abs(n); i++)
            {
                res*=x;
            }
            return (n < 0) ? 1/res : res;*/

            if (n == 0)
                return 1;
            if (n < 0)
            {
                n = -n;
                x = 1 / x;
            }
            var res= (n % 2 == 0) ? MyPow(x * x, n / 2) : x * MyPow(x * x, n / 2);
            return Double.IsInfinity(res) ? 0 : res;
        }

        public int ClimbStairs(int n)
        {
            // dynamic programming approach, easy and understandable
            /*var dp = new int[n+1];
            dp[0] = 1;
            dp[1] = 1;
            for (var i = 2; i <= n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }
            return dp[n];
            
             int[] dp = new int[n+1];
            if(n<=3)
            {
                return n;
            }
            dp[0] = 0;
            dp[1] = 1;
            dp[2] = 2;
            dp[3] = 3;
            for(int i=4;i<=n;i++)
            {
                 dp[i]= dp[i-2]+ dp[i-1];
            }
            return dp[n];
             */
            int[] mem = new int[n+1];
            return climbStairs(n, mem);
        }

        private int climbStairs(int n, int[] mem)
        {
            if (n <= 0) return 0;
            if (n == 1|| n == 2) return n;

            // если нашли в кэше вернём
            if (mem[n] != 0) return mem[n];

            var res = climbStairs(n-1, mem) + climbStairs(n - 2, mem);

            mem[n] = res;
            return res;
        }

        public int NumDecodings(string s)
        {
            int n = s.Length;
            int[] mem = new int[n];
            // рекурсивный обход от 0 до конца строки, если входная строка не пустая
            return n == 0 ? 0 : numDecodings(0, s, mem);
        }

        private int numDecodings(int p, String s, int[] mem)
        {
            int n = s.Length;

            // базовый случай если добрались до конца строки
            if (p == n) return 1;

            // если встрелся 0 то возвращаемое значение 0 т к такого кода нет
            if (s[p] == '0') return 0;

            // если нашли в кэше вернём
            if (mem[p] != 0) return mem[p];

            // чиитаем следующий символ 
            int res = numDecodings(p + 1, s, mem);

            // если s[p] входит в диапазон 1-26
            if (p < n - 1 && (s[p] == '1' || s[p] == '2' && s[p + 1] < '7'))
                res += numDecodings(p + 2, s, mem);
            return mem[p] = res;
        }

        public int UniquePaths(int m, int n)
        {
            if (m == 1 && n == 1) return 1;

            var cache = new int[m,n];

            int uPaths(int m1, int n1)
            {
                if (n1 < 0 || m1 < 0)
                    return 0;

                if (cache[m1,n1]!=0)
                    return cache[m1, n1];

                var res = 0;
                // base case
                if ((n1 == 0 && m1 == 1) || (n1 == 1 && m1 == 0))
                    res = 1;
                else
                    res = uPaths(m1 - 1, n1) + uPaths(m1, n1 - 1);

                cache[m1, n1] =  res;
                return res;
            }

            return uPaths(m - 1, n - 1);
        }



        public int Fib(int n)
        {
            var cache = new Dictionary<int, int>();

            int fib1(int n1)
            {
                if (cache.ContainsKey(n1)) return cache[n1];
                var res = 0;
                if (n1 < 2)
                {
                    res = n1;
                }
                else
                {
                    res = fib1(n1 - 1) + fib1(n1 - 2);
                }
                cache.Add(n1, res);
                return res;
            }

            return fib1(n);
        }

        public IList<int> GetRow(int rowIndex)
        {
            var result = new List<int>();
            result.Add(1);

            if (rowIndex == 0)
            {
                return result;
            }

            if (rowIndex == 1)
            {
                result.Add(1);
                return result;
            }

            IList<int> prev = GetRow(rowIndex - 1);

            for (int i = 1; i < rowIndex; i++)
            {
                int num = prev[i - 1] + prev[i];
                result.Add(num);
            }

            result.Add(1);

            return result;

            /*var A = new int[(rowIndex+1)];
            A[0] = 1;
            for (int i = 1; i < rowIndex + 1; i++)
                for (int j = i; j >= 1; j--)
                    A[j] += A[j - 1];
            return A;*/
            /*int f(int i, int j)
            {
                // base case
                if (j == 0 || j == i) return 1;
                // recursion
                return f(i - 1, j - 1) + f(i - 1, j);
            }

            var res = new int[rowIndex + 1];
            
            for(var j=0;j<= rowIndex; j++)
            {
                res[j] = f(rowIndex, j);
            }


            return res;*/
        }

        public TreeNode SearchBST(TreeNode root, int val)
        {
            if (root==null||root.val == val) return root;

            var left = SearchBST(root.left, val);
            if ( left == null)
                return SearchBST(root.right, val);
            else
                return left;

        }

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
    }
}
