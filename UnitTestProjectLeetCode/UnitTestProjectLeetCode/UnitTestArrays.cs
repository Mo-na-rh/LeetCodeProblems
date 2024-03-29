﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectLeetCode
{
    public class Test1
    {
        static void Main()
        {
            string[] array = Console.ReadLine().Split(' ');
            int a = int.Parse(array[0]);
            var cost = new int[a];
            for (int i = 0; i < cost.Length; i++)
            {
                cost[i] = int.Parse(array[i + 1]);
            }

            //int[] b = BuyAndSell(arr);

            var ans = new int[2];
            var bestBuyDay = 0;
            var bestSellDay = 0;
            var minCostDay = 0;

            for (int i = 1; i < cost.Length; i++)
            {
                if (cost[bestSellDay] * cost[minCostDay] < cost[bestBuyDay] * cost[i])
                {
                    bestBuyDay = minCostDay;
                    bestSellDay = i;
                }
                if (cost[i] < cost[minCostDay])
                    minCostDay = i;
            }
            if (bestBuyDay == 0 && bestSellDay == 0)
                Console.WriteLine(0 + ' ' + 0);
            else
                Console.WriteLine(bestBuyDay + 1 + ' ' + bestSellDay+1);
        }

        static int[] BuyAndSell(int[] cost)
        {
            var ans = new int[2];


                return ans;
        }
    }


    public class Solution
    {
        static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);

            var result = GetCountSteps(n);

            Console.WriteLine(result);
        }

        static int GetCountSteps(int n)
        {
            var cnt = 0;
            var byStep = 1;
            while (cnt < n)
            {
                cnt += byStep;
                byStep += 1;
            }

            return cnt;
        }
    }

    public class Solution1
    {
        static void Main(string[] args)
        {

            int.TryParse(Console.ReadLine(), out int n);
            int.TryParse(Console.ReadLine(), out int stepCnt);

            int[] arr = new int[n];
            var i = 0;
            Console.WriteLine("Введите массив:");
            string[] str = Console.ReadLine().Split(new char[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            for (i = 0; i < (n < str.Length ? n : str.Length); ++i)
                arr[i] = Convert.ToInt32(str[i]);

            var result = GetMaxCnt(stepCnt,arr);

            Console.WriteLine(result);

        }

        public static int GetCountSteps(int n)
        {
            var cnt = 0;
            var byStep = 1;
            while (cnt < n)
            {
                cnt += byStep;
                byStep += 1;
            }

            return cnt;
        }

        public static int GetMaxCnt(int stepCnt, int[] nums)
        {
            var l = 0;
            var r = nums.Length-1;
            var indx = 0;
            var sum = 0;
            while (indx < stepCnt && indx < nums.Length)
            {
                if(nums[l] < nums[r])
                {
                    sum += nums[r];
                    r--;
                }
                else
                {
                    sum += nums[l];
                    l++;
                }
                    
            }


            return 0;
        }
    }



    [TestClass]
    public class UnitTestArrays1
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
        public void ExistArr_CheckNums_ReturnAllDisappearedNums()
        {
            int[] nums = new int[4] { 4, 4, 4, 4 };

            var k = FindDisappearedNumbers(nums);

            Assert.AreEqual(3, k.Count);
        }

        [TestMethod]
        public void ExistArr_Square_ShouldReturnSquaredNondecreasingArr()
        {
            int[] nums = new int[5] { -4, -1, 0, 3, 10 };

            var k = SortedSquares(nums);

            Assert.AreEqual(9, k[2]);
        }

        [TestMethod]
        public void ExistArr_Square_ShouldReturnSquaredNondecreasingArr1()
        {
            int[] nums = new int[4] { -5, -3, -2, -1 };

            var k = SortedSquares(nums);

            Assert.AreEqual(4, k[1]);
        }

        [TestMethod]
        public void ExistArr_Square_ShouldReturnSquaredNondecreasingArr2()
        {
            int[] nums = new int[5] { -5, -3, -2, -1, 0 };

            var k = SortedSquares(nums);

            Assert.AreEqual(1, k[1]);
        }

        [TestMethod]
        public void ExistArr_Square_ShouldReturnSquaredNondecreasingArr3()
        {
            int[] nums = new int[5] { 0, 1, 2, 3, 5 };

            var k = SortedSquares(nums);

            Assert.AreEqual(1, k[1]);
        }

        [TestMethod]
        public void ExistArr_Check_ShouldReturnTwoSums()
        {
            int[] nums = new int[4] { 2, 7, 11, 15 };
            var target = 9;

            var k = TwoSum(nums, target);

            Assert.AreEqual(1, k[1]);
        }

        [TestMethod]
        public void ExistArr_Check_ShouldReturnTwoSums1()
        {
            int[] nums = new int[3] { 3, 2, 4 };
            var target = 6;

            var k = TwoSum(nums, target);

            Assert.AreEqual(2, k[1]);
        }

        [TestMethod]
        public void ExistArr_Check_ShouldReturnTwoSums2()
        {
            int[] nums = new int[2] { 3, 3 };
            var target = 6;

            var k = TwoSum(nums, target);

            Assert.AreEqual(0, k[0]);
        }

        public int[] TwoSum(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>(); // хэш мап
            for (int i = 0; i < nums.Length; i++)
            {
                int requiredNum = (int)(target - nums[i]);
                if (dict.ContainsKey(requiredNum))
                {
                    dict.TryGetValue(requiredNum, out var first);
                    int[] toReturn = { first, i };
                    return toReturn;
                }

                if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], i);
                }
            }
            return null;
            /*
            var res = new int[2];
            var curIndx = 0; 
            while (curIndx < nums.Length)
            {
                var curNum = nums[curIndx];
                for (int i = 0; i < nums.Length; i++)
                {
                    if (curIndx!=i && nums[curIndx] + nums[i] == target)
                    {
                        res[0] = curIndx;
                        res[1] = i;
                        return res;
                    }
                }
                curIndx++; 
            }
            return res;
            */
        }


        public int[] SortedSquares(int[] nums)
        {
            var res = new int[nums.Length];

            var midIndx = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= 0)
                {
                    midIndx = i;
                    break;
                }
            }


            var left = midIndx - 1;
            var right = midIndx;

            var curIndx = 0;
            while (curIndx!= nums.Length)
            {
                if (left < 0|| right == nums.Length)
                { 
                    if(left < 0 && right != nums.Length)
                    {
                        res[curIndx] = nums[right];
                        right++;
                    }
                    else
                    {
                        res[curIndx] = nums[left];
                        left--;
                    }
                    curIndx++;
                    continue;
                }

                if (Math.Abs(nums[left]) > Math.Abs(nums[right]))
                {
                    res[curIndx] = nums[right];
                    right++;
                }
                else
                {
                    res[curIndx] = nums[left];
                    left--;
                }
                curIndx++;
            }

            // square array

            if (nums[res.Length-1] < 0)
            {

                var indx = 0;
                for (int i = res.Length-1; i >= 0; i--)
                {
                    
                    res[indx] = nums[i] * nums[i];
                    indx++;
                }
            }
            else
            {
                for (int i = 0; i < res.Length; i++)
                {
                    res[i] = res[i] * res[i];
                }
            }
            

            return res;
        }



            public IList<int> FindDisappearedNumbers(int[] nums)
        {
            /*
             Дано входной массив с числами принадлежащими 1..nums.Length
             
             Нужно узнать каких чисел в нём не хватает 
                и вернуть эти числа в виде списка
             
             

             */
            List<int> output = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var indx = Math.Abs(nums[i]) - 1;

                if (nums[indx] > 0)
                {
                    nums[indx] *= -1;
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    output.Add(i + 1);
                }
            }

            return output;
            /*if (nums == null || nums.Length == 0) return nums;

            if (nums.Length == 1) return nums;

            // Есть результирующий список
            var lst = new List<int>(nums.Length);

            // Заполним его корректными данными
            for (int i = 1; i <= nums.Length; i++)
                lst.Add(i);


                for (int i = 0; i < nums.Length; i++)
                {
                    if(lst.Contains(nums[i]))
                    {
                        lst.Remove(nums[i]);
                    }
                }

                return lst;*/
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
