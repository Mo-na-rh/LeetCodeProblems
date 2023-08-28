using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestProjectLeetCode
{
    [TestClass]
    public class UnitTestHardProblems
    {
        [TestMethod]
        public void ExistSequence_GetLength_ShouldReturnLengthOfMaxValidSequence()
        {
            // arrange 
            var s = "()(()";

            // act
            var actual = GetLengthOfMaxValidSequence(s);

            // Assert
            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        public void ExistSequence_GetLength_ShouldReturnLengthOfMaxValidSequence1()
        {
            // arrange 
            var s = "()(()()()((((";

            // act
            var actual = GetLengthOfMaxValidSequence(s);

            // Assert
            Assert.AreEqual(6, actual);
        }

        [TestMethod]
        public void ExistSequence_GetLength_ShouldReturnLengthOfMaxValidSequence2()
        {
            // arrange 
            var s = "()(()()(()";

            // act
            var actual = GetLengthOfMaxValidSequence(s);

            // Assert
            Assert.AreEqual(4, actual);
        }

        [TestMethod]
        public void ExistTwoSortedArrays_GetMedian_SouldReturnCorrectAnswer()
        {
            // arrange
            var nums1 = new int[2] { 1, 3 };
            var nums2 = new int[1] { 2 };

            // act
            var actual = FindMedianSortedArrays(nums1, nums2);

            // assert
            var expected = 2.00;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ExistTwoSortedArrays_GetMedian_SouldReturnCorrectAnswer1()
        {
            // arrange
            var nums1 = new int[2] { 1, 2 };
            var nums2 = new int[2] { 3, 4 };

            // act
            var actual = FindMedianSortedArrays(nums1, nums2);

            // assert
            var expected = 2.5;
            Assert.AreEqual(expected, actual);
        }

        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            if (nums1.Length > nums2.Length)
                return FindMedianSortedArrays(nums2, nums1);

            // первый самый большой
            // второй поменьше 

            int len1 = nums1.Length;
            int len2 = nums2.Length;

            int low = 0;
            int high = len1;

            // интервал указателей от 0 до n + m
            while (low <= high)
            {
                // делим пополам больший массив 
                var cut1 = (low + high) / 2;               // cut of first array
                var cut2 = (len1 + len2 + 1) / 2 - cut1;   // cut of second array

                int max1 = (cut1 == 0) ? int.MinValue : nums1[cut1 - 1];
                int max2 = (cut2 == 0) ? int.MinValue : nums2[cut2 - 1];

                int min1 = (cut1 == len1) ? int.MaxValue : nums1[cut1];
                int min2 = (cut2 == len2) ? int.MaxValue : nums2[cut2];

                if (max1 <= min2 && max2 <= min1)
                {
                    // если результирующий массив чётной длины то делим на 2 соседние срединные элементы
                    if ((len1 + len2) % 2 == 0)         // if the total size is even
                        return ((double)(Math.Max(max1, max2) + Math.Min(min1, min2)) / 2);
                    // иначе берём срединный элемент из какого то из двух массивов
                    else                                // size is odd
                        return ((double)Math.Max(max1, max2));
                }
                else if (max1 > min2) //nums1[cut1-1] > nums1[cut2]
                    high = cut1 - 1;
                else if (max2 > min1) //nums2[cut2-1] > nums1[cut1]
                    low = cut1 + 1;
            }
            return 0;
        }

        /// <summary>
        /// Получение медианы в подмассиве по двум указателям
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <param name="nums"></param>
        /// <returns></returns>
        private double GetMedian(int left, int right, int[] nums)
        {
            var size = right - left;
            int mid = size / 2;
            return (size % 2 != 0) ? (double)nums[mid] : ((double)nums[mid] + (double)nums[mid - 1]) / 2;
        }

        public int GetLengthOfMaxValidSequence(string s)
        {
            var stk = new Stack<char>();

            // len
            var maxLen = 0;
            // при каждом обнулении стэка накопленную сумму зануляем
            var accumulatedSum = 0;
            for (var i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    stk.Push(s[i]);
                }
                else
                {

                    if (stk.Count == 0)
                    {
                        maxLen = Math.Max(maxLen, accumulatedSum);
                        accumulatedSum = 0;
                    }
                    if (stk.Count > 0)
                    {
                        stk.Pop();
                        accumulatedSum += 2;
                    }
                }
            }

            return Math.Max(maxLen, accumulatedSum);
        }
    }
}
