using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;
using System.Linq;

namespace UnitTestLeetCodeProjects
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
        public void TestMethodMyAtoi()
        {
            var str = "   -42";

            var res = MyAtoi(str);

            Assert.AreEqual(-42, res);
        }

        [TestMethod]
        public void TestMethodMyAtoi1()
        {
            var str = "4193 with words";

            var res = MyAtoi(str);

            Assert.AreEqual(4193, res);
        }

        [TestMethod]
        public void TestMethodMyAtoi2()
        {
            var str = ".1";

            var res = MyAtoi(str);

            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void TestMethodMyAtoi3()
        {
            var str = "21474836460";

            var res = MyAtoi(str);

            Assert.AreEqual(2147483647, res);
        }

        [TestMethod]
        public void TestMethodMyAtoi4()
        {
            var str = "000000000000000000";

            var res = MyAtoi(str);

            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void TestMethodMyAtoi5()
        {
            var str = " ++1";

            var res = MyAtoi(str);

            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void TestMethodMyAtoi6()
        {
            var str = "+";

            var res = MyAtoi(str);

            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void TestMethodStrStr()
        {
            var haystack = "hello";
            var needle = "ll";

            var indx = StrStr(haystack, needle);

            Assert.AreEqual(2, indx);
        }

        [TestMethod]
        public void TestMethodStrStr1()
        {
            var haystack = "aaaaa";
            var needle = "bba";

            var indx = StrStr(haystack, needle);

            Assert.AreEqual(-1, indx);
        }

        [TestMethod]
        public void TestMethodStrStr2()
        {
            var haystack = "abc";
            var needle = "c";

            var indx = StrStr(haystack, needle);

            Assert.AreEqual(2, indx);
        }

        [TestMethod]
        public void TestMethodStrStr3()
        {
            var haystack = "mississippi";
            var needle = "issip";

            var indx = StrStr(haystack, needle);

            Assert.AreEqual(4, indx);
        }

        [TestMethod]
        public void TestMethodStrStr4()
        {
            var haystack = "mississippi";
            var needle = "issipi";

            var indx = StrStr(haystack, needle);

            Assert.AreEqual(-1, indx);
        }


        [TestMethod]
        public void TestMethodLongestCommonPrefix()
        {
            var strArr = new string[] { "flower", "flow", "flight" };

            var indx = LongestCommonPrefix(strArr);

            Assert.AreEqual("fl", indx);
        }

        [TestMethod]
        public void TestMethodPlusOne()
        {
            var intArr = new int[] { 1, 2, 3 };

            var res = PlusOne(intArr);

            Assert.AreEqual(4, res[2]);
        }

        [TestMethod]
        public void TestMethodPlusOne1()
        {
            var intArr = new int[] { 9 };

            var res = PlusOne(intArr);

            Assert.AreEqual(0, res[1]);
        }

        [TestMethod]
        public void TestMethodIntersect()
        {
            var int1 = new int[] { 9 };
            var int2 = new int[] { 9 };

            var res = Intersect(int1, int2);

            Assert.AreEqual(9, res[0]);
        }

        [TestMethod]
        public void TestMethodIntersect1()
        {
            var int1 = new int[] { 1, 2, 2, 1 };
            var int2 = new int[] { 2, 2 };

            var res = Intersect(int1, int2);

            Assert.AreEqual(2, res[0]);
        }

        [TestMethod]
        public void TestMethodIntersect2()
        {
            var int1 = new int[] { 1, 2, 2, 1 };
            var int2 = new int[] { 2, 2 };

            var res = Intersect(int2, int1);

            Assert.AreEqual(2, res[1]);
        }

        [TestMethod]
        public void TestMethodIntersect3()
        {
            var int1 = new int[] { 2, 2 };
            var int2 = new int[] { 2, 2 };

            var res = Intersect(int2, int1);

            Assert.AreEqual(2, res[1]);
        }

        [TestMethod]
        public void TestMethodIntersect4()
        {
            var int1 = new int[] { 1, 2, 2, 2, 1 };
            var int2 = new int[] { 2, 2, 2 };

            var res = Intersect(int2, int1);

            Assert.AreEqual(2, res[1]);
        }

        [TestMethod]
        public void TestMethodIntersect5()
        {
            var int1 = new int[] { 1, 2, 2, 2, 1 };
            var int2 = new int[] { 4, 2, 2 };

            var res = Intersect(int2, int1);

            Assert.AreEqual(2, res[1]);
        }

        [TestMethod]
        public void TestMethodIntersect6()
        {
            var int1 = new int[] { 3, 4, 7, 5, 2, 6 };
            var int2 = new int[] { 1, 4, 9, 5, 7, 2, 4 };

            var res = Intersect(int2, int1);

            Assert.AreEqual(2, res[0]);
        }

        [TestMethod]
        public void TestMethodContainsDuplicate()
        {
            var int1 = new int[] { 3, 3, 3, 4, 1, 1, 8, 2 };

            var num = ContainsDuplicate(int1);

            Assert.AreEqual(true, num);
        }

        [TestMethod]
        public void TestMethodContainsDuplicate1()
        {
            var int1 = new int[] { 3, 4, 1 };

            var num = ContainsDuplicate(int1);

            Assert.AreEqual(false, num);
        }

        [TestMethod]
        public void TestMethodRotateImage()
        {
            // int[,] arr = new int[][] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            int[][] arr = new int[][]
            {
            new int[] { 1, 2, 3  },
            new int[] { 4, 5, 6 },
            new int[] { 7, 8, 9 }
            };

            Rotate(arr);

            Assert.AreEqual(7, arr[0][0]);
        }

        [TestMethod]
        public void TestMethodIsValidSudoku()
        {
            char[][] arr = new char[][]
            {
                new char[] { '8','3','.','.','7','.','.','.','.' },
                new char[] { '6','.','.','1','9','5','.','.','.' },
                new char[] { '.','9','8','.','.','.','.','6','.' },
                new char[] { '8','.','.','.','6','.','.','.','3' },
                new char[] { '4','.','.','8','.','3','.','.','1' },
                new char[] { '7','.','.','.','2','.','.','.','6' },
                new char[] { '.','6','.','.','.','.','2','8','.' },
                new char[] { '.','.','.','4','1','9','.','.','5' },
                new char[] { '.','.','.','.','8','.','.','7','9' }
            };

            var f = isValidSudoku1(arr);

            Assert.AreEqual(false, f);
        }

        [TestMethod]
        public void TestMethodIsValidSudoku1()
        {
            char[][] arr = new char[][]
            {
                new char[] { '5','3','.','.','7','.','.','.','.' },
                new char[] { '6','.','.','1','9','5','.','.','.' },
                new char[] { '.','9','8','.','.','.','.','6','.' },
                new char[] { '8','.','.','.','6','.','.','.','3' },
                new char[] { '4','.','.','8','.','3','.','.','1' },
                new char[] { '7','.','.','.','2','.','.','.','6' },
                new char[] { '.','6','.','.','.','.','2','8','.' },
                new char[] { '.','.','.','4','1','9','.','.','5' },
                new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
            };

            var f = isValidSudoku1(arr);

            Assert.AreEqual(true, f);
        }

        [TestMethod]
        public void TestMethodMaxProfit()
        {
            var int1 = new int[] { 7, 1, 5, 3, 6, 4 };

            var num = MaxProfit(int1);

            Assert.AreEqual(7, num);
        }

        [TestMethod]
        public void TestMethodMaxProfit1()
        {
            var int1 = new int[] { 1, 2, 3, 4, 5 };

            var num = MaxProfit(int1);

            Assert.AreEqual(4, num);
        }

        [TestMethod]
        public void TestMethodRotate()
        {
            var nums = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            Rotate(nums, 3);

            Assert.AreEqual(5, nums[0]);
        }

        [TestMethod]
        public void TestMethodRotate1()
        {
            var nums = new int[] { 1, 2, 3 };

            Rotate(nums, 2);

            Assert.AreEqual(2, nums[0]);
        }

        [TestMethod]
        public void TestMethodRotate2()
        {
            var nums = new int[] { 1 };

            Rotate(nums, 1);

            Assert.AreEqual(1, nums[0]);
        }

        [TestMethod]
        public void TestMethodRotate3()
        {
            var nums = new int[] { -1, -100, 3, 99 };

            Rotate(nums, 2);

            Assert.AreEqual(3, nums[0]);
        }

        [TestMethod]
        public void TestMethodRotate4()
        {
            var nums = new int[] { -1, -100, 3, 99 };

            Rotate(nums, 3);

            Assert.AreEqual(-100, nums[0]);
        }

        [TestMethod]
        public void TestMethodIsValidBST()
        {
            var left = new TreeNode(1);
            var right = new TreeNode(3);
            var node = new TreeNode(2,left,right);

            var f = IsValidBST(node);

            Assert.AreEqual(true, f);
        }

        [TestMethod]
        public void TestMethodIsValidBST1()
        {
            var left = new TreeNode(2);
            var right = new TreeNode(2);
            var node = new TreeNode(2, left, right);

            var f = IsValidBST(node);

            Assert.AreEqual(false, f);
        }

        [TestMethod]
        public void TestMethodIsSymmetric()
        {
            var left = new TreeNode(2);
            var right = new TreeNode(2);
            var node = new TreeNode(2, left, right);

            var f = IsSymmetric(node);

            Assert.AreEqual(true, f);
        }

        [TestMethod]
        public void TestMethodIsSymmetric1()
        {
            
            var childRight = new TreeNode(3);
            var childLeft = new TreeNode(3);
            var left = new TreeNode(2,null, childLeft);
            var right = new TreeNode(2,null,childRight);
            var node = new TreeNode(2, left, right);

            var f = IsSymmetric(node);

            Assert.AreEqual(false, f);
        }

        [TestMethod]
        public void TestMethodLevelOrder()
        {

            var childRight = new TreeNode(3);
            var childLeft = new TreeNode(3);
            var left = new TreeNode(2, childLeft, null);
            var right = new TreeNode(2, null, childRight);
            var node = new TreeNode(2, left, right);

            var f = LevelOrder(node);

            Assert.AreEqual(3, f.Count);
        }

        [TestMethod]
        public void TestMethodSortedArrayToBST()
        {
            var arr = new int[5] { -10, -3, 0, 5, 9 };

            var node = SortedArrayToBST(arr);

            Assert.AreEqual(5, node.right.val);
        }

        // MATH PROBLEMS

        [TestMethod]
        public void TestMethodFizzBuzz()
        {
            var n = 3;

            var arr = FizzBuzz(n);

            Assert.AreEqual("1", arr[0]);
        }

        [TestMethod]
        public void TestMethodCountPrimes()
        {
            var n = 10;

            var num = CountPrimes(n);

            Assert.AreEqual(4, num);
        }

        [TestMethod]
        public void TestMethodCountPrimes1()
        {
            var n = 2;

            var num = CountPrimes(n);

            Assert.AreEqual(0, num);
        }

        [TestMethod]
        public void TestMethodIsPowerOfThree()
        {
            var n = 243;

            var res = IsPowerOfThree(n);

            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void TestMethodIsPowerOfThree1()
        {
            var n = 45;

            var res = IsPowerOfThree(n);

            Assert.AreEqual(false, res);
        }

        [TestMethod]
        public void TestMethodRomanToInt()
        {
            var s = "MCMXCIV";

            var res = RomanToInt(s);

            Assert.AreEqual(1994, res);
        }

        [TestMethod]
        public void TestMethodHammingWeight()
        {
            uint n = 3;

            var res = HammingWeight(n);

            Assert.AreEqual(2, res);
        }

        [TestMethod]
        public void TestMethodHammingDistance()
        {

            var res = HammingDistance(3, 1);

            Assert.AreEqual(1, res);
        }

        [TestMethod]
        [Ignore]
        public void TestMethodreverseBits()
        {
            UInt32 expected = 1;

            var actual = reverseBits(7);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodreverseBits1()
        {
            UInt32 expected = 964176192;
            UInt32 input = 43261596;

            var actual = reverseBits(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodGenerate()
        {
            var actual = Generate(3);

            Assert.AreEqual(1, actual.First().First());
        }

        [TestMethod]
        public void TestMethodIsValidParentheses()
        {
            var s = "((()))"; 
            var actual = IsValid(s);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void TestMethodIsValidParentheses1()
        {
            var s = "((()))()()()";
            var actual = IsValid(s);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void TestMethodIsValidParentheses2()
        {
            var s = "))((()))()()()";
            var actual = IsValid(s);

            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void TestMethodMissingNumber()
        {
            var s = new int[3] { 3, 0, 1 };
            var actual = MissingNumber(s);

            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        public void TestMethodMinCostTrawerseLadder()
        {
            var s = new int[3] { 1, 3, 1 };
            var actual = MinCostTrawerseLadder(s,3);

            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        public void TestMethodMinCostTrawerseLadder1()
        {
            var s = new int[4] { 1, 2, 10, 2 };
            var actual = MinCostTrawerseLadder(s, 4);

            Assert.AreEqual(4, actual);
        }

        [TestMethod]
        public void TestMethodIsPerfectSquare()
        {

            var actual = IsPerfectSquare(16);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void TestMethodIsPerfectSquare1()
        {

            var actual = IsPerfectSquare(17);

            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void TestMethodIsPerfectSquare2()
        {

            var actual = IsPerfectSquare(598);

            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void TestMethodIsPowerOfTwo()
        {

            var actual = IsPowerOfTwo(4);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void TestMethodIsPowerOfTwo1()
        {

            var actual = IsPowerOfTwo(-2147483648);

            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void TestMethodRemoveAnagrams()
        {
            var arr = new string[5] { "abba", "baba", "bbaa", "cd", "cd" };

            var actual = RemoveAnagrams(arr);

            Assert.AreEqual(2, actual.Count);
        }

        [TestMethod]
        public void TestMethodRemoveAnagrams1()
        {
            var arr = new string[5] { "a", "b", "c", "d", "e" };

            var actual = RemoveAnagrams(arr);

            Assert.AreEqual(5, actual.Count);
        }

        [TestMethod]
        public void TestMethodRemoveAnagrams2()
        {
            var arr = new string[7] { "z", "z", "z", "gsw", "wsg", "gsw", "krptu" };

            var actual = RemoveAnagrams(arr);

            Assert.AreEqual(3, actual.Count);
        }

        [TestMethod]
        public void TestMethodRemoveAnagrams3()
        {
            var arr = new string[3] { "a", "b", "a" };
   
            var actual = RemoveAnagrams(arr);

            Assert.AreEqual(3, actual.Count);
        }

        public IList<string> RemoveAnagrams(string[] words)
        {
            var stack = new Stack<string>();
            for (int i = words.Length - 1; i >= 0; i--)
            {
                String s = words[i];
                while (stack.Count > 0 && IsAnagram(stack.Peek(), s) == true)
                    stack.Pop();
                stack.Push(s);
            }
            var res = new List<string>();
            while (stack.Count>0)
                res.Add(stack.Pop());
            return res;
        }

        /* 
        * удалить все анаграммы
        public IList<string> RemoveAnagrams(string[] words)
        {
            var ans = new List<string>();
            var removs = new bool[words.Length];
            for(var i=0; i<words.Length; i++)
            {
                for(var j=i+1; j<words.Length; j++)
                {
                    if (i == j)
                        continue;
                    if(IsAnagram(words[i], words[j]))
                    {
                        removs[j] = true;
                    }
                }
            }

            for (var i = 0; i < words.Length; i++)
            {
                if(!removs[i])
                    ans.Add(words[i]);
            }

            return ans;
        }*/

        public bool IsAnagram(string s, string t)
        {
            int[] alphabet = new int[26];
            for (int i = 0; i < s.Length; i++) alphabet[s[i] - 'a']++;
            for (int i = 0; i < t.Length; i++) alphabet[t[i] - 'a']--;
            foreach (int i in alphabet)
                if (i != 0) return false;
            return true;
        }

        public bool IsAnagram1(string s, string t)
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

        public bool IsPowerOfTwo(int n)
        {

            string code = Convert.ToString(n, 2);
            if (n<0 || code == string.Empty || code[0] != '1')
                return false;
            for(var i = 1; i < code.Length; i++)
            {
                if (code[i] != '0')
                    return false;
            }

            return true;
        }

        public bool IsPowerOfFour(int n)
        {
            if (n == 2)
                return false;
            string code = Convert.ToString(n, 2);
            if (n < 0 || code == string.Empty || code[0] != '1')
                return false;
            var cnt = 0;
            for (var i = 1; i < code.Length; i++)
            {
                if (code[i] != '0')
                    return false;
                cnt++;
            }

            return cnt % 2 == 0;
        }

        public int[] ArrayRankTransform(int[] arr)
        {
            var dict = new Dictionary<int, int>();

            var ans = new int[arr.Length];
            Array.Copy(arr, ans, arr.Length);

            foreach (var num in arr)
            {
                if (!dict.ContainsKey(num))
                    dict.Add(num, 0);
            }

            Array.Sort(arr);
            arr = arr.Distinct().ToArray();

            for (var i = 0; i < arr.Length; i++)
            {
                dict[arr[i]] = i + 1;
            }

            for (var i = 0; i < ans.Length; i++)
            {
                ans[i] = dict[ans[i]];
            }

            return ans;
        }

        public IList<int> TargetIndices(int[] nums, int target)
        {
            var ans = new List<int>();

            Array.Sort(nums);

            for(var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                    ans.Add(i);
            }
            return ans;
        }

        public bool IsPerfectSquare(int num)
        {
            /*
            brut force solution
            var n = 1;
            var i = 1;
            while (n < num)
            {
                n = i;
                n = n * n;
                i++;
            }
            return n == num;*/

            // use binary search
            var low = 1;
            var high = Math.Min(46340,num); 
            while (low < high)
            {
                var mid = (high + low) / 2;

                if (num < mid*mid)
                {
                    high = mid-1;
                }
                else if (num>mid*mid)
                {
                    low = mid+1;
                }
                else
                {
                    return true;
                }
            }


            return low*low==num;
        }



        public int MinCostTrawerseLadder(int[] nums, int rungCount)
        {
            var d = new int[nums.Length];
            d[0] = nums[0];
            d[1] = nums[1];
            for (var i = 2; i < rungCount; i++)
            {
                d[i] = Math.Min(d[i - 1], d[i - 2]) + nums[i];
            }

            return d[nums.Length - 1];
        }

        public int MissingNumber(int[] nums)
        {
            var sum = (nums.Length * (nums.Length + 1)) / 2;
            var sum1 = 0;
            foreach(var n in nums)
            {
                    sum1+=n;
            }

            return sum-sum1;
        }



        public bool IsValid(string s)
        {
            var stk = new Stack<char>();

            foreach(var chr in s)
            {
                if (chr == '(')
                    stk.Push(')');
                else if (chr == '[')
                    stk.Push(']');
                else if (chr == '{')
                    stk.Push('}');
                else if (stk.Count() == 0 || stk.Pop() != chr)
                    return false;
            }
            return stk.Count() == 0;
        }

        public IList<IList<int>> Generate(int numRows)
        {
            var result = new List<IList<int>>();

            for (int row = 1; row <= numRows; ++row)
            {
                int cnk = 1;
                var subList = new List<int>();

                for (int k = 1; k <= row; ++k)
                {

                    subList.Add(cnk);
                    cnk = cnk * (row - k) / k;

                }

                result.Add(subList);
            }

            return result;
        }

        public uint reverseBits(uint n)
        {
            uint result = 0;

            for (var i = 0; i < 32; i++)
            {
                // find the last bit of n
                var lastBit = n & 1;

                // shift the last bit of n to the left
                var reversedLastBit = lastBit << (31 - i);

                // insert the reversed last bit of n into the result
                result |= reversedLastBit;

                // the last bit of n is already taken care of, so we need to drop it
                n >>= 1;
            }

            // convert the result to an unsigned 32-bit integer
            return result;

           /* n = (n >> 16) | (n << 16);
            n = ((n & 0xff00ff00) >> 8) | ((n & 0x00ff00ff) << 8);
            n = ((n & 0xf0f0f0f0) >> 4) | ((n & 0x0f0f0f0f) << 4);
            n = ((n & 0xcccccccc) >> 2) | ((n & 0x33333333) << 2);
            n = ((n & 0xaaaaaaaa) >> 1) | ((n & 0x55555555) << 1);
            return n;*/
            /*var s = Convert.ToString(n, 2).ToCharArray();
            var l = 0;
            var r = s.Length - 1;
            while (l < r)
            {
                if (s[l] != s[r])
                {

                    var tmp = s[l];
                    s[l] = s[r];
                    s[r] = tmp;
                }
                l++;
                r--;
            }

            var res = new String(s);
            return Convert.ToUInt32(res.TrimStart('0'), 2);*/

        }

        public int HammingDistance(int x, int y)
        {
            var n = x ^ y;

            var count = 0;
            while (n != 0)
            {
                count++;
                n &= n - 1; //walking through all the bits which are set to one
            }

            return count;
        }

        public int HammingWeight(uint n)
        {
            return Convert.ToString(n, 2).Where(t => t == '1').Count();
        }

        public int RomanToInt(string s)
        {
            var q = new Queue<int>();

            var rNums = new Dictionary<char, int>() {
                { 'I', 1}, {'V', 5}, {'X',10}, {'L', 50},
                { 'C', 100}, {'D',500}, {'M',1000}};

            // full queue
            var chrs = s.ToCharArray();

            var k = 1;
            for (var i = 0; i<chrs.Length; i+=k)
            {
                if (i+1 < chrs.Length && rNums[chrs[i]] < rNums[chrs[i+1]])
                {
                    q.Enqueue(rNums[chrs[i+1]] - rNums[chrs[i]]);
                    k = 2;
                }
                else
                {
                    q.Enqueue(rNums[chrs[i]]);
                    k = 1;
                }

            }

            // create nomber
            var res = 0;
            while (q.Count > 0)
            {
                res += q.Dequeue();
            }
            return res;
        }

        public bool IsPowerOfThree(int n)
        {
            var l = Math.Log(n, 3);
            double eps = 1E-14; // Значение допустимой ошибки
            var prime = Math.Round(l);

            return (Math.Abs(prime - l) < eps) & (prime % 1 == 0);
        }

        public int CountPrimes(int n)
        {
            var isPrimes = new bool[n];

            // mark all nums arr primes
            for (var i = 2; i < n; i++)
                isPrimes[i] = true;

            for (var i = 2; i*i < n; i++)
            {
                if (isPrimes[i])
                {
                    for (var j = i*i; j < n; j+=i)
                    {
                        if ((j ) % (i ) == 0)
                            isPrimes[j] = false;      
                    }
                }
                
            }

            var num = 0;
            for (var i = 0; i < n; i++)
            {
                if (isPrimes[i]) num++;
            }

            return num;
        }

        public IList<string> FizzBuzz(int n)
        {
            var res = new List<string>();
            var curr = 1;
            while (curr <= n)
            {
                if (curr % 3 == 0 && curr % 5 == 0)
                {
                    res.Add("FizzBuzz");
                }
                else if(curr%5==0)
                {
                    res.Add("Buzz");
                }
                else if (curr % 3 == 0)
                {
                    res.Add("Fizz");
                }
                else
                {
                    res.Add(curr.ToString());
                }
                curr++;
            }

            return res; 
        }


        public TreeNode SortedArrayToBST(int[] nums)
        {
            if (nums==null || nums.Length == 0) return null;
            if (nums.Length == 1) return new TreeNode(nums[0]);

            var root = MakeBST(nums, 0, nums.Length - 1);

            return root;
        }
        
        TreeNode MakeBST(int[] nums, int low, int high)
        {
            if (low > high) return null;

            var mid = (low + high) / 2;

            var root = new TreeNode(nums[mid]);

            root.left = MakeBST(nums, low, mid-1);
            root.right = MakeBST(nums, mid+1, high);

            return root;
        }

         // Функция для вывода обхода заданного бинарного дерева по порядку уровней
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            var result = new List<IList<int>>();
            var que = new Queue<TreeNode>();

            if(root==null) return result;

            que.Enqueue(root);
            while (que.Count != 0)
            {
                int n = que.Count;
                var subList = new List<int>();
                
                // cycle by lvl nodes (BFS)
                for (int i = 0; i < n; i++)
                {
                    // add left child
                    if (que.Peek().left != null)
                        que.Enqueue(que.Peek().left);

                    // add right child
                    if (que.Peek().right != null)
                        que.Enqueue(que.Peek().right);
                    
                    // add ancestor in sublist
                    subList.Add(que.Dequeue().val);
                }
                result.Add(subList);
            }
            return result;
        }
        



        // Функция для вывода обхода заданного бинарного дерева по порядку уровней
        public IList<IList<int>> LevelOrder1(TreeNode root)
        {
            var res = new List<IList<int>>();
            var q = new Queue<TreeNode>();

            q.Enqueue(root);


            while (q.Count > 0)
            {
                int n = q.Count;
                var subList = new List<int>();
                
                // поочерёдно добавляем по уровням ноды в очередь, предыдущие ноды удаляем 
                // cycle by next lvl nodes (BFS)
                for (int i = 0; i < n; i++)
                {

                    if (q.Peek().left != null)
                    {
                        q.Enqueue(q.Peek().left);
                    }
                    if (q.Peek().right != null)
                    {
                        q.Enqueue(q.Peek().right);
                    }

                    subList.Add(q.Dequeue().val);
                }
                res.Add(subList);
            }

            return res;
        }

        // iterative solution
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null)
                return true;

            var stack = new Stack<Tuple<TreeNode, TreeNode>>();

            TreeNode left;
            TreeNode right;
            var p = root;

            stack.Push(new Tuple<TreeNode, TreeNode>(p.left, p.right));

            while (stack.Count > 0)
            {
                var tmp = stack.Pop();
                left = tmp.Item1;
                right = tmp.Item2;

                if (left == null && right == null) //left & right node is NULL 
                    continue;
                else if (left == null || right == null) //one of them is Not NULL
                    return left == right;

                if (left.val != right.val) return false;
                stack.Push(new Tuple<TreeNode, TreeNode>(left.left, right.right));
                stack.Push(new Tuple<TreeNode, TreeNode>(left.right, right.left));

            }


            return true;
        }

        // recursive solution
        /*public bool IsSymmetric(TreeNode root)
        {
            if (root == null)
                return true;

            return IsSummetricEqual(root.left, root.right);
        }

        public bool IsSummetricEqual(TreeNode left, TreeNode right)
        {
            if (left == null && right == null) //left & right node is NULL 
                return true;
            else if (left == null || right == null || left.val != right.val) 
                return false;

            return IsSummetricEqual(left.right, right.left) && IsSummetricEqual(left.left, right.right);
        }*/



        TreeNode prev;

        public bool IsValidBST(TreeNode root)
        {

            if (root == null)
                return true;

            if (!IsValidBST(root.left))
                return false;

            if (prev != null && prev.val >= root.val)
                return false;
            prev = root;

            if (!IsValidBST(root.right))
                return false;

            return true;
        }



        public int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;

            var left = MaxDepth(root.left);
            var right = MaxDepth(root.right);

            return left > right ? ++left : ++right;
        }


        public void Rotate(int[] nums, int k)
        {
            var len = nums.Length;
            if (len == 1) return;

            var res = new int[len];

            // если число обротов больше чем число элементов в массиве
            if (k >= len)
                k = k % len;

            var i = 0;
            while (i < len)
            {
                res[i] = nums[(len - k + i) % len];
                i++;
            }

            i = 0;
            while (i < len)
            {
                nums[i] = res[i];
                i++;
            }
        }


        public int MaxProfit(int[] prices)
        {
            var sum = 0;
            for (var i = 0; i < prices.Length - 1; i++)
            {
                if (prices[i + 1] > prices[i])
                    sum += prices[i + 1] - prices[i];
            }
            return sum;
        }

        public bool isValidSudoku1(char[][] board)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    //taking the element of current position
                    char ch = board[i][j];
                    //changing the current element to '.' and start checking the row
                    // col and the then 3x3 block
                    if (ch != '.')
                    {
                        board[i][j] = '.';
                        if (isValid(ch, board, i, j) == false) return false;
                        //if the sudoku is valid then switchback the element to what it was
                        board[i][j] = ch;
                    }
                }
            }
            return true;
        }

        //Function to check row, col and 3x3 block
        bool isValid(char ch, char[][] board, int row, int col)
        {
            for (int i = 0; i < 9; i++)
            {
                if (board[i][col] == ch) return false;
                if (board[row][i] == ch) return false;
                if (board[3 * (row / 3) + i / 3][3 * (col / 3) + i % 3] == ch) return false;
            }
            return true;
        }

        public bool IsValidSudoku(char[][] board)
        {
            var count = 0;
            var map = new Dictionary<char, int>();

            // rows
            while (count != 9)
            {
                for (int i = 0; i < 9; i++)
                {
                    char temp = board[count][i];
                    if (temp != '.')
                    {
                        if (!map.ContainsKey(temp))
                            map.Add(temp, i);
                        else
                            return false;
                    }
                }
                map.Clear();
                count++;
            }

            // columns
            count = 0;
            while (count != 9)
            {
                // HashMap<Character, Integer> map = new HashMap();
                for (int i = 0; i < 9; i++)
                {
                    char temp = board[i][count];
                    if (temp != '.')
                    {
                        if (!map.ContainsKey(temp))
                            map.Add(temp, i);
                        else
                            return false;
                    }
                }
                map.Clear();
                count++;
            }

            // subBoxes
            for (int row = 0; row < 9; row = row + 3)
            {
                for (int col = 0; col < 9; col = col + 3)
                {
                    if (!SubBox(board, row, col))
                        return false;
                }
            }
            return true;
        }

        public bool SubBox(char[][] board, int row, int col)
        {
            var map = new Dictionary<char, int>();

            for (int i = row; i < row + 3; i++)
            {
                for (int j = col; j < col + 3; j++)
                {
                    char temp = board[i][j];
                    if (temp != '.')
                    {
                        if (!map.ContainsKey(temp))
                            map.Add(temp, i);
                        else
                            return false;
                    }
                }
            }

            return true;
        }



        public void Rotate(int[][] matrix)
        {
            int t;
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = i; j < matrix[0].Length; j++)
                {
                    t = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = t;
                }
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                Array.Reverse(matrix[i]);
            }
        }

        public bool ContainsDuplicate(int[] nums)
        {
            var set = new HashSet<int>(nums);
            return set.Count != nums.Length;

            /*
                var set = new HashSet<int>();
                for(int i = 0; i < nums.Length ; i++)
                {
                    if(set.Add(nums[i]) == false)
                        return true;
                }
                
               return false;
             */
        }

        public int SingleNumber(int[] nums)
        {
            var res = 0;
            foreach (var num in nums)
                res ^= num;
            return res;
        }

        public int[] Intersect(int[] nums1, int[] nums2)
        {
            if (nums1.Length == 0)
                return nums1;
            if (nums2.Length == 0)
                return nums2;

            int[] copyOfRange(int[] src, int start, int end)
            {
                int len = end - start;
                int[] dest = new int[len];
                Array.Copy(src, start, dest, 0, len);
                return dest;
            }

            Array.Sort(nums1);
            Array.Sort(nums2);
            int i = 0, j = 0, k = 0;
            while (i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] < nums2[j])
                    i++;
                else if (nums2[j] < nums1[i])
                    j++;
                else if (nums1[i] == nums2[j])
                {
                    nums1[k++] = nums1[i];
                    i++;
                    j++;
                }
            }
            return copyOfRange(nums1, 0, k);
        }

        public int[] PlusOne(int[] digits)
        {
            var addPosition = false;

            for (var i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] + 1 == 10)
                {
                    digits[i] = 0;
                    addPosition = true;
                }
                else
                {
                    digits[i] = digits[i] + 1;
                    addPosition = false;
                    break;
                }
            }

            if (addPosition)
            {
                int[] res = new int[digits.Length + 1];
                res[0] = 1;
                for (var i = 1; i < digits.Length + 1; i++)
                    res[i] = digits[i - 1];
                return res;
            }

            return digits;
        }

        public string LongestCommonPrefix(string[] strs)
        {
            var first = strs.OrderBy((x) => x.Length).First();
            int index = 0;
            for (; index < first.Length; index++)
            {
                foreach (var item in strs)
                {
                    if (first[index] != item[index])
                    {
                        return first.Substring(0, index);
                    }
                }
            }
            return first.Substring(0, index);

            /*if (strs.Length == 0) return "";

            string pre = strs[0];

            for (int i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(pre) != 0 && pre != "")
                    pre = pre.Substring(0, pre.Length - 1);
            }

            return pre;*/

            /* var lIndx = 0;
                var wIndx = 1;
                var sb = new StringBuilder();

                // by letters
                while (lIndx < strs[0].Length)
                {
                    // by words
                    while ((wIndx < strs.Length) && (lIndx < strs[wIndx].Length))
                    {
                        // end of prefix
                        if (strs[0][lIndx] != strs[wIndx][lIndx])
                            break;
                        wIndx++;
                    }

                    if (wIndx < strs.Length) break;

                    sb.Append(strs[0][lIndx]);

                    // set starting position
                    wIndx = 1;
                    // set next letter
                    lIndx++;
                }

                return sb.ToString();*/
        }

        public int StrStr(string haystack, string needle)
        {
            /*if (needle.Length > haystack.Length)
                return -1;

            if (needle == haystack)
                return 0;

            var sub = string.Empty;

            for (var i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle[0])
                {
                    if (i + needle.Length <= haystack.Length)
                    {
                        sub = haystack.Substring(i, needle.Length);
                        if (sub == needle)
                            return i;
                    }
                }
            }

            return -1;*/
            /*
            for (int i = 0; ; i++)
            {
                for (int j = 0; ; j++)
                {
                    if (j == needle.Length) return i;
                    if (i + j == haystack.Length) return -1;
                    if (needle[j] != haystack[i + j]) break;
                }
            }
            
             */

            if ((needle == string.Empty) || (needle == haystack)) return 0;
            if (needle.Length > haystack.Length) return -1;

            var l = 0;
            var mCnt = 0;

            while (l < haystack.Length)
            {
                while ((l + mCnt < haystack.Length) && (haystack[l + mCnt] == needle[mCnt]))
                {
                    mCnt++;
                    if (mCnt == needle.Length) return l;
                }

                mCnt = 0;
                l++;

            }
            return -1;
        }

        public int MyAtoi(string s)
        {
            // ignore leading whitespaces
            s = s?.TrimStart();

            if (s.Length == 0) return 0;

            var isNegative = false;

            if ((s[0] == '+' || s[0] == '-'))
            {
                if (s.Length == 1) return 0;

                if (s[0] == '-')
                    isNegative = true;

                s = s.Remove(0, 1);
            }

            if ((s[0] <= '9') && (s[0] >= '0'))
            {
                s = s.TrimStart('0');
                if (s.Length == 0) return 0;
            }
            else
                return 0;

            var i = 0;
            var res = 0;
            while ((i < s.Length) && (s[i] <= '9') && (s[i] >= '0'))
            {
                var num = (int)Char.GetNumericValue(s[i]);

                if (Int32.MaxValue / 10 < res || Int32.MaxValue / 10 == res && Int32.MaxValue % 10 < num)
                    return !isNegative ? Int32.MaxValue : Int32.MinValue;

                res = res * 10 + num;
                i++;
            }

            return isNegative ? -res : res;
        }

        public bool IsPalindrome(string s)
        {
            // first 
            Regex rgx = new Regex("[^a-zA-Z0-9 ]");
            //s = new string(s.Where(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c) ).ToArray());
            s = rgx.Replace(s, "").Replace(" ", "").ToLower();
            // second 
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
            var temp = 0;
            var result = 0;

            while (x != 0)
            {
                var last_d = x % 10;
                temp = result * 10 + last_d;

                if ((temp - last_d) / 10 != result)
                    return 0;

                result = temp;
                x = x / 10;
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
                var tmp = s[l];
                s[l] = s[r];
                s[r] = tmp;

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

