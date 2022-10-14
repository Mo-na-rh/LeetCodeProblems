using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLeetCodeProjects
{
    [TestClass]
    public class UnitTestEasyProblems
    {
        [TestMethod]
        public void TestMethodExistNumberShouldReturnNumberOfStepsToZero()
        {

            var actual = NumberOfSteps(14);

            Assert.AreEqual(6, actual);
        }

        [TestMethod]
        public void TestMethodRunningSum()
        {
            var arr = new int[3] { 1, 1, 1 };

            var actual = RunningSum(arr);

            Assert.AreEqual(3, actual[2]);
        }

        [TestMethod]
        public void TestMethodMaximumWealth()
        {
            var arr = new int[2][];
            arr[0] = new int[3] { 1, 2, 3};
            arr[1] = new int[3] { 3, 2, 1 };

            var actual = MaximumWealth(arr);

            Assert.AreEqual(6, actual);
        }

        [TestMethod]
        public void TestMethodCanConstruct()
        {
            var actual = CanConstruct("aa", "aab");

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void TestMethodCanConstruct1()
        {
            var actual = CanConstruct("ac", "abb");

            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void TestMethodCanConstruct2()
        {
            var actual = CanConstruct("aa", "ab");

            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void TestMethodGetShuffle()
        {
            var nums = new int[3] { 1, 2, 3 };
            Solution obj = new Solution(nums);
            int[] param_1 = obj.Reset();
            int[] param_2 = obj.Shuffle();


            Assert.AreEqual(3, param_1.Count());
        }

        [TestMethod]
        public void TestMethodIsPalindrome()
        {
            var num = 121;

            var actual = IsPalindrome(num);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void TestMethodIsPalindrome1()
        {
            var num = -121;

            var actual = IsPalindrome(num);

            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void TestMethodSearchInsert()
        {
            var arr = new int[4] { 1, 3, 5, 6 };

            var actual = SearchInsert(arr, 5);

            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        public void TestMethodSearchInsert1()
        {
            var arr = new int[4] { 1, 3, 5, 6 };

            var actual = SearchInsert(arr, 2);

            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void TestMethodSearchInsert2()
        {
            var arr = new int[4] { 1, 3, 5, 6 };

            var actual = SearchInsert(arr, 7);

            Assert.AreEqual(4, actual);
        }

        [TestMethod]
        public void TestMethodLengthOfLastWord()
        {

            var actual = LengthOfLastWord("   fly me   to   the moon  ");

            Assert.AreEqual(4, actual);
        }

        [TestMethod]
        public void TestMethodSqrt()
        {

            var actual = MySqrt(8);

            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        public void TestMethodSqrt1()
        {

            var actual = MySqrt(2147395600);

            Assert.AreEqual(46340, actual);
        }

        [TestMethod]
        public void TestMethodAddBinary()
        {
            var actual = AddBinary("11","1");

            Assert.AreEqual("100", actual);
        }

        [TestMethod]
        public void TestMethodAddBinary1()
        {

            var actual = AddBinary("111", "11");

            Assert.AreEqual("1010", actual);
        }

        [TestMethod]
        public void TestMethodAddBinary2()
        {

            var actual = AddBinary("1010", "1011");

            Assert.AreEqual("10101", actual);
        }

        [TestMethod]
        public void TestMethodConvertToTitle()
        {
            // first
            var actual = ConvertToTitle(1);
            Assert.AreEqual("A", actual);

            // second
            actual = ConvertToTitle(28);
            Assert.AreEqual("AB", actual);

            // third
            actual = ConvertToTitle(52);
            Assert.AreEqual("AZ", actual);

            // four
            actual = ConvertToTitle(701);
            Assert.AreEqual("ZY", actual);
        }

        [TestMethod]
        public void TestMethodMajorityElement()
        {
            var arr = new int[3] { 2, 3, 3 };
            var actual = MajorityElement(arr);

            Assert.AreEqual(3, actual);
        }

        [TestMethod]
        public void TestMethodConvertTitleToNum()
        {
            // first
            var actual = TitleToNumber("A");
            Assert.AreEqual(1, actual);

            // second
            actual = TitleToNumber("AB");
            Assert.AreEqual(28, actual);

            // third
            actual = TitleToNumber("AZ");
            Assert.AreEqual(52, actual);

            // four
            actual = TitleToNumber("ZY");
            Assert.AreEqual(701, actual);
        }

        [TestMethod]
        public void TestMethodIsHappy()
        {
            var actual = IsHappy(19);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void TestMethodIsHappy1()
        {
            var actual = IsHappy(2);

            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void TestMethodIsIsomorphic()
        {
            var actual = IsIsomorphic("add","egg");

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void TestMethodIsIsomorphic1()
        {
            var actual = IsIsomorphic("bar", "egg");

            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void TestMethodWordPattern()
        {
            var actual = WordPattern("abba", "dog cat cat dog");

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void TestMethodContainsNearbyDuplicate()
        {
            var arr = new int[4] { 1, 2, 3, 1 };
            var actual = ContainsNearbyDuplicate(arr, 3);

            Assert.AreEqual(true, actual);
        }

        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            var dict = new Dictionary<int, int>();
            var ans = false;
            for (var i =0; i<nums.Length;i++)
            {
                if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], i);
                }
                else
                {
                    if (Math.Abs(i - dict[nums[i]]) <= k)
                    {
                        ans = true;
                        break;
                    }
                    else
                    {
                        dict[nums[i]] = i;
                    }
                }

            }
            return ans;

        }

        public bool IsIsomorphic(string s, string t)
        {
            if (s.Length == t.Length)
            {
                var dict = new Dictionary<Char, Char>();
                for(var i = 0; i < s.Length; i++)
                {
                    if (!dict.ContainsKey(s[i]))
                    {
                        if (dict.ContainsValue(t[i]))
                            return false;

                        dict.Add(s[i], t[i]);
                    }
                    if (dict[s[i]] != t[i])
                        return false;
                }
                return true;
            }
            return false;
        }

        public bool WordPattern(string pattern, string s)
        {
            var dict = new Dictionary<char, string>();
            var t = s.Split(' ');
            if (pattern.Length == t.Length)
            {
                for (var i = 0; i < pattern.Length; i++)
                {
                    if (!dict.ContainsKey(pattern[i]))
                    {
                        if (dict.ContainsValue(t[i]))
                            return false;

                        dict.Add(pattern[i], t[i]);
                    }
                    if (dict[pattern[i]] != t[i])
                        return false;
                }
                return true;
            }
            return false;
        }

        public bool IsHappy(int n)
        {
            // для проверки на цикл
            var seen = new HashSet<int>();
            // либо n == 1 либо мы обнаруживаем цикл ( бесконечно возрастать они не могут)
            while (n != 1 && !seen.Contains(n))
            {
                seen.Add(n);
                // меняем число
                n = getNext(n);
            }
            return n == 1;
        }

        private int getNext(int n)
        {
            int totalSum = 0;
            
            // проход по всем разрядам числа
            while (n > 0)
            {
                // искомое число
                int d = n % 10;
                // снижаем разряд
                n = n / 10;
                // суммируем
                totalSum += d * d;
            }
            // результат сумма квадратов
            return totalSum;
        }

        public int TitleToNumber(string columnTitle)
        {
            int res = 0;
            int sz = columnTitle.Length;

            for(var i = 0; i < sz; i++)
            {
                res += (columnTitle[i] - 'A' + 1) * Convert.ToInt32(Math.Pow(26, sz-i-1)); // pow(26, sz - i - 1); // 
            }

            return res;
        }

        int pow(int n, int k)
        {
            return k>0 ? n * pow(n, k - 1) : 1;
        }

        public int MajorityElement(int[] nums)
        {
            int count = 0;
            int candidate = 0;

            foreach (var num in nums)
            {
                if (count == 0)
                {
                    candidate = num;
                }
                count += (num == candidate) ? 1 : -1;
            }

            return candidate;
            /* classic
            var dict = new Dictionary<int, int>();

            foreach(var num in nums)
            {
                if (!dict.ContainsKey(num))
                    dict.Add(num, 0);

                dict[num]++;
            }
            var rule = nums.Length / 2;
            foreach (var num in nums)
            {
                if (dict[num] > rule) return num;
            }
            return 0;*/
        }

        public string ConvertToTitle(int columnNumber)
        {   /*
            // best
            return columnNumber == 0 ? "" : ConvertToTitle(--columnNumber / 26) + (char)('A' + (columnNumber % 26));
            */
            
            // real solution
            string res = "";
            while (columnNumber != 0)
            {
                char ch = (char)((columnNumber - 1) % 26 + 'A');
                columnNumber = (columnNumber - 1) / 26;
                res = ch + res;
            }
            return res;

            /*var dict = new Dictionary<int, string>()
        {
            { 1, "A"},
            { 2, "B"},
            { 3, "C"},
            { 4, "D"},
            { 5, "E"},
            { 6, "F"},
            { 7, "G"},
            { 8, "H"},
            { 9, "I"},
            { 10, "J"},
            { 11, "K"},
            { 12, "L"},
            { 13, "M"},
            { 14, "N"},
            { 15, "O"},
            { 16, "P"},
            { 17, "Q"},
            { 18, "R"},
            { 19, "S"},
            { 20, "T"},
            { 21, "U"},
            { 22, "V"},
            { 23, "W"},
            { 24, "X"},
            { 25, "Y"},
            { 26, "Z"}
        };
        var stk = new Stack<string>();

        while (columnNumber > 26)
        {
            var indx = columnNumber % 26;
            if (indx > 0)
            {
                stk.Push(dict[indx]);
                columnNumber = columnNumber / 26;
            }
            else
            {
                indx = 26;
                stk.Push(dict[indx]);
                columnNumber = columnNumber / 26;
                columnNumber--;
            }


        }

        stk.Push(dict[columnNumber]);

        var sb = new StringBuilder();
        while (stk.Count != 0)
        {
            sb.Append(stk.Pop());
        }

        return sb.ToString();*/
        }

        public string AddBinary(string a, string b)
        {
            int len = Math.Max(a.Length, b.Length);
            int temp = 0, carry = 0;
            String res = "";
            for (int i = 0; i < len; i++)
            {
                int p = (i < a.Length) ? (a[a.Length - i - 1] - '0') : 0;
                int q = (i < b.Length) ? (b[b.Length - i - 1] - '0') : 0;

                temp = p + q + carry;
                carry = temp / 2;
                res = temp % 2 + res;//this is to get the reaminder/answer and add it to res
                                     //here res is the sum
            }

            return (carry == 0) ? res : "1" + res;
            /*string ans = string.Empty;
            int i = a.Length - 1, j = b.Length - 1;
            int carry = 0;
            while (carry==1 || i >= 0 || j >= 0)
            {
                if (i >= 0)
                {
                    carry += a[i] - '0';
                    i--;
                }
                if (j >= 0)
                {
                    carry += b[j] - '0';
                    j--;
                }
                ans += carry % 2 + '0';
                carry = carry / 2;
            }
            //reverse(ans.begin(), ans.end());
            return ReverseString(ans);*/
            /*if (a[0] == '\0' && b[0] == '\0') return "0";
            var maxS = string.Empty;
            var minS = string.Empty;

            if (a.Length > b.Length)
            {
                maxS = ReverseString(a);
                minS = ReverseString(b);
            }
            else
            {
                maxS = ReverseString(b);
                minS = ReverseString(a);
            }

            var next = '0';
            var indx = 0;
            var res = new char[maxS.Length + 1];

            // main part
            while (indx < minS.Length)
            {
                var w = maxS[indx];
                var c = minS[indx];

                if (w == '1' && c == '1')
                {
                    res[indx] = next;
                    next = '1';
                }
                else if (w == '0' && c == '0')
                {
                    res[indx] = next;
                    next = '0';
                }
                else
                {
                    if (next == '1')
                    {
                        res[indx] = '0';
                        next = '1';
                    }
                    else
                    {
                        res[indx] = '1';
                        next = '0';
                    }
                }
                indx++;
            }

            while (indx < maxS.Length)
            {
                if (next == '1')
                {
                    if (maxS[indx] == '1')
                    {
                        res[indx] = '0';
                        next = '1';
                    }
                    else
                    {
                        res[indx] = next;
                        next = '0';
                    }
                }
                else
                {
                    res[indx] = maxS[indx];
                }
                indx++;
            }

            if (next == '1')
            {
                res[indx] = next;
            }

            var r= ReverseString(new string(res));
            if (r[0] == '\0')
            {
                r = r.Remove(0, 1);
            }*/
            //return r; 
        }

        string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public int MySqrt(int x)
        {
            long low = 1;
            long high = x;
            long ans = 0;

            while (low <= high)
            {
                long mid = low + (high - low) / 2;

                if (mid * mid == x)
                    return (int)mid;

                if (mid * mid > x)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                    ans = mid;
                }
            }
            return (int)ans;
        }

        

        public int LengthOfLastWord(string s)
        {
            int i = s.Length - 1;
            while (s[i] == ' ') i--;
            int word_start = i;
            for (; i >= 0; i--)
                if (s[i] == ' ') break;
            return word_start - i;
            /*var res = s.Trim();

            if (res.Contains(' '))
                res = res.Remove(0, res.LastIndexOf(' ')+1);

            return res.Length;*/
        }

        public int SearchInsert(int[] nums, int target)
        {
            var i = 0;
            while (i < nums.Length && nums[i] < target)
            {
                if (nums[i] == target)
                    return i;
                i++;
            }

            return i;
        }

        public bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;

            int temp = x;  //Declare a temporary variable with the value of the original number

            int b = 0;  //Number inverted

            while (temp != 0)
            {
                b = b * 10 + temp % 10;  //Reverse the number by digits 
                temp /= 10;  //Discard the last digit 
            }
            return x == b;
        }


        public bool CanConstruct(string ransomNote, string magazine)
        {
            var dict = new Dictionary<char,int>();

            foreach (var letter in magazine)
            {
                if (!dict.ContainsKey(letter))
                    dict.Add(letter, 1);
                else
                    dict[letter]++;
            }

            foreach(var letter in ransomNote)
            {
                if (dict.ContainsKey(letter))
                {
                    dict[letter]--;
                    if (dict[letter] < 0)
                        return false;
                }
                else
                {
                    return false;
                }
                    
            }
            return true;
        }

        public int MaximumWealth(int[][] accounts)
        {
            var maxSum = 0;
            foreach(var arr in accounts)
            {
                var sum = 0;

                foreach (var num in arr)
                    sum += num;

                if (sum > maxSum)
                    maxSum = sum;
            }

            return maxSum;
        }

        public int[] RunningSum(int[] nums)
        {
            var sum = 0;
            for (var i=0; i<nums.Length; i++)
            {
                sum += nums[i];

                nums[i] = sum;
            }

            return nums;
        }

        public int NumberOfSteps(int num)
        {
            var count = 0;
            while (num > 0)
            {
                if ((num & 1) == 0)
                    num = num / 2;
                else
                    num--;

                count++;
            }

            return count;
        }


        public class Solution
        {
            private int[] original;

            private int[] array;

            private Random rand = new Random();

            private List<int> getArrayCopy()
            {
                List<int> asList = new List<int>();
                for (int i = 0; i < array.Length; i++)
                {
                    asList.Add(array[i]);
                }
                return asList;
            }

            public Solution(int[] nums)
            {
                array = nums;
                original = (int[])nums.Clone();
            }

            public int[] Reset()
            {
                array = original;
                original = (int[])original.Clone();
                return array;
            }

            public int[] Shuffle()
            {
                List<int> aux = getArrayCopy();

                for (int i = 0; i < array.Length; i++)
                {
                    int removeIdx = rand.Next(aux.Count);
                    array[i] = aux[removeIdx];
                    aux.RemoveAt(removeIdx);
                }

                return array;
            }
        }

        public class MyStack
        {
            Queue<int> _q;

            public MyStack()
            {
                _q = new Queue<int>();
            }

            public void Push(int x)
            {
                _q.Enqueue(x);

                var sz = _q.Count();
                while (sz > 1)
                {
                    _q.Enqueue(_q.Dequeue());
                    sz--;
                }
            }

            public int Pop()
            {
                if (!Empty())
                    return _q.Dequeue();
                else
                    return 0;
            }

            public int Top()
            {
                if (!Empty())
                    return _q.Peek();
                else
                    return 0;
            }

            public bool Empty()
            {
                return _q.Count == 0;
            }
        }

        public class MyQueue
        {
            Stack<int> s1;
            Stack<int> s2;
            int front;

            public MyQueue()
            {
                s1 = new Stack<int>();
                s2 = new Stack<int>();
            }

            public void Push(int x)
            {
                if (s1.Count == 0)
                    front = x;
                s1.Push(x);
            }

            public int Pop()
            {
                if (s2.Count==0)
                {
                    while (s1.Count!=0)
                        s2.Push(s1.Pop());
                }
                return s2.Pop();
            }

            public int Peek()
            {
                if (s2.Count > 0)
                    return s2.Peek();
                return front;
            }

            public bool Empty()
            {
                return (s1.Count == 0) && (s2.Count == 0);
            }
        }
    }
}
