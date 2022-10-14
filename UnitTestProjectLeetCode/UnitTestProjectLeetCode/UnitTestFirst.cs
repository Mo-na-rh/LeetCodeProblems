using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;

namespace UnitTestProjectLeetCode
{
    [TestClass]
    public class UnitTestFirst
    {

        [TestMethod]
        public void ShouldReturnRes()
        {
            int[] nums1 = new int[6] { 1, 2, 3, 0, 0, 0 };
            int[] nums2 = new int[3] { 2, 5, 6 };

            Merge(ref nums1, 3, nums2, 3);

            Assert.AreEqual(5, nums1[4]);
        }

        [TestMethod]
        public void ShouldReturnRes1()
        {
            int[] nums1 = new int[1] { 1 };
            int[] nums2 = new int[0];

            Merge(ref nums1, 1, nums2, 0);

            Assert.AreEqual(1, nums1[0]);

        }

        [TestMethod]
        public void ShouldReturnRes2()
        {
            int[] nums1 = new int[1] ;
            int[] nums2 = new int[1] { 1 };

            Merge(ref nums1, 0, nums2, 1);

            Assert.AreEqual(1, nums1[0]);

        }

        [TestMethod]
        public void ExistArr_Check_ReturnFlag()
        {
            //int[] nums1 = new int[4] { 0, 3, 2, 1 };

            //var flag = ShouldReturnFlag(nums1);

            //Assert.AreEqual(true, flag);

            //int[] nums2 = new int[8] { 0, 2, 3, 3, 5,2,1,0 };
            int[] nums2 = new int[3] { 3,5,5 };

            var flag1 = ShouldReturnFlag(nums2);

            Assert.AreEqual(false, flag1);
        }

        [TestMethod]
        public void ExistArr_Check_ReturnFlag1()
        {
            int[] nums2 = new int[10] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };

            var flag1 = ShouldReturnFlag(nums2);

            Assert.AreEqual(false, flag1);
        }

        [TestMethod]
        public void ExistArr_Check_ReturnFlag2()
        {
            int[] nums2 = new int[5] { 0,1, 2,1,8};

            var flag1 = ShouldReturnFlag(nums2);

            Assert.AreEqual(false, flag1);
        }

        [TestMethod]
        public void ExistArr_Check_ReturnOrder()
        {
            int[] nums2 = new int[4] { 3, 1, 2, 4 };

            var k = ShouldReturnParityArray(nums2);

            Assert.AreEqual(2, k[1]);
        }

        [TestMethod]
        public void ExistArr_Check_ReturnOrder1()
        {
            int[] nums2 = new int[4] { 3, 2, 4, 6 };

            var k = ShouldReturnParityArray(nums2);

            Assert.AreEqual(6, k[0]);
        }

        [TestMethod]
        public void ExistArr_Check_ReturnOrder2()
        {
            int[] nums2 = new int[1] { 0 };

            var k = ShouldReturnParityArray(nums2);

            Assert.AreEqual(0, k[0]);
        }

        [TestMethod]
        public void ExistArr_Check_ReturnOrder3()
        {
            int[] nums2 = new int[3] { 1,0,3 };

            var k = ShouldReturnParityArray(nums2);

            Assert.AreEqual(1, k[1]);
        }

        [TestMethod]
        public void ExistArr_Check_ReturnOrder4()
        {
            int[] nums2 = new int[3] { 0, 1, 2 };

            var k = ShouldReturnParityArray(nums2);

            Assert.AreEqual(2, k[1]);
        }

        [TestMethod]
        public void ExistArr_Check_ReturnOrder5()
        {
            int[] nums2 = new int[3] { 0, 2, 1 };

            var k = ShouldReturnParityArray(nums2);

            Assert.AreEqual(2, k[1]);
        }

        [TestMethod]
        public void ExistArr_Check_ReturnOrder6()
        {
            int[] nums2 = new int[4] { 0, 2, 1, 4 };

            var k = ShouldReturnParityArray(nums2);

            Assert.AreEqual(1, k[3]);
        }

        [TestMethod]
        public void ExistArr_CheckHeight_ReturnUnMatchCnt()
        {
            int[] heights = new int[5] { 5, 1, 2, 3, 4 };

            var k = ShouldReturnUnMatchCnt(heights);

            Assert.AreEqual(5, k);
        }

        [TestMethod]
        public void ExistArr_CheckMax_ReturnThirdMax()
        {
            int[] nums = new int[6] { 1, 2, 2, 5, 3, 5 };

            var k = GetThirdMax(nums);

            Assert.AreEqual(2, k);
        }

        [TestMethod]
        public void ExistArr_CheckMax_ReturnThirdMax1()
        {
            int[] nums = new int[3] { 3, 2, 1 };

            var k = GetThirdMax(nums);

            Assert.AreEqual(1, k);
        }

        [TestMethod]
        public void ExistArr_Sqr_ReturnSquaredArr()
        {
            int[] nums = new int[5] { -4, -1, 0, 3, 10 };

            var k = SortedSquares(nums);

            Assert.AreEqual(16, k[3]);
        }

