using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject2
{
    class ForContest
    {
    }

    public class Test
    {
        static void Main()
        {
            // input
            string sgCnt = Console.ReadLine();
            string[] sGroups = Console.ReadLine().Split(' ');
            string srCnt = Console.ReadLine();
            string[] sRooms = Console.ReadLine().Split(' ');

            int gCnt = int.Parse(sgCnt);
            int rCnt = int.Parse(srCnt);
            var groups = new int[gCnt];
            for (var i = 0; i < gCnt; i++)
            {
                groups[i] = int.Parse(sGroups[i]);
            }

            var rooms = new int[rCnt];
            for (var i = 0; i < rCnt; i++)
            {
                rooms[i] = int.Parse(sRooms[i]);
            }

            int ans = GroopsAndRooms(groups, rooms);

            Console.WriteLine(ans);
        }

        static int GroopsAndRooms(int[] groops, int[] rooms)
        {
            var ans = 0;

            Array.Sort(groops);
            Array.Sort(rooms);

            var shortLen = groops.Length < rooms.Length ? groops.Length : rooms.Length;

            var i = 0;

            while (i < shortLen && groops[i] <= rooms[i])
            {
                ans++;
                i++;
            }

            return ans;
        }


    }

    public class Test1
    {
        static void Main()
        {
            string sCnt = Console.ReadLine();
            int cnt = int.Parse(sCnt);
            var requests = new int[cnt][];
            var i = 0;
            while(i<cnt)
            {
                var nums = Console.ReadLine().Split(' ');
                requests[i][0] = int.Parse(nums[0]);
                requests[i][1] = int.Parse(nums[1]);
                i++;
            }

            int ans = GetTasksCount(requests);

            Console.WriteLine(ans);
        }

        static int GetTasksCount(int[][] nums)
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
    }

    public class Test2
    {
        static void Main()
        {
            string sCnt = Console.ReadLine();
            int cnt = int.Parse(sCnt);
            var ribs = new int[cnt][];
            var i = 0;
            while (i < cnt)
            {
                var nums = Console.ReadLine().Split(' ');
                ribs[i][0] = int.Parse(nums[0]);
                ribs[i][1] = int.Parse(nums[1]);
                i++;
            }

            int ans = GetTasksCount(ribs);

            Console.WriteLine(ans);
        }

        static int GetTasksCount(int[][] nums)
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
    }




}
