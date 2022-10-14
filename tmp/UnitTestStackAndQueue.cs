using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLeetCodeProjects
{
    /// <summary>
    /// Summary description for UnitTestStackAndQueue
    /// </summary>
    [TestClass]
    public class UnitTestStackAndQueue
    {     
        [TestMethod]
        public void TestMethodWorkWithMyQueue()
        {
            MyCircularQueue obj = new MyCircularQueue(3);
            bool param_1 = obj.EnQueue(1);
            bool param_11 = obj.EnQueue(2);
            bool param_12 = obj.EnQueue(3);
            bool param_13 = obj.EnQueue(4);
            int param_4 = obj.Rear();
            bool param_full = obj.IsFull();

            bool param_2 = obj.DeQueue();
            bool param_21 = obj.EnQueue(4);
            int param_41 = obj.Rear();

            Assert.AreEqual(false, param_13);
            Assert.AreEqual(3, param_4);
            Assert.AreEqual(true, param_full);
            Assert.AreEqual(4, param_41);
        }

        [TestMethod]
        public void TestMethodOpenLock()
        {
            var strs = new string[] { "0201", "0101", "0102", "1212", "2002" };
            var target = "0202";

            var res = OpenLock(strs, target);

            Assert.AreEqual(6, res);
        }

        [TestMethod]
        public void TestMethodNumSquares()
        {
            var res = NumSquares(12);

            //Assert.AreEqual(3, res);
        }

        [TestMethod]
        public void TestMethodNumSquares1()
        {

            var res = NumSquares(13);

            Assert.AreEqual(2, res);
        }

        // можно ли при воз
        bool check(int n)
        {
            for (int i = 1; i * i <= n; ++i)
            {
                if (i * i == n)
                {
                    return true;
                }
            }
            return false;
        }

        int numSquaresReal(int n)
        {
            while (n % 4 == 0)
                n /= 4;
            if (n % 8 == 7)
                return 4;
            int a = -1;
            var b = (int)Math.Sqrt(Convert.ToDouble(n));
            n -= b * b;
            b += b + 1;
            while (a <= b)
            {
                if (n < 0)
                    n += b -= 2;
                else if (n > 0)
                    n -= a += 2;
                else
                    return a < 0 ? 1 : 2;
            }
            return 3;
        }

        int NumSquares(int n)
        {
            int sum = 0;
            for (int i = 0; i < 10000; i++)
                sum += numSquaresReal(n);
            return sum / 10000;
            /*
            var dp = new int[n + 1];
            for (int i = 1; i <= n; ++i)
            {
                if (check(i))
                {
                    dp[i] = 1;
                }
                else
                {
                    int min1 = i;

                    for (int j = 1; j * j <= i; ++j)
                    {
                        if (dp[j * j] + dp[i - j * j] < min1)
                        {
                            min1 = dp[j * j] + dp[i - j * j];
                        }
                    }
                    dp[i] = min1;
                }
            }
            return dp[n];*/
        }

        /*public int NumSquares(int n)
        {
            var q = new Dictionary<int, int>();
            var indx = 1;
            for (var i = 1; i*i <= n; i++)
            {
                q.Add(indx, i * i);
                indx++;
            }
            indx--;
            var sum = 0;
            var lvl = 0;
            while (indx!=0)
            {
                var a = q[indx];
                if (n % q[indx] == 0)
                {
                    lvl += n / q[indx];
                    return lvl;
                }
                else
                {
                    lvl += n / q[indx];
                    n = n % q[indx];
                }                

                indx--;
            }
            return lvl;
        }*/

        /* Aim  We are given a string start = "0000" and asked to reach 
         * target by turning (minimum times) a digit forward or backward 
         * one at a time without reaching any of the strings in deadends.
         */

        public int OpenLock(string[] deadends, string target)
        {
            var begin = new HashSet<string>();
            var end = new HashSet<string>();
            var deads = new HashSet<string>(deadends);
            begin.Add("0000");
            end.Add(target);
            int level = 0;
            HashSet<String> temp;
            while (begin.Count!=0 && end.Count!=0)
            {
                if (begin.Count > end.Count)
                {
                    temp = begin;
                    begin = end;
                    end = temp;
                }
                temp = new HashSet<string>();
                foreach (string s in begin)
                {
                    if (end.Contains(s)) return level;
                    if (deads.Contains(s)) continue;
                    deads.Add(s);
                    var sb = new StringBuilder(s);
                    for (int i = 0; i < 4; i++)
                    {
                        var c = s[i];
                        var s1 = s.Substring(0, i) + (c == '9' ? 0 : c - '0' + 1) + s.Substring(i + 1);
                        var s2 = s.Substring(0, i) + (c == '0' ? 9 : c - '0' - 1) + s.Substring(i + 1);

                        if (!deads.Contains(s1))
                            temp.Add(s1);

                        if (!deads.Contains(s2))
                            temp.Add(s2);
                    }
                }
                level++;
                begin = temp;
            }
            return -1;
        }



        public int NumIslands(char[][] grid)
        {
            // Store the given grid
            // This prevents having to make copies during recursion
            var g = grid;

           
            // Dimensions of the given graph
            var len = g.Length; // len of column
            var x = g[0].Length; // len of row

            if (len == 0) return 0;

            // Our count to return
            var cnt = 0;

            void dfs(int i, int j)
            {
                // Check for invalid indices and for sites that aren't land
                if (i < 0 || i >= len || j < 0 || j >= x || g[i][j] != '1') return;

                // Mark the site as visited
                g[i][j] = '0';

                // Check all adjacent sites
                dfs(i + 1, j);
                dfs(i - 1, j);
                dfs(i, j + 1);
                dfs(i, j - 1);
            }

            // Iterate over the entire given grid
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    if (g[i][j] == '1')
                    {
                        dfs(i, j);
                        cnt++;
                    }
                }
            }
            return cnt;
        }


        public class MyCircularQueue
        {
            // built-in array for storage elements
            int[] arr;
            
            // pointer on front element
            int front;

            // pointer on rear element
            int rear;

            int size;

            public MyCircularQueue(int k)
            {
                arr = new int[k];
                front = -1;
                rear = -1;
                size = k;
            }

            public bool EnQueue(int value)
            {
                if (IsFull()) return false;
                if (IsEmpty()) front = 0;
                
                rear = (rear + 1) % size;
                arr[rear] = value;
                return true;
            }

            public bool DeQueue()
            {
                if (IsEmpty())
                {
                    return false;
                }
                if (front == rear)
                {
                    front = -1;
                    rear = -1;
                    return true;
                }
                front = (front + 1) % size;
                return true;
            }

            public int Front()
            {
                if (IsEmpty()) return -1;

                return arr[front];
            }

            public int Rear()
            {
                if (IsEmpty()) return -1;

                return arr[rear];
            }

            public bool IsEmpty()
            {
                return front == -1;
            }

            public bool IsFull()
            {
                return ((rear + 1) % size) == front;
            }
        }
    }
}
