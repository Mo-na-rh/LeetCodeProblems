﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;
using System.Linq;

namespace UnitTestProject2
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

            Assert.AreEqual(1702766719,bad);
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

        public bool IsPalindrome(string s)
        {
            // first 
            Regex rgx = new Regex("[^a-zA-Z0-9 ]");
            //s = new string(s.Where(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c) ).ToArray());
            s=rgx.Replace(s, "").Replace(" ","").ToLower();
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
                    dict.Add(chars[i],1);
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
            var r = s.Length-1;

            while (l<r)
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
    }
}
