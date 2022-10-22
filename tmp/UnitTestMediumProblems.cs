using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLeetCodeProjects
{
    [TestClass]
    public class UnitTestMediumProblems
    {
        [TestMethod]
        public void TestMethodCombinationSum4()
        {
            int[] nums = new int[3] { 1, 2, 3 };

            var actual = CombinationSum4(nums, 4);

            Assert.AreEqual(7, actual);
        }

        [TestMethod]
        public void TestMethodMajorityElementCorrectThreeNum()
        {
            int[] nums = new int[3] { 3, 2, 3 };

            var actual = MajorityElement(nums);

            Assert.AreEqual(3, actual[0]);
        }

        [TestMethod]
        public void TestMethodMajorityElementInCorrectThreeNum()
        {
            int[] nums = new int[3] { 3, 2, 1 };

            var actual = MajorityElement(nums);

            Assert.AreEqual(0, actual.Count);
        }

        [TestMethod]
        public void TestMethodMajorityElementInCorrectTenNum()
        {
            int[] nums = new int[10] { 3, 4, 5, 4, 3, 5, 3, 3, 4, 4  };

            var actual = MajorityElement(nums);

            Assert.AreEqual(2, actual.Count);
        }

        [TestMethod]
        public void TestMethodMajorityElementInCorrectTenNum1()
        {
            int[] nums = new int[10] { 3, 4, 4, 4, 3, 3, 3, 3, 4, 4 };

            var actual = MajorityElement(nums);

            Assert.AreEqual(2, actual.Count);
        }

        [TestMethod]
        public void TestMethodMajorityElementInCorrectFourthNum()
        {
            int[] nums = new int[4] { 2, 2, 1, 3};

            var actual = MajorityElement(nums);

            Assert.AreEqual(2, actual[0]);
            Assert.AreEqual(1, actual.Count);
        }

        [TestMethod]
        public void TestMethodMajorityElementInCorrectFourthNum1()
        {
            int[] nums = new int[4] { 0, 3, 4, 0 };

            var actual = MajorityElement(nums);

            Assert.AreEqual(0, actual[0]);
            Assert.AreEqual(1, actual.Count);
        }

        [TestMethod]
        public void TestMethodIntToRoman()
        {
            var actual = IntToRoman(3);

            Assert.AreEqual("III", actual);
        }

        [TestMethod]
        public void TestMethodGenerateParenthesses()
        {
            var actual = GenerateParenthesses(4);

            Assert.AreEqual(14, actual.Count);
        }

        [TestMethod]
        public void TestMethodLengthOfLIS()
        {
            var arr = new int[8] { 10, 9, 2, 5, 3, 7, 101, 18 };

            var actual = LengthOfLIS(arr);

            Assert.AreEqual(4, actual);
        }

        [TestMethod]
        public void TestMethodLengthOfLIS1()
        {
            var arr = new int[6] { 0, 1, 0, 3, 2, 3 };

            var actual = LengthOfLIS(arr);

            Assert.AreEqual(4, actual);
        }

        [TestMethod]
        public void TestMethodLengthOfLIS2()
        {
            var arr = new int[4] { 1,2,3,4 };

            var actual = LengthOfLIS(arr);

            Assert.AreEqual(4, actual);
        }

        [TestMethod]
        public void TestMethodLongestPalindromeSubseq()
        {
            var str = "bbbab";

            var actual = LongestPalindromeSubseq(str);

            Assert.AreEqual(4, actual);
        }

        [TestMethod]
        public void TestMethodLongestPalindromeSubseq1()
        {
            var str = "cbbd";

            var actual = LongestPalindromeSubseq(str);

            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        public void TestMethodLongestPalindromeSubseq2()
        {
            var str = "gphyvqruxjmwhonjjrgumxjhfyupajxbjgthzdvrdqmdouuukeaxhjumkmmhdglqrrohydrmbvtuwstgkobyzjjtdtjroqpyusfsbjlusekghtfbdctvgmqzeybnwzlhdnhwzptgkzmujfldoiejmvxnorvbiubfflygrkedyirienybosqzrkbpcfidvkkafftgzwrcitqizelhfsruwmtrgaocjcyxdkovtdennrkmxwpdsxpxuarhgusizmwakrmhdwcgvfljhzcskclgrvvbrkesojyhofwqiwhiupujmkcvlywjtmbncurxxmpdskupyvvweuhbsnanzfioirecfxvmgcpwrpmbhmkdtckhvbxnsbcifhqwjjczfokovpqyjmbywtpaqcfjowxnmtirdsfeujyogbzjnjcmqyzciwjqxxgrxblvqbutqittroqadqlsdzihngpfpjovbkpeveidjpfjktavvwurqrgqdomiibfgqxwybcyovysydxyyymmiuwovnevzsjisdwgkcbsookbarezbhnwyqthcvzyodbcwjptvigcphawzxouixhbpezzirbhvomqhxkfdbokblqmrhhioyqubpyqhjrnwhjxsrodtblqxkhezubprqftrqcyrzwywqrgockioqdmzuqjkpmsyohtlcnesbgzqhkalwixfcgyeqdzhnnlzawrdgskurcxfbekbspupbduxqxjeczpmdvssikbivjhinaopbabrmvscthvoqqbkgekcgyrelxkwoawpbrcbszelnxlyikbulgmlwyffurimlfxurjsbzgddxbgqpcdsuutfiivjbyqzhprdqhahpgenjkbiukurvdwapuewrbehczrtswubthodv";

            var actual = LongestPalindromeSubseq(str);

            Assert.AreEqual(305, actual);
        }

        [TestMethod]
        public void TestMethodLengthOfLongestSubstring()
        {
            var str = "abcabcbb";

            var actual = LengthOfLongestSubstring(str);

            Assert.AreEqual(3, actual);
        }

        [TestMethod]
        public void TestMethodJudgeSquareSum()
        {
            var num = 5;

            var actual = JudgeSquareSum(num);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void TestMethodJudgeSquareSum1()
        {
            var num = 3;

            var actual = JudgeSquareSum(num);

            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void TestMethodJudgeSquareSum2()
        {
            var num = 41;

            var actual = JudgeSquareSum(num);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void TestMethodJudgeSquareSum3()
        {
            var num = 4;

            var actual = JudgeSquareSum(num);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void TestMethodJudgeSquareSum4()
        {
            var num = 0;

            var actual = JudgeSquareSum(num);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void TestMethodMinPathSum()
        {
            var nums = new int[3][];
            nums[0] = new int[3] { 1, 3, 1 };
            nums[1] = new int[3] { 1, 5, 1 };
            nums[2] = new int[3] { 4, 2, 1 };

            var actual = MinPathSum(nums);

            Assert.AreEqual(7, actual);
        }

        [TestMethod]
        public void TestMethodMinPathSum1()
        {
            var nums = new int[2][];
            nums[0] = new int[3] { 1, 2, 3 };
            nums[1] = new int[3] { 4, 5, 6 };

            var actual = MinPathSum(nums);

            Assert.AreEqual(12, actual);
        }

        [TestMethod]
        public void TestMethodSearchRange()
        {
            var nums = new int[6] { 5, 7, 7, 8, 8, 10 };
            var target = 8;

            var actual = SearchRange(nums, target);

            Assert.AreEqual(3, actual[0]);
            Assert.AreEqual(4, actual[1]);
        }

        [TestMethod]
        public void TestMethodSearchRange1()
        {
            var nums = new int[6] { 5, 7, 7, 8, 8, 10 };
            var target = 6;

            var actual = SearchRange(nums, target);

            Assert.AreEqual(-1, actual[0]);
            Assert.AreEqual(-1, actual[1]);
        }

        [TestMethod]
        public void TestMethodSearchRange2()
        {
            var nums = new int[0] ;
            var target = 0;

            var actual = SearchRange(nums, target);

            Assert.AreEqual(-1, actual[0]);
            Assert.AreEqual(-1, actual[1]);
        }

        [TestMethod]
        public void TestMethodSearchRange3()
        {
            var nums = new int[2] { 8,8 };
            var target = 8;

            var actual = SearchRange(nums, target);

            Assert.AreEqual(0, actual[0]);
            Assert.AreEqual(1, actual[1]);
        }

        [TestMethod]
        public void TestMethodSearchRange4()
        {
            var nums = new int[4] { 6, 6, 7, 7 };
            var target = 7;

            var actual = SearchRange(nums, target);

            Assert.AreEqual(2, actual[0]);
            Assert.AreEqual(3, actual[1]);
        }

        [TestMethod]
        public void TestMethodLongestCommonSubsequence()
        {
            var str1 = "abcde";
            var str2 = "ace";

            var actual = LongestCommonSubsequence(str1, str2);

            Assert.AreEqual(3, actual);
        }


        [TestMethod]
        public void TestMethodFindKthLargest()
        {
            var nums = new int[6] { 3, 2, 1, 5, 6, 4 };

            var actual = FindKthLargest(nums,2);

            Assert.AreEqual(5, actual);
        }

        public int FindKthLargest(int[] nums, int k)
        {
            var arr = new int[k];

            var i = 0;
            foreach(var num in nums)
            {
                var j = 0;
                while(arr[j]>num)
                i++;
            }

            return dict[k-1];
        }

        public int LongestCommonSubsequence(string text1, string text2)
        {
            // похоже на поиск кратчайшего путит
            var m = text1.Length;
            var n = text2.Length;

            int[,] L = new int[m + 1, n + 1];
            
            // text1
            for(var i = 0; i <= m; i++)
            {
                // text2
                for(var j = 0; j <= n; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        L[i, j] = 0;
                        continue;
                    } else  if (text1[i-1] == text2[j-1])
                        L[i, j] = L[i - 1, j - 1] + 1;
                    else
                        L[i, j] = Math.Max(L[i, j - 1], L[i - 1, j]);
                }
            }

            return L[m, n];
        }

        public int[] SearchRange(int[] nums, int target)
        {
            var ans = new int[2] { -1, -1 }; 

            var l = 0;
            var r = nums.Length - 1;
            while (l < r)
            {
                var mid = (l + r) / 2;
                if (nums[mid] < target)
                    l = mid + 1;
                else
                    r = mid;
            }

            if (nums.Length==0 || nums[l] != target )
                return ans;
            
            ans[0] = l;

            r = nums.Length - 1;
            while (l < r)
            {
                var mid = (l + r) / 2 + 1;
                if (nums[mid] > target)
                    r = mid - 1;
                else
                    l = mid;
            }
            ans[1] = r;

            return ans;
        }

        public int MinPathSum(int[][] grid)
        {
            var m = grid.Length;
            var n = grid[0].Length;

            var top = int.MaxValue;
            var left = int.MaxValue;

            for (var i = 0; i < m; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    top = int.MaxValue;
                    left = int.MaxValue;
                    if (i != 0)
                    {
                        top = grid[i - 1][j];
                    }
                    if (j != 0)
                    {
                        left = grid[i][j - 1];
                    }
                    if (i != 0 || j != 0)
                        grid[i][j] = grid[i][j] + Math.Min(top, left);   
                }
            }

            return grid[m-1][n-1];
        }

        public bool JudgeSquareSum(int c)
        {
            for (int i = 2; i * i <= c; i++)
            {
                int count = 0;
                if (c % i == 0)
                {
                    while (c % i == 0)
                    {
                        count++;
                        c /= i;
                    }
                    if (i % 4 == 3 && count % 2 != 0)
                        return false;
                }
            }
            return c % 4 != 3;
            /*HashSet<long> nums = new HashSet<long>();
            for (int i = 0; i <= Math.Sqrt(c); i++)
            {
                nums.Add((long)i * i);
                if (nums.Contains((long)(c - i * i)))
                {
                    return true;
                }
            }
            return false;*/
        }

        bool IsPerfectSquare(int num)
        {
            // use binary search
            var low = 1;
            var high = Math.Min(46340, num); //46340 max sqr value
            while (low < high)
            {
                var mid = (high + low) / 2;
                if (num < mid * mid)
                    high = mid - 1;
                else if (num > mid * mid)
                    low = mid + 1;
                else
                    return true;
            }
            return low * low == num;
        }

        bool binary_search(long s, long e, int n)
        {
            if (s > e)
                return false;
            long mid = s + (e - s) / 2;
            if (mid * mid == n)
                return true;
            if (mid * mid > n)
                return binary_search(s, mid - 1, n);
            return binary_search(mid + 1, e, n);
        }

        public int LengthOfLongestSubstring(string s)
        {
            var ans = 0;
            for(var first = 0; first < s.Length; first++)
            {
                bool[] used = new bool[128];
                var len = 0;
                for(var i = first; i < s.Length; i++)
                {
                    if (used[s[i]])
                        break;

                    used[s[i]] = true;
                    len++;
                }
                ans = Math.Max(ans, len);
            }
            return ans;
        }

        public int LongestPalindromeSubseq(string s)
        {
            var arr1 = s.ToCharArray();
            var arr2 = s.ToCharArray();
            Array.Reverse(arr2);
           
            return lcs(arr1, arr2,arr1.Length, arr2.Length);
        }

        int lcs(char[] X, char[] Y, int m, int n)
        {
            int[,] L = new int[m + 1, n + 1];

            /* Following steps build L[m+1][n+1]
            in bottom up fashion. Note
            that L[i][j] contains length of
            LCS of X[0..i-1] and Y[0..j-1] */
            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if (i == 0 || j == 0)
                        L[i, j] = 0;
                    else if (X[i - 1] == Y[j - 1])
                        L[i, j] = L[i - 1, j - 1] + 1;
                    else
                        L[i, j] = Math.Max(L[i - 1, j], L[i, j - 1]);
                }
            }
            return L[m, n];
        }

        public int LongestPalindromeSubseq_MyEdition(string s)
        {
            var arr = s.ToCharArray();
            Array.Reverse(arr);
            var s3 = new string(arr);
            var dict = new Dictionary<Tuple<string, string>, int>();

            int Longest(string s1, string s2)
            {
                var s4 = s1;
                var s5 = s2;

                // base case
                if (s1.Length == 0 || s2.Length == 0)
                {
                    return 0;
                }

                if (dict.ContainsKey((s1, s2).ToTuple()))
                    return dict[(s1, s2).ToTuple()];


                var ans = 0;
                while (s1[s1.Length - 1] == s2[s2.Length - 1])
                {
                    s1 = s1.Remove(s1.Length - 1);
                    s2 = s2.Remove(s2.Length - 1);
                    ans++;

                    if (s1.Length == 0 || s2.Length == 0)
                    {
                        dict.Add((s4, s5).ToTuple(), ans);
                        return ans;
                    }

                }

                // recurrence relation
                ans += Math.Max(Longest(s1.Remove(s1.Length - 1), s2), Longest(s1, s2.Remove(s2.Length - 1)));

                dict.Add((s4, s5).ToTuple(), ans);

                return ans;
            }

            return Longest(s, s3);
        }

        // DP approach
        // binary search
        public int LengthOfLIS(int[] nums)
        {
            // куча последовательных минимальных элементов
            int[] tails = new int[nums.Length];

            // max size
            int size = 0;

            // идём по всем числам массива 
            foreach (int x in nums)
            {
                int left = 0;
                int right = size;

                // бинарный поиск куда вставить след элемент и стоит ли
                // на выходе в переменной left значение индекса по которому 
                // надо вставить либо добавить элемент
                while (left != right)
                {
                    int mid = (left + right) / 2;

                    if (tails[mid] < x)
                        left = mid + 1;
                    else
                        right = mid;
                }

                tails[left] = x;

                // если текущая граница равна размеру значит инкрементируем значение
                // потому что нумерация в массиве с нуля а left это крайний индекс массива
                // в ряде случаев
                if (left == size)
                    size++;
            }
            return size;

            /*if (nums.Length == 0) return 0;

            var L = new List<List<int>>();
            for(var i = 0;i<nums.Length;i++)
            {
                L.Add(new List<int>());
            }

            L[0].Add(nums[0]);

            // для каждого i нужно посчитать максимальную последовательность 
            // как это сделать? 
            var cnt = 0;
            for (var i = 1; i < nums.Length; i++)
            {
                // здесь нужно выловить максимальную последовательность из предыдущих
                // цикл по j таком, что оно от 0 до i не включительно
                // и если последний член последовательности L[j] меньше чем текущее число 
                // то мы эту последовательность делаем текущей 
                // и после цикла соответственно её инкрементируем
                var f = false;
                for (var j = 0; j <i; j++)
                {
                    if (nums[j] < nums[i]&&L[j].Count>L[i].Count)
                    {
                        L[i].Clear();
                        L[i].AddRange(L[j]);
                    }
                }

                // добавляем в конец текущий член массива
                L[i].Add(nums[i]);
            }

            var longest = 0;
            foreach(var lst in L)
            {
                if (lst.Count > longest)
                    longest = lst.Count;
            }

            return longest;*/
        }

        public IList<string> GenerateParenthesses(int num)
        {
            var ans = new List<string>();
            if (num == 0)
            {
                ans.Add("");
            }
            else
            {
                for (int c = 0; c < num; ++c)
                {
                    foreach (var left in GenerateParenthesses(c))
                        foreach (var right in GenerateParenthesses(num - 1 - c))
                            ans.Add("(" + left + ")" + right);
                }
                    
            }
            return ans;

        }

        /*
         def bracket(count, s='', left=0, right=0):
             if left == count and right == count:
                print(s)
             else:
                if left < count:
                    bracket(count, s + '(', left+1, right)
                if right < left:
                    bracket(count, s + ')', left, right+1)
         */

        public string IntToRoman(int num)
        {
            int[] val = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] rom = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };


            StringBuilder ans = new StringBuilder();
            for (int i = 0; num > 0; i++)
            {
                while (num >= val[i])
                {
                    ans.Append(rom[i]);
                    num -= val[i];
                }
            }

            return ans.ToString();

        }

        // get list of elements, that appear more than  n/3  times.
        public IList<int> MajorityElement(int[] nums)
        {
            /*if (nums.Length == 0 || nums.Length == 1) return new List<int>(nums);
            if (nums.Length == 2)
            {
                if(nums[0]==nums[1]) return new List<int> { nums[0] };
                return new List<int>(nums);
            }*/
                
            // макисмальное количество таких элементов 2.
            var res = new List<int>();

            int sz = nums.Length;
            int num1 = -1, num2 = -1, count1 = 0, count2 = 0, i;

            for (i = 0; i < sz; i++)
            {
                if (nums[i] == num1)
                    count1++;
                else if (nums[i] == num2)
                    count2++;
                else if (count1 == 0)
                {
                    num1 = nums[i];
                    count1 = 1;
                }
                else if (count2 == 0)
                {
                    num2 = nums[i];
                    count2 = 1;
                }
                else
                {
                    count1--;
                    count2--;
                }
            }

            count1 = count2 = 0;
            for (i = 0; i < sz; i++)
            {
                if (nums[i] == num1)
                    count1++;
                else if (nums[i] == num2)
                    count2++;
            }

            if (count1 > sz / 3)
                res.Add(num1);

            if (count2 > sz / 3)
                res.Add(num2);

            return res;
        }

        public int CombinationSum4(int[] nums, int target)
        {
            int[] dp = new int[target + 1];
            dp[0] = 1;
            for (int i = 1; i <= target; i++)
            {
                foreach (int num in nums)
                {
                    if (num <= i)
                        dp[i] += dp[i - num];
                }
            }
                
                    
            return dp[target];

            //int?[] memo = new int?[target + 1];
            //return recurse(nums, target, memo);
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

    }
}