        [TestMethod]
        public void ExistArr_Sqr_ReturnSquaredArr1()
        {
            int[] nums = new int[5] { -7, -3, 2, 3, 11 };

            var k = SortedSquares(nums);

            Assert.AreEqual(49, k[3]);
        }


        [TestMethod]
        public void ExistNegativeArr_Sqr_ReturnSquaredArr1()
        {
            int[] nums = new int[4] { -5, -3, -2, -1 };

            var k = SortedSquares(nums);

            Assert.AreEqual(25, k[3]);
        }


        [TestMethod]
        public void ExistNegativeArr_Sqr_ReturnSquaredArr2()
        {
            int[] nums = new int[7] { -10000, -9999, -7, -5, 0, 0, 10000 };

            var k = SortedSquares(nums);

            Assert.AreEqual(0, k[1]);
        }

        [TestMethod]
        public void ExistNegativeArr_Sqr_ReturnSquaredArr3()
        {
            int[] nums = new int[5] { -4, -1, 0, 3, 10 };

            var k = SortedSquares(nums);

            Assert.AreEqual(1, k[1]);
        }

        [TestMethod]
        public void ExistNegativeArr_Sqr_ReturnSquaredArr4()
        {
            int[] nums = new int[4] { -3, -3, -2, 1 };

            var k = SortedSquares(nums);

            Assert.AreEqual(4, k[1]);
        }

        [TestMethod]
        public void ExistNegativeArr_Sqr_ReturnSquaredArr5()
        {
            int[] nums = new int[5] { -5, -4, 1, 2, 5 };

            var k = SortedSquares(nums);

            Assert.AreEqual(4, k[1]);
        }

        [TestMethod]
        public void ExistNegativeArr_Sqr_ReturnSquaredArr6()
        {
            int[] nums = new int[4] { -4, 0, 1, 3 };

            var k = SortedSquares(nums);

            Assert.AreEqual(1, k[1]);
        }

