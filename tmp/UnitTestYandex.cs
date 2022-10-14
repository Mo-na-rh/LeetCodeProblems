using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLeetCodeProjects
{
    /// <summary>
    /// Autumn tasks
    /// </summary>


    [TestClass]
    public class UnitTestYandex
    {
        [TestMethod]
        public void TestMethodGetStepsCount()
        {
            var num = 6;

            var actual = GetStepsCount(num);

            Assert.AreEqual(3, actual);
        }

        [TestMethod]
        public void TestMethodGetStepsCount1()
        {
            var num = 1;

            var actual = GetStepsCount(num);

            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void TestMethodGetStepsCount2()
        {
            var num = int.MaxValue;

            var actual = GetStepsCount(num);

            Assert.AreEqual(65535, actual);
        }

        [TestMethod]
        public void TestMethodGetStepsCount3()
        {
            var num = 16;

            var actual = GetStepsCount(num);

            Assert.AreEqual(5, actual);
        }

        [TestMethod]
        public void TestMethodMaxProfit()
        {
            var arr = new int[6] { 7, 1, 5, 3, 6, 4 };

            var actual = MaxProfit(arr);

            Assert.AreEqual(2, actual[0]);
            Assert.AreEqual(5, actual[1]);
        }

        [TestMethod]
        public void TestMethodMaxProfit2()
        {
            var arr = new int[2] { 7, 1 };

            var actual = MaxProfit(arr);

            Assert.AreEqual(0, actual[0]);
            Assert.AreEqual(0, actual[1]);
        }

        [TestMethod]
        public void TestMethodMaxProfit1()
        {
            var arr = new int[6] { 10, 3, 5, 3, 11, 9 };

            var actual = MaxProfit(arr);

            Assert.AreEqual(2, actual[0]);
            Assert.AreEqual(5, actual[1]);
        }

        [TestMethod]
        public void TestMethodIsExistDuplicateNum()
        {
            var arr = new int[4] { 1, 2, 3, 1 };
            var k = 2;

            var actual = IsExistDuplicateNum(arr, k);

            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void TestMethodIsExistDuplicateNum1()
        {
            var arr = new int[4] { 1, 0, 1, 1 };
            var k = 1;

            var actual = IsExistDuplicateNum(arr, k);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void TestMethodIsExistDuplicateNum2()
        {
            var arr = new int[6] { 1, 2, 3, 1, 2, 3 };
            var k = 2;

            var actual = IsExistDuplicateNum(arr, k);

            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void TestMethodGetSortedAllDuplicateNums()
        {
            var l1 = new int[2] { 3, 1 };
            var l2 = new int[2] { 1, 3 };
            var l3 = new int[2] { 1, 2 };

            var actual = GetSortedAllDuplicateNums(l1, l2,l3);

            Assert.AreEqual(1, actual[0]);
            Assert.AreEqual(3, actual[1]);
        }

        [TestMethod]
        public void TestMethodGetSortedAllDuplicateNums1()
        {
            var l1 = new int[3] { 1, 2, 2 };
            var l2 = new int[3] { 3, 4, 3 };
            var l3 = new int[1] { 5 };

            var actual = GetSortedAllDuplicateNums(l1, l2, l3);

            Assert.AreEqual(0, actual.Count);
        }

        [TestMethod]
        public void TestMethodGetMajority()
        {
            var arr = new int[3] { 1, 2, 1 };

            var actual = GetMajority(arr);

            Assert.AreEqual(1, actual);
        }


        [TestMethod]
        public void TestMethodGetMajority1()
        {
            var arr = new int[7] { 7, 5, 5, 5, 5, 4, 5 };

            var actual = GetMajority(arr);

            Assert.AreEqual(5, actual);
        }

        [TestMethod]
        public void TestMethodGetMajority2()
        {
            var arr = new int[4] { 3, 3, 3, 1 };

            var actual = GetMajority(arr);

            Assert.AreEqual(3, actual);
        }

        [TestMethod]
        public void TestMethodGetMaxUsefulness()
        {
            var arr = new int[5] { -2, 3, -5, 5, 1 };
            var k = 5;

            var actual = GetMaxUsefulness(arr, k);

            Assert.AreEqual(26, actual);
        }

        [TestMethod]
        public void TestMethodGetMaxUsefulness1()
        {
            var arr = new int[2] { -1, 1 };
            var k = 1;

            var actual = GetMaxUsefulness(arr, k);

            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void TestMethodCowAndStalls()
        {
            var arr = new int[6] { 2, 5, 7, 11, 15, 20 };
            var k = 3;

            var actual = GetMaxUsefulness(arr, k);

            Assert.AreEqual(9, actual);
        }

        [TestMethod]
        public void TestMethodBumersAndZumers()
        {
            var arr = new int[2] { 16,16 };

            var actual = BumersAndZumers(arr);

            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        public void TestMethodBumersAndZumers1()
        {
            var arr = new int[3] { 17, 16, 18 };

            var actual = BumersAndZumers(arr);

            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        public void TestMethodBumersAndZumers2()
        {
            var arr = new int[5] { 120, 25, 30, 100, 105 };

            var actual = BumersAndZumers(arr);

            Assert.AreEqual(4, actual);
        }

        [TestMethod]
        public void TestMethodGroopsAndRooms()
        {
            var groups = new int[3] { 3, 1, 2 };
            var rooms = new int[2] { 1, 1 };

            var actual = GroopsAndRooms(groups,rooms);

            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void TestMethodGroopsAndRooms1()
        {
            var groups = new int[2] { 1, 2 };
            var rooms = new int[3] { 3, 2, 1 };

            var actual = GroopsAndRooms(groups, rooms);

            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        public void TestMethodGroopsAndRooms2()
        {
            var groups = new int[1] { 1 };
            var rooms = new int[1] { 1 };

            var actual = GroopsAndRooms(groups, rooms);

            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void TestMethodGetTasksCount()
        {
            var nums = new int[1][];
            nums[0] = new int[2]{ 5,10};

            var actual = GetTasksCount(nums);

            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void TestMethodGetTasksCount1()
        {
            var nums = new int[4][];
            nums[0] = new int[2] { 2, 4 };
            nums[1] = new int[2] { 1, 3 };
            nums[2] = new int[2] { 2, 3 };
            nums[3] = new int[2] { 3, 5 };

            var actual = GetTasksCount(nums);

            Assert.AreEqual(2, actual);
        }

        int GetTasksCount(int[][] nums)
        {
            var ans = 0;
            var cnt = nums.Length;
            var pairs = new List<(int start, int end)>();
            for (var i = 0; i < cnt; i++)
            {
                pairs.Add((nums[i][0], nums[i][1]));
            }
            pairs.Sort();

            for (var i = 0; i < cnt; i++)
            {
                var start = pairs[i].start;
                var end = pairs[i].end;
                while ((i + 1) < cnt && pairs[i + 1].start < end)
                {
                    i++;
                }
                ans++;
            }

            return ans;
        }


        int GroopsAndRooms(int[] groops, int[] rooms)
        {
            var ans = 0;

            Array.Sort(groops);
            Array.Sort(rooms);

            var room_index = 0;
            foreach(var groop in groops)
            {
                // пропускаем все комнаты в которых не поместится группа
                while (room_index < rooms.Length && rooms[room_index] < groop)
                    room_index += 1;

                if (room_index < rooms.Length)
                {
                    ans += 1;
                    room_index += 1;
                }

            }
            return ans;
        }

        int lcs(string str1, string str2)
        {
            var n = str1.Length;
            var m = str2.Length;

            var L = new int[n + 1, m + 1];
            L[0, 0] = 0;
            for(var i = 0; i <= n; i++)
            {
                for(var j=0; j <= m; j++)
                {
                    if (i == 0 || j == 0)
                        L[i, j] = 0;
                    else if (str1[i] == str2[j])
                        L[i, j] += 1;
                    else
                        L[i, j] = Math.Max(L[i-1, j], L[i, j-1]);
                }
            }

            return L[m,n];
        }

        int CowAndStalls(int[] stalls, int k)
        {
            var ans = 0;

            return ans;
        }

        int BumersAndZumers(int[] nums)
        {
            // сортировка nLogn
            Array.Sort(nums);

            var ans = 0;

            /*for(var x=0; x < nums.Length; x++)
            {
                for (var y = 0; y < nums.Length; y++)
                {
                    if (x == y)
                        continue;
                    if (nums[y] <= 0.5 * nums[x] + 7 || nums[y] > nums[x] || (nums[y] > 100 && nums[x] < 100))
                        continue;
                    ans++;
                }
            }*/
            var cnt=0;
            var x = nums.Length-1;
            var dupCnt = 0;
            while (x >= 0)
            {
                // current homo
                var curN = nums[x];
                var curX = x;
                dupCnt = 1;
                while ((x-1)>=0 && nums[x] == nums[x - 1])
                {
                    x--;
                    dupCnt++;
                }

                // Если возраст больше 100
                if (curN > 100)
                {
                    ans += Fact(dupCnt);
                    ans += (curX+1-dupCnt) * dupCnt;
                    x--;
                    continue;
                }

                var r = x;
                while ((x - 1) >= 0 && nums[x] < 2 * (nums[r - 1] - 7))
                {
                    r--;
                    ans += Fact(dupCnt);
                    ans += dupCnt;
                }
                x--;

                // x < 2y - 7 NO
                // x < 2y - 7 NO
                /*if (curN > 7)
                {


                    ans += Fact(dupCnt);
                    ans += (curX + 1 - dupCnt) * dupCnt;
                    x--;
                    continue;
                }*/
            }
                return ans;
            
        }

        public int Fact(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Fact(n - 1);
        }

        /// <summary>
        /// Вернуть максимальную полезность всех зелий 
        /// </summary>
        /// <param name="nums"> Полезности зелий </param>
        /// <param name="k"> Количество зелий которые нужно приготовить </param>
        /// <returns></returns>
        int GetMaxUsefulness(int[] nums, int k)
        {
            Array.Sort(nums);
            var ans = 0;
            var cnt = 0;
            for(var i = nums.Length-1; i>=0; i--)
            {
                var r = 1;
                while((i-r) >= 0 && nums[i-r] + nums[i] > nums[i])
                {
                    ans += nums[i - r] + nums[i];
                    cnt++;
                    r++;
                }
                ans += nums[i];
                cnt++;

                if (cnt == k)
                {
                    break;
                }
            }

            return ans;
        }

        int GetMajority(int[] nums)
        {
            var ans = 0;
            var count = 0;
            foreach(var num in nums)
            {
                if (count == 0)
                    ans = num;

                if(num == ans)
                    count++;
                else
                    count--; 
            }
            return ans;
        }

        List<int> GetSortedAllDuplicateNums(int[] l1, int[] l2, int[] l3)
        {
            var ans = new List<int>();
            var dict = new Dictionary<int, int>();

            foreach(var num in l1)
            {
                if (!dict.ContainsKey(num))
                {
                    // 1 for l1
                    dict.Add(num, 1);
                }
            }

            foreach (var num in l2)
            {
                if (!dict.ContainsKey(num))
                {
                    // 2 for l2
                    dict.Add(num, 2);
                }
                else if (dict[num] == 1)
                {
                    dict[num]+=2;
                }
            }

            // на вход словарь с числами количество повторов 2( =3) или 1( =2)
            foreach (var num in l3)
            {
                if (dict.ContainsKey(num))
                {
                    dict[num]+=3;
                }             
            }

            ans = dict.Where(t => t.Value > 2).Select(x => x.Key).Distinct().ToList();
            ans.Sort();

            return ans;
        }

        bool IsExistDuplicateNum(int[] nums, int k)
        {
            // inintialize dictionary which contain num and distanse between it repeats
            var dict = new Dictionary<int,int>();
            var i = 0;
            foreach(var num in nums)
            {
                if (!dict.ContainsKey(num))
                {
                    dict.Add(num, i);
                }
                else
                {
                    dict[num] = i-dict[num];
                    if (dict[num] <= k)
                        return true;
                }
                i++;
            }

            return false;
        }

        public int[] MaxProfit(int[] prices)
        {
            var ans = new int[2];

            var sum = 0;
            var indx = 0;

            var min = int.MaxValue;
            var max = 0;
            var minIndx = 0;
            var maxIndx = 0;
            while (indx < prices.Length - 1)
            {
                if (min > prices[indx])
                {
                    min = prices[indx];
                    minIndx = indx+1;
                }

                max = prices[indx + 1];

                if (max - min > sum)
                {
                    sum = max - min;
                    maxIndx = indx + 2;
                }
                indx++;
            }
            if (maxIndx > minIndx)
            {
                ans[0] = minIndx;
                ans[1] = maxIndx;
            }

            return ans;
        }

        public int GetStepsCount(int num)
        {
            long sum = 0;
            var next = 0;
            var cnt = 0;
            while (true)
            {
                sum +=  next + 1;
                next++;
                if (sum > num)
                    break;
                cnt++;
            }
            return cnt;
        }
    }

   
    // a+b
    public class Solution1
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s = Console.ReadLine();

            int result = 0;
            foreach (char ch in s)
            {
                if (s1.IndexOf(ch) >= 0)
                {
                    ++result;
                }
            }

            Console.WriteLine(result);
        }
    }

   /* public class Solution
    {
        public static Node Reverse(Node head, int left, int right)
        {
            var m = left;
            var n = right;
            // Empty list
            if (head == null)
            {
                return null;
            }

            // Move the two pointers until they reach the proper starting point
            // in the list.
            Node cur = head, prev = null;
            while (m > 1)
            {
                prev = cur;
                cur = cur.next;
                m--;
                n--;
            }

            // The two pointers that will fix the final connections.
            Node con = prev, tail = cur;

            // Iteratively reverse the nodes until n becomes 0.
            Node third = null;
            while (n > 0)
            {
                third = cur.next;
                cur.next = prev;
                prev = cur;
                cur = third;
                n--;
            }

            // Adjust the final connections as explained in the algorithm
            if (con != null)
            {
                con.next = prev;
            }
            else
            {
                head = prev;
            }

            tail.next = cur;
            return head;
        }
    }*/
}
