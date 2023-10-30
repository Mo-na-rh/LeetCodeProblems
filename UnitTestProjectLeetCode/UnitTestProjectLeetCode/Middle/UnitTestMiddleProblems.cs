using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            var arr = new int[6] { 4, 10, 4, 3, 8, 9 };

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
            var arr = new int[3] { -10, 0, -10 };

            var actual = MaxProduct(arr);

            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void TestMethodMaxProduct3()
        {
            var arr = new int[4] { -3, 0, 1, -2 };

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
            var str = new int[7] { 4, 5, 6, 7, 0, 1, 2 };

            // var actual = Search(str,0);

            //Assert.AreEqual(4, actual);
        }

        [TestMethod]
        public void TestMethodKthSmallest()
        {
            var a = new int[3][];
            a[0] = new int[] { 1, 5, 9 };
            a[1] = new int[] { 10, 11, 13 };
            a[2] = new int[] { 12, 13, 15 };

            var actual = KthSmallest(a, 8);

            Assert.AreEqual(15, actual);
        }

        [TestMethod]
        public void TestMethodSearchIn2DMatrix()
        {
            // arrange
            var row1 = new int[4] { 1, 3, 5, 7 };
            var row2 = new int[4] { 10, 11, 16, 20 };
            var row3 = new int[4] { 23, 30, 34, 60 };
            var matrix = new int[3][];
            matrix[0] = row1;
            matrix[1] = row2;
            matrix[2] = row3;
            var target = 3;

            // act
            var actual = SearchMatrix(matrix, target);

            var expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodSearchIn2DMatrix1()
        {
            // arrange
            var row1 = new int[1] { 1 };

            var matrix = new int[1][];
            matrix[0] = row1;
            var target = 0;

            // act
            var actual = SearchMatrix(matrix, target);

            var expected = false;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodSearchIn2DMatrix2()
        {
            // arrange
            var row1 = new int[1] { 1 };
            var row2 = new int[1] { 3 };

            var matrix = new int[2][];
            matrix[0] = row1;
            matrix[1] = row2;
            var target = 3;

            // act
            var actual = SearchMatrix(matrix, target);

            var expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodSearchIn2DMatrix3()
        {
            // arrange
            var row1 = new int[1] { 1 };

            var matrix = new int[1][];
            matrix[0] = row1;
            var target = 1;

            // act
            var actual = SearchMatrix(matrix, target);

            var expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodSearchIn2DMatrix4()
        {
            // arrange
            var row1 = new int[2] { 1, 1 };
            var row2 = new int[2] { 2, 2 };

            var matrix = new int[2][];
            matrix[0] = row1;
            matrix[1] = row2;
            var target = 0;

            // act
            var actual = SearchMatrix(matrix, target);

            // assert
            var expected = false;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodSortColors()
        {
            // arrange
            var actual = new int[6] { 2, 0, 2, 1, 1, 0 };

            // act
            SortColors(actual);

            // assert
            var expected = new int[6] { 0, 0, 1, 1, 2, 2 };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodGenerateParenthesis()
        {
            // arrange 
            var n = 3;

            // act 
            var actual = GenerateParenthesis(n);

            // assert
            Assert.AreEqual(5, actual.Count);
        }

        [TestMethod]
        public void TestMethodEqualPairs()
        {
            // arrange 
            var row1 = new int[3] { 3, 2, 1 };
            var row2 = new int[3] { 1, 7, 6 };
            var row3 = new int[3] { 2, 7, 7 };

            var grid = new int[3][];
            grid[0] = row1;
            grid[1] = row2;
            grid[2] = row3;

            // act 
            var actual = EqualPairs(grid);

            // assert
            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void TestMethodMaximumDetonation()
        {
            // arrange 
            var row1 = new int[3] { 2, 1, 3 };
            var row2 = new int[3] { 6, 1, 4 };

            var grid = new int[2][];
            grid[0] = row1;
            grid[1] = row2;

            // act 
            var actual = MaximumDetonation(grid);

            // assert
            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        public void TestMethodMaximumDetonation1()
        {
            // arrange 
            var row1 = new int[3] { 1, 1, 5 };
            var row2 = new int[3] { 10, 10, 5 };

            var grid = new int[2][];
            grid[0] = row1;
            grid[1] = row2;

            // act 
            var actual = MaximumDetonation(grid);

            // assert
            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void TestMethodMaximumDetonation2()
        {
            // arrange 
            var row1 = new int[3] { 1, 2, 3 };
            var row2 = new int[3] { 2, 3, 1 };
            var row3 = new int[3] { 3, 4, 2 };
            var row4 = new int[3] { 4, 5, 3 };
            var row5 = new int[3] { 5, 6, 4 };

            var grid = new int[5][];
            grid[0] = row1;
            grid[1] = row2;
            grid[2] = row3;
            grid[3] = row4;
            grid[4] = row5;

            // act 
            var actual = MaximumDetonation(grid);

            // assert
            Assert.AreEqual(5, actual);
        }

        [TestMethod]
        public void TestMethodOrangesRotting()
        {
            // arrange 
            var row1 = new int[3] { 2, 1, 1 };
            var row2 = new int[3] { 1, 1, 0 };
            var row3 = new int[3] { 0, 1, 1 };

            var grid = new int[3][];
            grid[0] = row1;
            grid[1] = row2;
            grid[2] = row3;

            // act 
            var actual = OrangesRotting(grid);

            // assert
            Assert.AreEqual(4, actual);
        }

        public int OrangesRotting(int[][] grid)
        {
            if (grid.Length == 0)
                return 0;
            var rowCnt = grid.Length;
            var colCnt = grid[0].Length;

            var firstRotten = new List<int[]>();
            var freshCnt = 0;
            for (var row = 0; row < rowCnt; row++)
            {
                for (var col = 0; col < colCnt; col++)
                {
                    if (grid[row][col] == 2)
                        firstRotten.Add(new int[] { row, col });

                    if (grid[row][col] == 1)
                        freshCnt++;
                }
            }

            if (freshCnt == 0)
                return 0;

            var iterCnt = 0;
            while (true)
            {
                var nextRotten = new List<int[]>();
                foreach (var rottenItem in firstRotten)
                {
                    var row = rottenItem[0];
                    var col = rottenItem[1];

                    //bottom
                    if ((row + 1) < rowCnt && grid[row + 1][col] == 1)
                    {
                        grid[row + 1][col] = 2;
                        nextRotten.Add(new int[] { row + 1, col });
                        freshCnt--;
                    }

                    //top
                    if ((row - 1) >= 0 && grid[row - 1][col] == 1)
                    {
                        grid[row - 1][col] = 2;
                        nextRotten.Add(new int[] { row - 1, col });
                        freshCnt--;
                    }

                    //right
                    if ((col + 1) < colCnt && grid[row][col + 1] == 1)
                    {
                        grid[row][col + 1] = 2;
                        nextRotten.Add(new int[] { row, col + 1 });
                        freshCnt--;
                    }

                    //left
                    if ((col - 1) >= 0 && grid[row][col - 1] == 1)
                    {
                        grid[row][col - 1] = 2;
                        nextRotten.Add(new int[] { row, col - 1 });
                        freshCnt--;
                    }
                }

                if (nextRotten.Count == 0)
                    break;

                firstRotten = nextRotten;
                iterCnt++;
            }

            return freshCnt > 0 ? -1 : iterCnt;
        }

        public int MaximumDetonation(int[][] bombs)
        {
            var dict = new Dictionary<int, List<int>>();
            for (var i = 0; i < bombs.Length; i++)
            {
                dict.Add(i, new List<int>());
                var bomb1 = bombs[i];
                for (var j = 0; j < bombs.Length; j++)
                {
                    if (i == j)
                        continue;
                    var bomb2 = bombs[j];
                    var distance = GetDistance(bomb1[0], bomb1[1], bomb2[0], bomb2[1]);
                    if (distance <= bomb1[2])
                    {
                        dict[i].Add(j);
                    }
                }
            }
            var ans = 0;
            foreach (var item in dict)
            {
                var hs = new List<int>();
                MaxDet(item.Key, dict, hs);
                ans = Math.Max(ans, hs.Count);
            }

            return ans;
        }

        private void MaxDet(int key, Dictionary<int, List<int>> dict, List<int> hs)
        {
            // base case
            if (hs.Contains(key))
            {
                return;
            }

            hs.Add(key);

            // recurrence telation
            var target = dict[key];
            foreach (var itemKey in target)
            {
                MaxDet(itemKey, dict, hs);
            }
        }

        private double GetDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }

        public int EqualPairs(int[][] grid)
        {
            var n = grid.Length;
            var rows = new Dictionary<int, string>();
            for (var i = 0; i < n; i++)
            {
                rows.Add(i, string.Join("_", grid[i].Select(x => x.ToString()).ToArray()));
            }
            var cols = new Dictionary<int, string>();
            //horizontal
            for (var i = 0; i < n; i++)
            {
                //vertical
                var sb = new StringBuilder();
                for (var j = 0; j < n; j++)
                {
                    sb.Append(grid[j][i].ToString() + "_");
                }
                var str = sb.ToString();
                cols.Add(i, str.Substring(0, str.Length - 1));
            }
            var cnt = 0;
            foreach (var row in rows)
            {
                foreach (var col in cols)
                {
                    if (row.Value.Equals(col.Value))
                    {
                        cnt++;
                    }
                }
            }

            return cnt;
        }

        public IList<string> GenerateParenthesis(int n)
        {
            var ans = new List<string>();
            generateParenthesis(n, 0, 0, "", ans);
            return ans;
        }

        void generateParenthesis(int n, int open, int close, string s, IList<string> ans)
        {
            // base case
            if (open == n && close == n)
            {
                ans.Add(s);
                return;
            }

            // recurrence relation
            // while open parentheses count less than n
            if (open < n)
            {
                generateParenthesis(n, open + 1, close, s + "(", ans);
            }

            // while closed parentheses count more than the count of open parentheses
            if (close < open)
            {
                generateParenthesis(n, open, close + 1, s + ")", ans);
            }
        }

        public void SortColors(int[] nums)
        {
            throw new NotImplementedException();
        }

        public bool SearchMatrix(int[][] matrix, int target)
        {
            // corner case m=1 n=1
            if (matrix.Length == 1 && matrix[0].Length == 1)
                return matrix[0][0] == target;

            // first step
            var low = 0;
            var high = matrix.Length;

            if (high == 1)
            {
                low = 1;
            }
            else
            {
                while (low < high)
                {
                    var mid = (low + high) / 2;
                    if (matrix[mid][0] == target)
                    {
                        return true;
                    }
                    else if (matrix[mid][0] > target)
                    {
                        high = mid;
                    }
                    else
                    {
                        low = mid + 1;
                    }
                }
            }
            // если таргет меньше первого числа в строке
            if (low == 0)
                return false;

            if (matrix[0].Length > 1)
            {
                // second step
                var targetRowIndex = low - 1; // this index found on first step
                low = 0;
                high = matrix[0].Length;

                while (low < high)
                {
                    var mid = (low + high) / 2;
                    if (matrix[targetRowIndex][mid] == target)
                    {
                        return true;
                    }
                    else if (matrix[targetRowIndex][mid] > target)
                    {
                        high = mid;
                    }
                    else
                    {
                        low = mid + 1;
                    }
                }
            }

            return false;
        }

        public int KthSmallest(int[][] a, int k)
        {

            var n = a[0].Length;
            int left = a[0][0];     // <= answer
            int right = a[n - 1][n - 1];   // >= answer

            // binary search
            while (left + 1 < right)
            {
                var mid = left + ((0u + left - right) >> 1);

                int count = 0; // number of elements < mid
                var j = n;
                for (var i = 0; i < n && j > 0; i++)
                {
                    while (j - 1 >= 0 && a[i][j - 1] > mid)
                    {
                        j--;
                    }
                    count += j;
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

            while (left + 1 < right)
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

            for (var i = nums.Length - 1; i >= 0; i--)
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

            for (var i = 0; i < nums.Length; i++)
            {
                left = 0;
                int right = size;
                // бинарный поиск индекса куда вставить элемент, который должен поддерживать массив
                // минимальных упорядоченных элементов подпоследовательностей
                while (left != right)
                {
                    var mid = (left + right) / 2;
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

                if (left == size)
                    size++;
            }

            return size;
        }
    }
}