        [TestMethod]
        public void TestMethodIsExistSubArr()
        {
            int[] nums = new int[4] { -4, 0, 1, 3 };

            var actual = IsExistSubArr(nums,1);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void TestMethodIsExistSubArr1()
        {
            int[] nums = new int[4] { -4, 0, 1, 3 };

            var actual = IsExistSubArr(nums, 8);

            Assert.AreEqual(false, actual);
        }


        [TestMethod]
        public void TestMethodGetMaxCnt()
        {
            var arr = new int[7] { 1, 1, 9, 2, 2, 2, 6 };

            var actual = GetMaxCnt(4, arr);

            Assert.AreEqual(17, actual);
        }

        [TestMethod]
        public void TestMethodGetMaxCnt1()
        {
            var arr = new int[7] { 6, 1, 9, 2, 2, 2, 1 };

            var actual = GetMaxCnt(1, arr);

            Assert.AreEqual(6, actual);
        }

        [TestMethod]
        public void TestMethodGetMaxCnt3()
        {
            var arr = new int[2] { 6, 9 };

            var actual = GetMaxCnt(2, arr);

            Assert.AreEqual(15, actual);
        }

        [TestMethod]
        public void TestMethodGetMaxCnt4()
        {
            var arr = new int[2] { 6, 9 };

            var actual = GetMaxCnt(1, arr);

            Assert.AreEqual(9, actual);
        }

        [TestMethod]
        public void TestMethodGetMaxCnt5()
        {
            var arr = new int[0] {  };

            var actual = GetMaxCnt(0, arr);

            Assert.AreEqual(0, actual);
        }

        public static int GetMaxCnt(int k, int[] nums)
        {
            var maxSum = 0;
            for (var l = 0; l <= k; l++)
            {
                var sum = 0;

                for(var left = 0; left < l; left++)
                {
                    sum += nums[left];
                }
                    
                for(var right = 1; right<=k-l; right++)
                {
                    sum += nums[nums.Length - right];
                }   


                if(maxSum <sum)
                    maxSum = sum;

            }
            return maxSum;
        }

        public static int GetSum(int a, int b)
        {
            return a + b;
        }

        public bool IsExistSubArr(int[] nums, int target)
        {
            var l = 0;
            var r = 1;
            var sum = 0;

            while(l< nums.Length-1)
            {
                sum = nums[l];
                while(r<nums.Length && sum < target)
                {
                    sum += nums[r];
                    if(sum==target) 
                        return true;
                    r++;
                }

                l++;
                r = l + 1;
            }

            return false;
        }

        public IList<IList<int>> LevelOrder(TreeNode root)
        {

            var res = new List<List<int>>();


            return (IList<IList<int>>)res;
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

        public int[] SortedSquares(int[] nums)
        {
            var right = nums.Length - 1;
            var left = 0;
            if (nums[right] <= 0)
            {
                while (left < right)
                {
                    var tmp = nums[left];
                    nums[left] = nums[right];
                    nums[right] = tmp;
                    left++;
                    right--;
                }
            }
            else   
            {
                while (left <= right)
                {
                    if (Math.Abs(nums[left]) > Math.Abs(nums[right]))
                    {
                        var tmp = nums[left];
                        nums[left] = nums[right];
                        nums[right] = tmp;

                        //right--;
                       /*if (nums[right] > 0 && nums[left] > 0)
                            left++;
                        else */
                            right--;   
                    }
                    else if (nums[right]<=0)
                    {
                        left++;
                    }
                    else if (nums[right]>0)
                    {
                        right--;

                    }
                }

                for (int i = 0; i < nums.Length; i++)
                {
                    if (i + 1 == nums.Length) break; 
                    if (Math.Abs(nums[i]) > Math.Abs(nums[i + 1]))
                    {
                        var tmp = nums[i];
                        nums[i] = nums[i + 1];
                        nums[i + 1] = tmp;
                    }
                }
            }
            

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = nums[i] * nums[i];
            }
            return nums;
        }
        public static int longestIncreasingSubsequence(List<int> arr)
        {
            int[] dp = new int[arr.Count];
            int len = 0;

            foreach (int x in arr)
            {
                int i = Array.BinarySearch(dp, 0, len, x);
                if (i < 0) i = -(i + 1);
                dp[i] = x;
                if (i == len) len++;
            }

            return len;
        }

        public int GetThirdMax(int[] nums)
        {
            int? m1 = null;
            int? m2 = null;
            int? m3 = null;

            foreach (int el in nums)
            {
                if (m1 == el || m2 == el || m3 == el) continue;

                if (el > m1 || m1 == null)
                {
                    m3 = m2;
                    m2 = m1;
                    m1 = el;
                }

                else if (el > m2 || m2 == null)
                {
                    m3 = m2;
                    m2 = el;
                }

                else if (el > m3 || m3 == null)
                {
                    m3 = el;
                }
            }

            return m3 != null ? m3.Value : m1.Value;
        }

        public int ShouldReturnUnMatchCnt(int[] heights)
        {
            var unMatchCnt = 0;
            var arr = (int[])heights.Clone();
            Array.Sort(arr);
            for (int i = 0; i < heights.Length; i++)
            {
                if(arr[i] != heights[i]) unMatchCnt++;
            }

            return unMatchCnt;
        }

        public int[] ShouldReturnParityArray(int[] nums)
        {
            if (nums == null || nums.Length == 0) return nums;

            if (nums.Length == 1) return nums;


            var left = 0;
            var right = nums.Length - 1;
            while (true)
            {
                while (left<right&&nums[left]%2==0)  
                    left++;
                while (right>left && nums[right] % 2 != 0) 
                    right--;
                if (left==right)
                    break;

                var rVal = nums[right];
                var lVal = nums[left];
                nums[right] = lVal;
                nums[left] = rVal;
            }

            /*var evenFlag = false;
            var oddFlag = false;

            var left = 0;
            var right = nums.Length - 1;

            var flagE_N = true;

            while (left != right)
            {
                if (evenFlag && oddFlag)
                {
                    var rVal = nums[right];
                    var lVal = nums[left];
                    nums[right] = lVal;
                    nums[left] = rVal;
                    oddFlag = false;
                    evenFlag = false;
                    continue;
                }
                if (flagE_N)
                {
                    if ((nums[left] & 1) != 0 && !oddFlag) // не чётное
                    {
                        oddFlag = true;
                        flagE_N = !flagE_N;
                        continue;
                    }
                    left++;
                }
                else
                {
                    if ((nums[right] & 1) == 0 && !evenFlag) // чётное
                    {
                        evenFlag = true;
                        flagE_N = !flagE_N;
                        continue;
                    }
                    right--;
                }
            }*/
            return nums;
        }



        public bool ShouldReturnFlag(int[] arr)
        {
            if ((arr == null || arr.Length < 3)||(arr[0] - arr[1] > 0)) return false;

            var flag = false;
            for (int i = 1; i < arr.Length; i++)
            {
                // Right side
                if ((!flag) && (arr[i] - arr[i - 1] <= 0)) flag = true;

                // Left side
                if ((flag) && (arr[i] - arr[i - 1] >= 0)) return false;
            }

            return flag;
        }

        public void Merge(ref int[] nums1, int m, int[] nums2, int n)
        {
            if (m == 0)
            {
                for (int i = 0; i < n; i++)
                {
                    nums1[i] = nums2[i];
                }
            }
            else if (n != 0)
            {
                var res = (int[])nums1.Clone();
                var left = 0;
                var right = 0;
                for (int i = 0; i < m + n; i++)
                {
                    if ((left < m) & (right < n))
                    {
                        if ((res[left] < nums2[right]))
                        {
                            nums1[i] = res[left];
                            left++;
                        }
                        else
                        {
                            nums1[i] = nums2[right];
                            right++;
                        }
                    }


                    else if (left == m)
                    {
                        nums1[i] = nums2[right];
                        right++;
                    }

                    else if (right == n)
                    {
                        nums1[i] = res[left];
                        left++;
                    }
                }

                
            }
        }
    }
}
