using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProjectLeetCode.Middle
{
    [TestClass]
    public class UnitTestBitManipulation
    {
        [TestMethod]
        public void TestMethodBitDivide()
        {
            var dividend = -2147483648;
            var divisor = -1;

            var actual = Divide(dividend, divisor);

            Assert.AreEqual(2147483647, actual);
        }

        public long Divide(int dividend, int divisor)
        {
            long ans = 0;

            long dividendLong = dividend;
            long divisorLong = divisor;

            var r = dividendLong / divisorLong;
            var neg = (r) < 0;

            dividendLong = Math.Abs(dividendLong);
            divisorLong = Math.Abs(divisorLong);

            for (var i = 31; i > -1; i--)
            {
                long val = divisorLong << i;

                if (val <= dividendLong)
                {
                    dividendLong -= val;
                    ans += 1 << i;
                }
            }


            return neg ? -1 * ans : ans;
        }
    }
}
