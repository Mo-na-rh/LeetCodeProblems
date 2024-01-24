using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestProjectLeetCode.BinarySearch
{
    /// <summary>
    /// Summary description for UnitTestBinarySearch
    /// </summary>
    [TestClass]
    public class UnitTestBinarySearch
    {
        public UnitTestBinarySearch()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMethodSearchRange()
        {
            var nums = new int[6] { 5, 7, 7, 8, 8, 10 };

            var actual = SearchRange(nums, 8);

            Assert.AreEqual(3, actual[0]);
            Assert.AreEqual(4, actual[1]);
        }

        [TestMethod]
        public void TestMethodSearchRange1()
        {
            var nums = new int[6] { 5, 7, 7, 8, 8, 10 };

            var actual = SearchRange(nums, 6);

            Assert.AreEqual(-1, actual[0]);
            Assert.AreEqual(-1, actual[1]);
        }

        [TestMethod]
        public void TestMethodSearchRange2()
        {
            var nums = new int[0] { };

            var actual = SearchRange(nums, 0);

            Assert.AreEqual(-1, actual[0]);
            Assert.AreEqual(-1, actual[1]);
        }

        [TestMethod]
        public void TestMethodSearchRange3()
        {
            var nums = new int[1] { 1 };

            var actual = SearchRange(nums, 1);

            Assert.AreEqual(0, actual[0]);
            Assert.AreEqual(0, actual[1]);
        }

        [TestMethod]
        public void TestMethodSearchRange4()
        {
            var nums = new int[2] { 2, 2 };

            var actual = SearchRange(nums, 2);

            Assert.AreEqual(0, actual[0]);
            Assert.AreEqual(1, actual[1]);
        }

        [TestMethod]
        public void TestMethodSearchRange5()
        {
            var nums = new int[2] { 1, 3 };

            var actual = SearchRange(nums, 1);

            Assert.AreEqual(0, actual[0]);
            Assert.AreEqual(0, actual[1]);
        }

        [TestMethod]
        public void TestMethodSearchRange6()
        {
            var nums = new int[3] { 1, 2, 3 };

            var actual = SearchRange(nums, 1);

            Assert.AreEqual(0, actual[0]);
            Assert.AreEqual(0, actual[1]);
        }

        public int[] FindRightInterval(int[][] intervals)
        {
            int n = intervals.Length;
            int[] arr = new int[n];
            int[] ans = new int[n];
            for (int i = 0; i < n; ++i)
                arr[i] = intervals[i][0];
            Dictionary<int, int> map = new Dictionary<int,int>();
            for (int i = 0; i < n; ++i)
                map.Add(arr[i], i);
            Array.Sort(arr);
            for (int i = 0; i < n; ++i)
            {
                int val = binarySearch(arr, intervals[i][1]);
                if (val == -1)
                    ans[i] = -1;
                else
                    ans[i] = map[arr[val]];
            }
            return ans;
        }

        int binarySearch(int[] arr, int target)
        {
            int l = 0;
            int r = arr.Length - 1;
            int ans = -1;
            while (l <= r)
            {
                int mid = l + (r - l) / 2;
                if (arr[mid] == target)
                    return mid;
                else if (arr[mid] > target)
                {
                    ans = mid;
                    r = mid - 1;
                }
                else
                    l = mid + 1;
            }
            return ans;
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

            if (nums.Length == 0 || nums[l] != target)
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
    }
}
