using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProjectLeetCode
{
    [TestClass]
    public class AlgoritmsUnitTest
    {
        [TestMethod]
        public void TestMethodBinarySearch()
        {

            var nums = new int[6] { -1, 0, 3, 5, 9, 12 };

            var actual = Search(nums, 9);

            Assert.AreEqual(4, actual);
        }

        [TestMethod]
        public void TestMethodBinarySearch1()
        {

            var nums = new int[6] { -1, 0, 3, 5, 9, 12 };

            var actual = Search(nums, 2);

            Assert.AreEqual(-1, actual);
        }

        [TestMethod]
        public void TestMethodBinarySearch2()
        {

            var nums = new int[1] { 0 };

            var actual = Search(nums, 0);

            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void TestMethodBinarySearch3()
        {

            var nums = new int[1] { 5 };

            var actual = Search(nums, 0);

            Assert.AreEqual(-1, actual);
        }

        [TestMethod]
        public void TestMethodBinarySearch4()
        {

            var nums = new int[2] { 2, 5 };

            var actual = Search(nums, 5);

            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void TestMethodSearchInsert()
        {

            var nums = new int[4] { 1, 3, 5, 6 };

            var actual = SearchInsert(nums, 5);

            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        public void TestMethodSearchInsert1()
        {

            var nums = new int[4] { 1, 3, 5, 6 };

            var actual = SearchInsert(nums, 2);

            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void TestMethodSearchInsert2()
        {

            var nums = new int[4] { 1, 3, 5, 6 };

            var actual = SearchInsert(nums, 7);

            Assert.AreEqual(4, actual);
        }

        [TestMethod]
        public void TestMethodSortedSquares()
        {
            var nums = new int[5] { -4, -1, 0, 3, 10 };

            var actual = SortedSquares(nums);

            var expected = new int[5] { 0, 1, 9, 16, 100 };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodSortedSquares1()
        {
            var nums = new int[3] { 0, 3, 10 };

            var actual = SortedSquares(nums);

            var expected = new int[3] { 0, 9, 100 };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodSortedSquares2()
        {
            var nums = new int[3] { -2, -1, 0 };

            var actual = SortedSquares(nums);

            var expected = new int[3] { 0, 1, 4 };
            CollectionAssert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void TestMethodSortedSquares3()
        {
            var nums = new int[3] { -3, -2, -1 };

            var actual = SortedSquares(nums);

            var expected = new int[3] { 1, 4, 9 };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodRotateArray()
        {
            var nums = new int[7] { 1, 2, 3, 4, 5, 6, 7 };

            Rotate(ref nums, 3);

            var expected = new int[7] { 5, 6, 7, 1, 2, 3, 4 };
            CollectionAssert.AreEqual(expected, nums);
        }

        [TestMethod]
        public void TestMethodRotateArray1()
        {
            var nums = new int[4] { -1, -100, 3, 99 };

            Rotate(ref nums, 2);

            var expected = new int[4] { 3, 99, -1, -100 };
            CollectionAssert.AreEqual(expected, nums);
        }

        [TestMethod]
        public void TestMethodMoveZeroes()
        {
            var nums = new int[5] { 0, 1, 0, 3, 12 };

            MoveZeroes(ref nums);

            var expected = new int[5] { 1, 3, 12, 0, 0 };
            CollectionAssert.AreEqual(expected, nums);
        }

        [TestMethod]
        public void TestMethodMoveZeroes1()
        {
            var nums = new int[3] { 0, 0, 1 };

            MoveZeroes(ref nums);

            var expected = new int[3] { 1, 0, 0 };
            CollectionAssert.AreEqual(expected, nums);
        }

        [TestMethod]
        public void TestMethodMoveZeroes2()
        {
            var nums = new int[3] { 0, 0, 0 };

            MoveZeroes(ref nums);

            var expected = new int[3] { 0, 0, 0 };
            CollectionAssert.AreEqual(expected, nums);
        }

        [TestMethod]
        public void TestMethodTwoSum()
        {
            var nums = new int[4] { 2, 7, 11, 15 };

            var actual = TwoSum(nums, 9);

            var expected = new int[2] { 1, 2 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodTwoSum1()
        {
            var nums = new int[2] { -1, 0 };

            var actual = TwoSum(nums, -1);

            var expected = new int[2] { 1, 2 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodReverseString()
        {
            var s = "Hello!";
            var arr = s.ToCharArray();

            ReverseString(arr);

            var e = "!olleH";
            var expected = new int[2] { 1, 2 };

            CollectionAssert.AreEqual(arr, e.ToCharArray());
        }

        [TestMethod]
        public void TestMethodReverseString2()
        {
            var s = "Hello";
            var arr = s.ToCharArray();

            ReverseString(arr);

            var e = "olleH";
            var expected = new int[2] { 1, 2 };

            CollectionAssert.AreEqual(arr, e.ToCharArray());
        }

        [TestMethod]
        public void TestMethodReverseString1()
        {
            var s = "H";
            var arr = s.ToCharArray();

            ReverseString(arr);

            var e = "H";
            var expected = new int[2] { 1, 2 };

            CollectionAssert.AreEqual(arr, e.ToCharArray());
        }

        [TestMethod]
        public void TestMethodReverseWords()
        {
            var s = "Let's take LeetCode contest";

            var actual = ReverseWords(s);

            var expected = "s'teL ekat edoCteeL tsetnoc";
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void LengthOfLongestSubstring()
        {
            var s = "abcabcbb";

            var actual = LengthOfLongestSubstring(s);

            Assert.AreEqual(3, actual);
        }

        [TestMethod]
        public void TestMethodCheckInclusion()
        {
            var s1 = "ab";
            var s2 = "eidbaooo";

            var actual = CheckInclusion(s1, s2);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void TestMethodFloodFill()
        {
            // input  image = [[1,1,1],[1,1,0],[1,0,1]], sr = 1, sc = 1, color = 2
            // output [[2,2,2],[2,2,0],[2,0,1]]
            var img = new int[3][];
            img[0] = new int[3] { 1, 1, 1 };
            img[1] = new int[3] { 1, 1, 0 };
            img[2] = new int[3] { 1, 0, 1 };

            var sr = 1;
            var sc = 1;
            var color = 2;

            var actual = FloodFill(img, sr, sc, color);

            Assert.AreEqual(2, actual[0][0]);
        }

        [TestMethod]
        public void TestMethodSingleNumber()
        {
            var nums = new int[3] { 2, 2, 1 };

            var actual = SingleNumber(nums);

            Assert.AreEqual(1, actual);
        }

        //[TestMethod]
        //public void TestMethodHammingWeight()
        //{
        //    uint n = 00000000000000000000000000001011;

        //    var actual = HammingWeight(n);

        //    Assert.AreEqual(3, actual);
        //}

        [TestMethod]
        public void TestMethodIsPowerOfTwo()
        {
            int n = 1;

            var actual = IsPowerOfTwo(n);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void TestMethodIsPowerOfTwo1()
        {
            int n = 4;

            var actual = IsPowerOfTwo(n);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void TestMethodIsPowerOfTwo2()
        {
            int n = 3;

            var actual = IsPowerOfTwo(n);

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void TestMethodClimbStairs()
        {
            int n = 2;

            var actual = ClimbStairs(n);

            Assert.AreEqual(2, actual);
        }


        [TestMethod]
        public void TestMethodClimbStairs1()
        {
            int n = 5;

            var actual = ClimbStairs(n);

            Assert.AreEqual(8, actual);
        }

        [TestMethod]
        public void TestMethodHouseRobber()
        {
            int[] nums = new int[4] { 1, 2, 3, 1 };

            var actual = Rob(nums);

            Assert.AreEqual(4, actual);
        }

        [TestMethod]
        public void TestMethodHouseRobber1()
        {
            int[] nums = new int[5] { 2, 7, 9, 3, 1 };

            var actual = Rob(nums);

            Assert.AreEqual(12, actual);
        }

        [TestMethod]
        public void TestMethodHouseRobber3()
        {
            int[] nums = new int[4] { 2, 1, 1, 2 };

            var actual = RobN(nums);

            Assert.AreEqual(4, actual);
        }

        [TestMethod]
        public void TestMethodLongestPalindrome1()
        {
            var s = "ac";

            var actual = LongestPalindrome(s);

            Assert.AreEqual("a", actual);
        }

        [TestMethod]
        public void TestMethodLongestPalindrome2()
        {
            var s = "abb";
            var s1 = "NCeghBfGgcbjLCOGG18ESDj1liiZKfiV:lmOHwfBwPI2hQcah";
            var s3 = Convert.ToBase64String(Encoding.ASCII.GetBytes(s1));

            var actual = LongestPalindrome(s);

            Assert.AreEqual("bb", actual);
        }

        [TestMethod]
        public void TestMethodLongestPalindrome3()
        {
            var s = "abb";

            var actual = LongestPalindrome(s);

            Assert.AreEqual("bb", actual);
        }

        public IList<IList<string>> Partition(string s)
        {
            var res = new List<IList<string>>();
            /*
             
             задача разделить строки 

            */
            return res;
        }

        public string LongestPalindrome(string s)
        {
            var s1 = Reverse(s);
            var len = 0;
            var sb = new StringBuilder();

            // check classic palindrom
            var res = string.Empty;
            var maxLen = 0;
            for (var i = 0; i < s.Length; i++)
            {
                if (s[i] == s1[i])
                {
                    sb.Append(s[i]);
                    len++;
                }
                else
                {
                    if (len > maxLen)
                    {
                        maxLen = len;
                        res = sb.ToString();
                    }
                    sb.Clear();
                    len = 0;
                }
            }

            if (len > maxLen)
            {
                maxLen = len;
                res = sb.ToString();
            }

            // check dublicate chars
            sb.Clear();
            var dupCount = 0;
            var chr = '!';
            for (var i = 0; i < s.Length; i++)
            {
                if (chr == s[i])
                {
                    sb.Append(s[i]);
                    dupCount++;
                }
                else
                {

                }
            }

            if (res == string.Empty)
                res = s[0].ToString();

            return res;
        }

        string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        int RobN(int[] nums)
        {
            if (nums.Length == 1)
                return nums[0];

            if (nums.Length == 2)
                return Math.Max(nums[0], nums[1]);


            var i = 0;

            // first sum
            var rob = nums[0] + nums[2];

            // second sum
            var norob = nums[1];

            while (i < nums.Length)
            {
                rob = nums[i];


                i += 2;
            }

            return Math.Max(rob, norob);
        }


        //int robFive(int h1, int h2, int h3, int h4, int h5)
        //{
        //    var four = RobFour(h1, h2, h3, h4);
        //    var four2 = h1 + RobFour(h2, h3, h4, h5);
        //    return RobTwo(four, h1 + h4);
        //}

        //int RobFour(int h1, int h2, int h3, int h4)
        //{
        //    var two = RobTwo(h1 + h3, h2 + h4);
        //    return RobTwo(two, h1 + h4);
        //}

        int RobThree(int h1, int h2, int h3)
        {
            var sum = h1 + h3;

            return RobTwo(sum, h2);
        }

        int RobTwo(int h1, int h2)
        {
            return Math.Max(h1, h2);
        }

        public int Rob(int[] nums)
        {
            var ans1 = 0;
            var ans2 = 0;

            var rob = 0;
            var norob = 0;

            for (var i = 0; i < nums.Length; i += 2)
            {
                rob = nums[i];
                norob = Math.Max(rob, norob);// (i+1) < nums.Length?nums[i+1]:0;

                ans1 += rob;
                ans2 += Math.Max(rob, norob);
            }

            return Math.Max(ans1, ans2);
        }

        public int ClimbStairs(int n)
        {
            // base case
            if (n == 0 | n == 1 | n == 2)
                return n;
            var dict = new Dictionary<int, int>();
            // recurrency relation
            var ans = 0;
            ans += ClimbStairs1(n - 1, dict) + ClimbStairs1(n - 2, dict);
            return ans;
        }

        int ClimbStairs1(int n, Dictionary<int, int> dict)
        {
            // base case
            if (n == 0 | n == 1 | n == 2)
                return n;

            if (dict.ContainsKey(n))
                return dict[n];

            // recurrency relation
            var ans = 0;
            ans += ClimbStairs(n - 1) + ClimbStairs(n - 2);
            dict.Add(n, ans);

            return ans;
        }

        public bool IsPowerOfTwo(int n)
        {
            if (n == 0 || n == 1)
                return true;

            var str = ToBin(n);
            for (var i = 1; i < str.Length; i++)
            {
                if (str[i] == '1')
                    return false;
            }
            return true;
        }
        string ToBin(int n)
        {
            return string.Format("{0}{1}", n < 0 ? "-" : "", Convert.ToString(Math.Abs(n), 2));
        }

        public int HammingWeight(uint n)
        {
            int ans = 0;
            while (n > 0)
            {
                n = n & (n - 1);
                ans++; ;
            }
            return ans;
        }

        public int SingleNumber(int[] nums)
        {
            var res = 0;
            foreach (var num in nums)
                res ^= num;
            return res;
        }

        public int[][] FloodFill(int[][] image, int sr, int sc, int color)
        {
            int oldColor = image[sr][sc];
            if (oldColor != color)
                dfs(image, sr, sc, oldColor, color);
            return image;
        }

        public void dfs(int[][] image, int r, int c, int color, int newColor)
        {
            if (image[r][c] == color)
            {
                image[r][c] = newColor;
                if (r >= 1)
                    dfs(image, r - 1, c, color, newColor);
                if (c >= 1)
                    dfs(image, r, c - 1, color, newColor);

                if (r + 1 < image.Length)
                    dfs(image, r + 1, c, color, newColor);
                if (c + 1 < image[0].Length)
                    dfs(image, r, c + 1, color, newColor);
            }
        }

        public bool CheckInclusion(string s1, string s2)
        {
            if (s1.Length > s2.Length)
                return false;
            int[] s1map = new int[26];
            int[] s2map = new int[26];
            for (int i = 0; i < s1.Length; i++)
            {
                s1map[s1[i] - 'a']++;
                s2map[s2[i] - 'a']++;
            }

            int count = 0;
            for (int i = 0; i < 26; i++)
            {
                if (s1map[i] == s2map[i])
                    count++;
            }

            for (int i = 0; i < s2.Length - s1.Length; i++)
            {
                int r = s2[i + s1.Length] - 'a', l = s2[i] - 'a';
                if (count == 26)
                    return true;
                s2map[r]++;
                if (s2map[r] == s1map[r])
                {
                    count++;
                }
                else if (s2map[r] == s1map[r] + 1)
                {
                    count--;
                }
                s2map[l]--;
                if (s2map[l] == s1map[l])
                {
                    count++;
                }
                else if (s2map[l] == s1map[l] - 1)
                {
                    count--;
                }
            }
            return count == 26;
        }

        public int LengthOfLongestSubstring(string s)
        {
            int left = 0, right = 0;

            // initialize dictionary window
            // будем следить чтоб в окне не  было повторяющихся символов
            Dictionary<char, int> window = new Dictionary<char, int>();
            int res = 0; // запись самой длинной длины
            while (right < s.Length)
            {
                char c1 = s[right];
                if (!window.ContainsKey(c1))
                    window.Add(c1, 1);
                else
                    window[c1]++;
                // увеличиваем окно вправо
                right++;

                // Если в окне появляются повторяющиеся символы
                // начинаем двигаться влево, чтобы уменьшить окно
                while (window[c1] > 1)
                {
                    // берём левый крайний символ 
                    char c2 = s[left];
                    window[c2]--;
                    left++;
                }
                res = Math.Max(res, right - left);
            }
            return res;
        }

        public string ReverseWords(string s)
        {
            var words = s.Split(' ');
            var sb = new StringBuilder();
            for (var i = 0; i < words.Length; i++)
            {
                var chars = words[i].ToCharArray();
                ReverseString(chars);
                sb.Append(new string(chars) + " ");
            }

            return sb.ToString().TrimEnd();
        }

        public void ReverseString(char[] s)
        {
            var r = 0;
            var l = s.Length - 1;
            while (r < l)
            {
                var tmp = s[r];
                s[r] = s[l];
                s[l] = tmp;
                r++;
                l--;
            }
        }

        public int[] TwoSum(int[] numbers, int target)
        {
            var l = 0;
            var r = numbers.Length - 1;
            while (l < r)
            {
                var sum = numbers[l] + numbers[r];
                if (sum == target)
                {
                    return new int[] { l + 1, r + 1 };
                }
                else if (sum < target)
                {
                    l++;
                }
                else
                {
                    r--;
                }
            }
            return new int[2];

            /*var ans = new int[2];

            for(var i = 0; i < numbers.Length; i++)
            {
                // try binary search second item
                var left = i+1;
                var right = numbers.Length-1;
                var t = target - numbers[i];

                while (left < right)
                {
                    var middle = (right + left) / 2;

                    if (numbers[middle] < t)
                    {
                        left = middle + 1;
                    }
                    else
                    {
                        right = middle;
                    }
                }

                if (left<numbers.Length&&numbers[left] == t)
                {
                    ans[0] = i+1;
                    ans[1] = left+1;
                    return ans;
                }
            }

            return ans;*/
        }

        public void MoveZeroes(ref int[] nums)
        {
            // get zero count 
            var zeroCnt = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0) zeroCnt++;
            }

            if (zeroCnt > 0)
            {
                var curIndx = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] != 0)
                    {
                        nums[curIndx] = nums[i];
                        curIndx++;
                    }
                }

                for (int i = nums.Length - zeroCnt; i < nums.Length; i++)
                {
                    nums[i] = 0;
                }
            }
        }

        public void Rotate(ref int[] nums, int k)
        {
            if (nums == null || nums.Length <= 1)
            {
                return;
            }

            //k > n or k < n
            int len = nums.Length;
            k %= len;

            reverse(nums, 0, len - 1);
            reverse(nums, 0, k - 1);
            reverse(nums, k, len - 1);
        }

        private void reverse(int[] nums, int start, int end)
        {
            if (start >= end)
            {
                return;
            }
            while (start < end)
            {
                int tmp = nums[start];
                nums[start++] = nums[end];
                nums[end--] = tmp;
            }
        }

        public int[] SortedSquares(int[] nums)
        {
            var ans = new int[nums.Length];

            var sign = 0;
            // первый проход найти смену знака
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= 0)
                {
                    sign = i;
                    break;
                }
            }

            if (nums[nums.Length - 1] < 0)
                sign = nums.Length - 1;

            var left = sign - 1;
            var right = sign;

            var curIndx = 0;
            while (left >= 0 || right < nums.Length)
            {
                if (right < nums.Length && (left < 0 || Math.Abs(nums[left]) > nums[right]))
                {
                    ans[curIndx] = nums[right] * nums[right];
                    right++;
                }
                else
                {
                    ans[curIndx] = nums[left] * nums[left];
                    left--;
                }

                curIndx++;
            }

            return ans;
        }

        public int SearchInsert(int[] nums, int target)
        {
            var left = 0;
            var right = nums.Length - 1;

            while (left < right)
            {
                var middle = (right + left) / 2;

                if (nums[middle] < target)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle;
                }
            }

            if (nums[left] < target)
            {
                left++;
            }
            return left;
        }

        //public int FirstBadVersion(int n)
        //{
        //    long left = 1;
        //    long right = n;

        //    while (left < right)
        //    {
        //        var middle = (right + left) / 2;

        //        if (IsBadVersion((int)middle))
        //        {
        //            left = middle + 1;
        //        }
        //        else
        //        {
        //            right = middle;
        //        }
        //    }


        //    return (int)left;
        //}

        //private bool IsBadVersion(int n)
        //{
        //    return 4==n;
        //}

        /// <summary>
        /// binary search implementation
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int Search(int[] nums, int target)
        {
            var left = 0;
            var right = nums.Length - 1;

            while (left < right)
            {
                var middle = (right + left) / 2;

                if (nums[middle] < target)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle;
                }
            }


            return nums[left] == target ? left : -1;
        }
    }
}
