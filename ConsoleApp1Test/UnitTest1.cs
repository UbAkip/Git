using System;
using NUnit.Framework;
namespace ConsoleApp1Test
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            ConsoleApp1.Calculate calc = new ConsoleApp1.Calculate();

            int x = calc.doubleSum(6);

            Assert.AreEqual(x, 6 + 6);
        }
    }
}
