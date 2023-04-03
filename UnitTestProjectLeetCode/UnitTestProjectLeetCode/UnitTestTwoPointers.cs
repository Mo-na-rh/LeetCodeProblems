using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestProjectLeetCode
{
    [TestClass]
    public class UnitTestTwoPointers
    {
        [TestMethod]
        public void TestMethodThreeSum()
        {
            // arrange 
            var nums = new int[6] { -1, 0, 1, 2, -1, -4 };

            // act
            var actual = ThreeSum(nums);

            // assert
            var expected = new List<IList<int>>();
            var ex1 = new List<int>() { -1, -1, 2 };
            var ex2 = new List<int>() { -1, 0, 1 };
            expected.Add(ex1);
            expected.Add(ex2);
            Assert.AreEqual(expected.Count, actual.Count);

        }

        [TestMethod]
        public void TestMethodThreeSumClosest()
        {
            // arrange 
            var nums = new int[4] { -1, 2, 1, -4 };
            var target = 1;

            // act
            var actual = ThreeSumClosest(nums, target);

            // assert
            var expected = 2;
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethodThreeSumClosest1()
        {
            // arrange 
            var nums = new int[3] { 0, 0, 0 };
            var target = 1;

            // act
            var actual = ThreeSumClosest(nums, target);

            // assert
            var expected = 0;
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethodThreeSumClosest2()
        {
            // arrange 
            var nums = new int[9] { 4, 0, 5, -5, 3, 3, 0, -4, -5 };
            var target = -2;

            // act
            var actual = ThreeSumClosest(nums, target);

            // assert
            var expected = -2;
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethodLetterCombinations()
        {
            // arrange 
            var digits = "23";

            // act
            var actual = LetterCombinations(digits);

            // assert
            var expected = new string[9] { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" };
            Assert.AreEqual(expected.Length, actual.Count);

        }

        public IList<string> LetterCombinations(string digits)
        {
            var mapping = new Dictionary<char, List<char>>
                {
                { '2', new List<char>{ 'a', 'b', 'c' } },
                { '3', new List<char>{ 'd', 'e', 'f' } },
                { '4', new List<char>{ 'g', 'h', 'i' } },
                { '5', new List<char>{ 'j', 'k', 'l' } },
                { '6', new List<char>{ 'm', 'n', 'o' } },
                { '7', new List<char>{ 'p', 'q', 'r', 's' } },
                { '8', new List<char>{ 't', 'u', 'v' } },
                { '9', new List<char>{ 'w', 'x', 'y', 'z' } },
                };
            return LetterCombinationsInner(new List<string>(), "", digits.ToCharArray(), mapping);
        }

        public List<string> LetterCombinationsInner(List<string> acc, string prefix, char[] remaining, Dictionary<char, List<char>> mapping)
        {
            if (remaining.Length > 0)
            {
                var d = remaining[0];
                foreach (var c in mapping[d])
                {
                    var prefix2 = $"{prefix}{c}";
                    char[] r = GetArrayMinusOne(remaining);
                    LetterCombinationsInner(acc, prefix2, r, mapping);
                }
            }
            if (remaining.Length == 0)
            {
                if (prefix != "")
                {
                    acc.Insert(0, prefix);
                }
                return acc;
            }
            return acc;
        }

        private char[] GetArrayMinusOne(char[] remaining)
        {
            var res = new char[remaining.Length - 1];

            Array.Copy(remaining, 1, res, 0, res.Length);

            return res;
        }

        public int ThreeSumClosest(int[] nums, int target)
        {
            var res = int.MaxValue;

            var len = nums.Length;

            // sort array elements
            Array.Sort(nums);

            for (var i = 0; i < len - 2; i++)
            {
                var left = i + 1;
                var right = len - 1;
                while (left < right)
                {
                    var total = nums[i] + nums[left] + nums[right];
                    if (total == target)
                    {
                        return total;
                    }
                    if (diff(total, target) < diff(res, target))
                    {
                        res = total;
                    }

                    if (total < target)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }

                }

            }

            return res;
        }

        private int diff(int first, int second)
        {
            return Math.Abs(first - second);
        }

        public IList<IList<int>> ThreeSum(int[] nums)
        {


            //Array.Sort(nums);

            //if (nums[0] > 0)
            //    return res; 


            //for(var k = 0; k < nums.Length; k++)
            //{
            //    var localTarget = nums[k];
            //    // two pointers teknique check if 
            //    var l = k + 1;
            //    var r = nums.Length - 1;
            //    while (l < r)
            //    {
            //        if (nums[l] + nums[r] + localTarget==0)
            //        {
            //            // add triplet
            //        }
            //        else if(nums[l] + nums[r] + localTarget < 0)
            //        {
            //            l++;
            //        }
            //        else
            //        {
            //            r--;
            //        }
            //    }

            //}

            var res = new List<IList<int>>();

            HashSet<string> ss = new HashSet<string>();

            var arr_size = nums.Length;
            var sum = 0;

            // Fix the first element as nums[i]
            for (int i = 0; i < arr_size - 2; i++)
            {

                // Find pair in subarray A[i+1..n-1]
                // with sum equal to sum - A[i]
                HashSet<int> s = new HashSet<int>();
                int curr_sum = sum - nums[i];
                for (int j = i + 1; j < arr_size; j++)
                {
                    if (s.Contains(curr_sum - nums[j]))
                    {
                        var triplet = new int[3] { nums[i], nums[j], curr_sum - nums[j] };
                        Array.Sort(triplet);
                        var uniqSS = triplet[0] + "_" + triplet[1] + "_" + triplet[2];
                        if (!ss.Contains(uniqSS))
                        {
                            res.Add(triplet);
                            ss.Add(uniqSS);
                        }

                        continue;
                    }
                    s.Add(nums[j]);
                }
            }

            //var actualRes = new List<IList<int>>();
            //actualRes.AddRange(res);
            //foreach (var item in res)
            //{
            //    //Array.Sort(item);
            //    //if (actualRes.FirstOrDefault(t => t[0] == item[0] && t[1] == item[1] && t[2] == item[2]) == null)
            //        actualRes.Add(item);
            //}


            return res;
        }
    }
}
