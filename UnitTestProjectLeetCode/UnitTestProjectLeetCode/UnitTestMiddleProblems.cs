using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestProjectLeetCode
{
    [TestClass]
    public class UnitTestMiddleProblems
    {
        [TestMethod]
        public void TestMethodLongestIncreaseSubsequence()
        {
            var arr = new int[8] { 10, 9, 2, 5, 3, 7, 101, 18 };

            var actual = LengthOfLIS(arr);

            Assert.AreEqual(4, actual);
        }

        [TestMethod]
        public void TestMethodLongestIncreaseSubsequence1()
        {
            var arr = new int[6] { 4,10,4,3,8,9 };

            var actual = LengthOfLIS(arr);

            Assert.AreEqual(3, actual);
        }

        [TestMethod]
        public void TestMethodMaxProduct()
        {
            var arr = new int[4] { 2, 3, -2, 4 };

            var actual = MaxProduct(arr);

            Assert.AreEqual(6, actual);
        }

        [TestMethod]
        public void TestMethodMaxProduct1()
        {
            var arr = new int[1] { -10 };

            var actual = MaxProduct(arr);

            Assert.AreEqual(-10, actual);
        }

        [TestMethod]
        public void TestMethodMaxProduct2()
        {
            var arr = new int[3] { -10, 0, -10};

            var actual = MaxProduct(arr);

            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void TestMethodMaxProduct3()
        {
            var arr = new int[4] { -3, 0, 1,-2 };

            var actual = MaxProduct(arr);

            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void TestMethodLengthOfLongestSubstring()
        {
            var str = "abcabcbb";

            var actual = LengthOfLongestSubstring(str);

            Assert.AreEqual(3, actual);
        }

        [TestMethod]
        public void TestMethodLengthOfLongestSubstring1()
        {
            var str = "pwwkew";

            var actual = LengthOfLongestSubstring(str);

            Assert.AreEqual(3, actual);
        }

        [TestMethod]
        public void TestMethodLengthOfLongestSubstring2()
        {
            var str = "dvdf";

            var actual = LengthOfLongestSubstring(str);

            Assert.AreEqual(3, actual);
        }

        [TestMethod]
        public void TestMethodSearch()
        {
            var str = new int[7] {4,5,6,7,0,1,2};

            var actual = Search(str,0);

            Assert.AreEqual(4, actual);
        }

        [TestMethod]
        public void TestMethodKthSmallest()
        {
            var a = new int[3][];
            a[0] = new int[] { 1, 5, 9 };
            a[1] = new int[] { 10, 11, 13 };
            a[2] = new int[] { 12, 13, 15 };


            var actual = KthSmallest(a, 8);

            Assert.AreEqual(13, actual);
        }

        public int KthSmallest(int[][] a, int k)
        {
            
            var n = a[0].Length;
            int left = a[0][0];     // <= answer
            int right = a[n-1][n-1];   // >= answer

            // binary search
            while(left+1< right)
            {
                var mid = left + ((0u+left-right)>>1);

                int count = 0; // number of elements < mid
                var j = n;
                for(var i = 0; i < n&&j>0; i++)
                {
                    while (j - 1 >= 0 && a[i][j - 1] > mid)
                    {
                        j--;
                    }
                    count+=j;
                }
                if (count < k)
                {
                    left = (int)mid;
                }
                else
                {
                    right = (int)mid;
                }
            }

            return Convert.ToInt32(right);
        }

        public int Search(int[] a, int target)
        {
            if (a.Length == 0)
                return -1;
          
            var left = 0;
            var right = a.Length;
            
            // target could be in [left, right)

            while(left+1 < right)
            {
                var mid = (left + right) / 2;
                var sLeft = left;
                var sRight = mid;
                
            }
            if (a[left] == target)
                return left;

            return -1;
        }

        public int LengthOfLongestSubstring(string s)
        {
            var ans = 0;
            bool[] used = new bool[128];
            int after = 0;
            for (int first = 0; first < s.Length; first++)
            {
                while (after < s.Length && !used[s[after]])
                {
                    used[s[after]] = true;
                    after++;
                }
                ans = Math.Max(ans, after - first);
                used[s[first]] = false;
            }
            return ans;
            /*var ans = 0;

            for (int first = 0; first < s.Length; first++)
            {
                bool[] used = new bool[128];
                // для каждого символа в строке проверяем длину максимальной подстроки без дубликата
                for(int i =first; i < s.Length; i++)
                {
                    char c = s[i];
                    if (used[c])
                        break;
                    used[c] = true;
                    ans = Math.Max(ans,i-first+1);
                }
            }
            return ans;*/
        }

        public int MaxProduct(int[] nums)
        {
            var ans = int.MinValue;

            var product = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                if (product == 0)
                {
                    product = nums[i];
                }
                else
                {
                    product *= nums[i];
                }
                ans = Math.Max(product, ans);
            }

            product = 0;

            for (var i = nums.Length-1; i >= 0; i--)
            {
                if (product == 0)
                {
                    product = nums[i];
                }
                else
                {
                    product *= nums[i];
                }
                ans = Math.Max(product, ans);
            }

            return ans;
        }

        public int LengthOfLIS(int[] nums)
        {
            var tails = new int[nums.Length];

            int left = 0, size = 0;

            for(var i = 0; i < nums.Length; i++)
            {
                left = 0;
                int right = size;
                // бинарный поиск индекса куда вставить элемент, который должен поддерживать массив
                // минимальных упорядоченных элементов подпоследовательностей
                while (left != right)
                {
                    var mid = (left + right)/2;
                    if (tails[mid] < nums[i])
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid;
                    }
                }

                tails[left] = nums[i];
                
                if(left==size)
                    size++;
            }

            return size;
        }
    }
}
