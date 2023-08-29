using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProjectLeetCode.UtilClasses;

namespace UnitTestProjectLeetCode
{
    [TestClass]
    public class UnitTestUnionFind
    {
        [TestMethod]
        public void TestMethodFindCircleNum()
        {
            // arrange
            int[][] nums = new int[3][];
            nums[0] = new int[3] { 1, 1, 0 };
            nums[1] = new int[3] { 1, 1, 0 };
            nums[2] = new int[3] { 0, 0, 1 };

            // act
            var actual = FindCircleNumUF(nums);


            // assert
            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        public void TestMethodFindCircleNum1()
        {
            // arrange
            int[][] nums = new int[3][];
            nums[0] = new int[3] { 1, 0, 1 };
            nums[1] = new int[3] { 0, 1, 0 };
            nums[2] = new int[3] { 1, 0, 1 };

            // act
            var actual = FindCircleNumUF(nums);


            // assert
            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        public void TestMethodFindCircleNum2()
        {
            // arrange
            int[][] nums = new int[3][];
            nums[0] = new int[3] { 1, 0, 0 };
            nums[1] = new int[3] { 0, 1, 0 };
            nums[2] = new int[3] { 0, 0, 1 };

            // act
            var actual = FindCircleNumUF(nums);


            // assert
            Assert.AreEqual(3, actual);
        }

        [TestMethod]
        public void TestMethodFindCircleNum3()
        {
            // arrange
            int[][] nums = new int[3][];
            nums[0] = new int[3] { 1, 1, 1 };
            nums[1] = new int[3] { 1, 1, 1 };
            nums[2] = new int[3] { 1, 1, 1 };

            // act
            var actual = FindCircleNumUF(nums);


            // assert
            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void TestMethodFindCircleNum4()
        {
            // arrange
            int[][] nums = new int[15][];
            nums[0] = new int[15] { 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0 };
            nums[1] = new int[15] { 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            nums[2] = new int[15] { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            nums[3] = new int[15] { 0, 0, 0, 1, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0 };
            nums[4] = new int[15] { 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0 };
            nums[5] = new int[15] { 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0 };
            nums[6] = new int[15] { 0, 0, 0, 1, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1, 0 };
            nums[7] = new int[15] { 1, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0 };
            nums[8] = new int[15] { 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 1, 0 };
            nums[9] = new int[15] { 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 1 };
            nums[10] = new int[15] { 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 1, 0, 0, 0 };
            nums[11] = new int[15] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0 };
            nums[12] = new int[15] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 };
            nums[13] = new int[15] { 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1, 0 };
            nums[14] = new int[15] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1 };

            // act
            var actual = FindCircleNumUF(nums);


            // assert
            Assert.AreEqual(3, actual);
        }

        public int FindCircleNumDFS(int[][] isConnected)
        {
            var n = isConnected.Length;
            var visited = new bool[n];
            var provinces = 0;

            for (var i = 0; i < isConnected.Length; i++)
            {
                if (!visited[i])
                {
                    provinces++;
                    DFS(i, visited, isConnected);
                }
            }

            return provinces;
        }

        /// <summary>
        /// Passed all test cases
        /// </summary>
        /// <param name="node"></param>
        /// <param name="visited"></param>
        /// <param name="isConnected"></param>
        private void DFS(int node, bool[] visited, int[][] isConnected)
        {
            visited[node] = true;
            for (var ajacent = 0; ajacent < isConnected.Length; ajacent++)
            {
                if (isConnected[node][ajacent] == 1 && !visited[ajacent])
                {
                    DFS(ajacent, visited, isConnected);
                }
            }
        }

        public int FindCircleNumUF(int[][] isConnected)
        {
            var dsu = new UnionFind();
            return dsu.findCircleNum(isConnected);
        }
    }
}
