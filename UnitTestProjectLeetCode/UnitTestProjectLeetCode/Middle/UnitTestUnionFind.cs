using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using UnitTestProjectLeetCode.Utils;

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
            var actual = FindCircleNum(nums);


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
            var actual = FindCircleNum(nums);


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
            var actual = FindCircleNum(nums);


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
            var actual = FindCircleNum(nums);


            // assert
            Assert.AreEqual(1, actual);
        }

        public int FindCircleNum(int[][] isConnected)
        {
            var n = isConnected.Length;

            //return n;
            var dsu = new DisjointSet<int>();
            for (var i = 0; i < isConnected.Length; i++)
            {
                dsu.MakeSet(i);
            }

            for (var i = 1; i < isConnected.Length; i++)
            {
                for (var j = 0; j < i; j++)
                {
                    if (isConnected[i][j] == 1)
                        dsu.Union(i, j);
                }
            }

            var disjointNodes = new HashSet<int>();
            foreach (var value in dsu)
            {
                var find = dsu.FindSet(value);
                disjointNodes.Add(find);
            }


            return disjointNodes.Count;
        }
    }

    public interface ICustomDSU
    {
        void MakeSet(int[] x);

        void UnionSet(int[] x, int[] y);

        int[] FindSet(int[] x);
    }

    public class CustomDSU : ICustomDSU
    {
        public int[] FindSet(int[] x)
        {
            throw new NotImplementedException();
        }

        public void MakeSet(int[] x)
        {
            throw new NotImplementedException();
        }

        public void UnionSet(int[] x, int[] y)
        {
            throw new NotImplementedException();
        }
    }
}
