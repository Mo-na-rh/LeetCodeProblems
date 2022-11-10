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
            var s = "()(()()";

            // act
            var actual = GetLengthOfMaxValidSequence(s);

            // Assert
            Assert.AreEqual(4, actual);
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

        public int GetLengthOfMaxValidSequence(string s)
        { 

            var stk = new Stack<char>();

            // len
            var maxLen = 0;
            // при каждом обнулении стэка накопленную сумму зануляем
            var accumulatedSum = 0;
            for(var i = 0; i<s.Length; i++)
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
            //if (accumulatedSum > maxSum)
            //    accumulatedSum = accumulatedSum - stk.Count * 2;

            return Math.Max(maxLen,accumulatedSum); 
        }
    }
}
