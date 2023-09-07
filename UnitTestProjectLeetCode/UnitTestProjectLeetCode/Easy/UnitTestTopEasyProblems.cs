using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace UnitTestProjectLeetCode
{
    /// <summary>
    /// Summary description for UnitTestTopEasyProblems
    /// </summary>
    [TestClass]
    public class UnitTestTopEasyProblems
    {

        [TestMethod]
        public void TestMethodFirstBadVersion()
        {
            //2126753390
            //1702766719
            var bad = FirstBadVersion(2126753390);

            Assert.AreEqual(1702766719, bad);
        }

        [TestMethod]
        public void TestMethodReverseString()
        {
            var arr = new char[5] { 'h', 'e', 'l', 'l', 'o' };

            ReverseString(arr);

            Assert.AreEqual('o', arr[0]);
        }

        [TestMethod]
        public void TestMethodReverseInt()
        {

            var num = 123;
            var res = Reverse(num);

            Assert.AreEqual(321, res);
        }

        [TestMethod]
        public void TestMethodReverseInt1()
        {

            var num = -123;
            var res = Reverse(num);

            Assert.AreEqual(-321, res);
        }

        [TestMethod]
        public void TestMethodReverseInt2()
        {

            var num = 120;
            var res = Reverse(num);

            Assert.AreEqual(21, res);
        }

        [TestMethod]
        public void TestMethodIsPalindrome()
        {

            var str = "A man, a plan, a canal: Panama";
            var res = IsPalindrome(str);

            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void TestMethodIsPalindrome1()
        {

            var str = "A man, a plan, a canal -- Panama";
            var res = IsPalindrome(str);

            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void TestMethodGetCountSteps()
        {
            var res = GetCountSteps(4);

            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void TestMethodGetCountSteps1()
        {
            var res = GetCountSteps(8);

            Assert.AreEqual(3, res);
        }

        [TestMethod]
        public void TestMethodGetCountSteps2()
        {
            var res = GetCountSteps(1);

            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void TestMethodFindErrorNums()
        {
            var nums = new int[2] { 1, 1 };

            var res = FindErrorNums(nums);

            Assert.AreEqual(1, res[0]);
            Assert.AreEqual(2, res[1]);
        }

        [TestMethod]
        public void TestMethodFindErrorNums1()
        {
            var nums = new int[4] { 1, 2, 2, 4 };

            var res = FindErrorNums(nums);

            Assert.AreEqual(2, res[0]);
            Assert.AreEqual(3, res[1]);
        }

        [TestMethod]
        public void TestMethodJudgeCircle()
        {
            var moves = "UD";

            var res = JudgeCircle(moves);

            Assert.IsTrue(res);

        }

        [TestMethod]
        public void TestMethodFurthestDistanceFromOrigin()
        {
            var moves = "L_RL__R";

            var actual = FurthestDistanceFromOrigin(moves);

            Assert.AreEqual(3, actual);
        }

        [TestMethod]
        public void TestMethodFurthestDistanceFromOrigin1()
        {
            var moves = "_R__LL_";

            var actual = FurthestDistanceFromOrigin(moves);

            Assert.AreEqual(5, actual);
        }

        [TestMethod]
        public void TestMethodFurthestDistanceFromOrigin4()
        {
            var moves = "R_____RRR__R_RRRRL__LL_______RR__RRL_LRLRL";

            var actual = FurthestDistanceFromOrigin(moves);

            Assert.AreEqual(28, actual);
        }

        [TestMethod]
        public void TestMethodFurthestDistanceFromOrigin2()
        {
            var moves = "_______";

            var actual = FurthestDistanceFromOrigin(moves);

            Assert.AreEqual(7, actual);
        }

        [TestMethod]
        public void TestMethodDeleteGreatestValue()
        {
            var grid = new int[2][];
            grid[0] = new int[3] { 1, 2, 4 };
            grid[1] = new int[3] { 3, 3, 1 };

            var actual = DeleteGreatestValue(grid);

            Assert.AreEqual(8, actual);
        }

        [TestMethod]
        public void TestMethodDeleteGreatestValue1()
        {
            var grid = new int[1][];
            grid[0] = new int[1] { 10 };

            var actual = DeleteGreatestValue(grid);

            Assert.AreEqual(10, actual);
        }

        [TestMethod]
        public void TestMethodFindJudge()
        {
            var grid = new int[1][];
            grid[0] = new int[2] { 1, 2 };

            var actual = FindJudge(2, grid);

            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        public void TestMethodFindJudge1()
        {
            var grid = new int[2][];
            grid[0] = new int[2] { 1, 3 };
            grid[1] = new int[2] { 2, 3 };

            var actual = FindJudge(3, grid);

            Assert.AreEqual(3, actual);
        }

        public int FindJudge(int n, int[][] trust)
        {
            var inArr = new int[n + 1];
            var outArr = new int[n + 1];

            for (var i = 0; i < trust.Length; i++)
            {
                outArr[trust[i][0]]++;
                inArr[trust[i][1]]++;
            }
            for (var i = 0; i <= n; i++)
            {
                if (outArr[i] == 0 && inArr[i] == (n - 1))
                    return i;
            }

            return -1;
        }
        /// <summary>
        /// O(m*n) + O(mLog(m))
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public int DeleteGreatestValue(int[][] grid)
        {
            var n = grid.Length;
            var m = grid[0].Length;
            //vartical
            for (var i = 0; i < n; i++)
            {
                Array.Sort(grid[i]);
            }
            var allCnt = 0;
            // horizontal
            for (var i = 0; i < m; i++)
            {
                var max = 1;
                // vertical
                for (var j = 0; j < n; j++)
                {
                    if (grid[j][i] > max)
                        max = grid[j][i];
                }
                allCnt += max;
            }

            return allCnt;
        }

        public int FurthestDistanceFromOrigin(string moves)
        {
            var count = new int[3];
            for (int i = 0; i < moves.Length; i++)
            {
                switch (moves[i])
                {
                    case 'L':
                        count[0]++;
                        break;
                    case 'R':
                        count[1]++;
                        break;
                    case '_':
                        count[2]++;
                        break;
                }
            }
            return Math.Abs(count[0] - count[1]) + count[2];
        }

        public bool JudgeCircle(string moves)
        {
            var udCntr = 0;
            var rlCntr = 0;
            for (var i = 0; i < moves.Length; i++)
            {
                var move = moves[i];
                if (move == 'U')
                {
                    udCntr++;
                }
                else if (move == 'D')
                {
                    udCntr--;
                }
                else if (move == 'L')
                {
                    rlCntr--;
                }
                else if (move == 'R')
                {
                    rlCntr++;
                }
            }

            return (udCntr == 0) && (rlCntr == 0);
        }

        public int[] FindErrorNums(int[] nums)
        {
            var res = new int[2];

            int dup = -1, missing = 1;
            foreach (var num in nums)
            {
                if (nums[Math.Abs(num) - 1] < 0)
                    dup = Math.Abs(num);
                else
                    nums[Math.Abs(num) - 1] *= -1;
            }

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                    missing = i + 1;
            }
            res[0] = dup;
            res[1] = missing;

            // create dict and fill it nums 1 to n
            // go along dict and if not found then missing and lst in dict return
            /*var dict = new HashSet<int>();
            for (var i = 1; i <= nums.Length; i++)
            {
                dict.Add(i);
            }

            foreach(var num in nums)
            {
                if(dict.Contains(num))
                    dict.Remove(num);
                else
                    res[0]=num;
            }
            res[1]=dict.FirstOrDefault();*/

            return res;
        }

        int GetCountSteps(int n)
        {
            if (n == 0) return n;
            if (n == 1 || n == 2) return 1;

            var prev = 1;
            var next = 2;
            var cnt = 0;
            while (true)
            {
                var tmp = prev;
                prev = next;
                next = prev + tmp;
                if (next > n)
                    break;
                cnt++;
            }

            return cnt;
        }

        public bool IsPalindrome(string s)
        {
            // first 
            Regex rgx = new("[^a-zA-Z0-9 ]");
            //s = new string(s.Where(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c) ).ToArray());
            s = rgx.Replace(s, "").Replace(" ", "").ToLower();
            // second part
            var chrs = s.ToCharArray();
            var l = 0;
            var r = chrs.Length - 1;

            while (l < r)
            {
                if (chrs[l] != chrs[r])
                    return false;

                l++;
                r--;
            }


            return true;
        }


        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;

            var dict1 = new Dictionary<char, int>();
            var dict2 = new Dictionary<char, int>();

            var chars1 = s.ToCharArray();
            var chars2 = t.ToCharArray();

            for (var i = 0; i < chars1.Length; i++)
            {
                if (dict1.ContainsKey(chars1[i]))
                    dict1[chars1[i]] += 1;
                else
                    dict1.Add(chars1[i], 1);

                if (dict2.ContainsKey(chars2[i]))
                    dict2[chars2[i]] += 1;
                else
                    dict2.Add(chars2[i], 1);
            }

            for (var i = 0; i < chars1.Length; i++)
            {
                if (!dict2.ContainsKey(chars1[i]) || !dict1.ContainsKey(chars2[i]))
                    return false;

                if (dict1[chars1[i]] != dict2[chars1[i]])
                {
                    return false;
                }
            }

            return true;

        }


        public int FirstUniqChar(string s)
        {
            var dict = new Dictionary<char, int>();
            var chars = s.ToCharArray();
            for (var i = 0; i < chars.Length; i++)
            {
                if (dict.ContainsKey(chars[i]))
                {
                    dict[chars[i]] += 1;
                }
                else
                {
                    dict.Add(chars[i], 1);
                }
            }

            for (var i = 0; i < chars.Length; i++)
            {
                if (dict.ContainsKey(chars[i]) && dict[chars[i]] == 1)
                {
                    return i;
                }
            }

            return -1;
        }


        public int Reverse(int x)
        {
            var result = 0;

            while (x != 0)
            {
                var last_d = x % 10;
                int temp = result * 10 + last_d;

                if ((temp - last_d) / 10 != result)
                    return 0;

                result = temp;
                x /= 10;
            }

            return result;

            /*void ReverseString(char[] s)
            {
                var l = 0;
                var r = s.Length - 1;

                while (l < r)
                {
                    var tmp = s[l];
                    s[l] = s[r];
                    s[r] = tmp;

                    r--;
                    l++;
                }

            }

            var negative = false;
            if (x < 0)
            {
                negative = true;
                x *= -1;
            }

            char[] str = x.ToString().ToCharArray();

            ReverseString(str);

            long longRes = 0;
            for (var i = 0; i<str.Length; i++)
            {

                var num = (int)Char.GetNumericValue(str[i]);

                longRes = longRes * 10 + num;
            }
            longRes = negative ? -longRes : longRes;

            int intRes = 0;
            try
            {
                intRes = Int32.Parse(longRes.ToString());
            }
            catch
            {
                return 0;
            }
            return intRes;*/
        }

        public void ReverseString(char[] s)
        {
            var l = 0;
            var r = s.Length - 1;

            while (l < r)
            {
                (s[r], s[l]) = (s[l], s[r]);
                r--;
                l++;
            }
        }

        public int FirstBadVersion(int n)
        {
            long l = 1;
            long r = n;

            while (l < r)
            {
                // divide by two
                long m = (l + r) / 2;
                if (IsBadVersion(m))
                {
                    r = m;
                }
                else
                {
                    l = m + 1;
                }
            }
            return (int)l;
        }

        public bool IsBadVersion(long m)
        {
            return m >= 1702766719;

        }
    }
}

