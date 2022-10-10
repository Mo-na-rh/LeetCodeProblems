using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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

            var expected = new int[3] { 0, 9,100 };
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

            var expected = new int[3] { 1,0,0 };
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
                    left = middle+1;
                }
                else
                {
                    right = middle;
                }
            }


            return nums[left]==target?left:-1;
        }
    }
}
