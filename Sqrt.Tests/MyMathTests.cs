using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sqrt.Tests
{
    [TestClass]
    public class MyMathTests
    {
        [TestMethod]
        [DataRow(9, 3)]
        [DataRow(25, 5)]
        [DataRow(256, 16)]
        [DataRow(1000000, 1000)]
        [DataRow(391250.25,625.5)]
        public void Sqrt_CorrectValues_ShouldBeOk(double number, double root)
        {
            var actual = MyMath.Sqrt(number);
            Assert.IsTrue(MyMath.Abs(root - actual) < MyMath.Epsilon);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Sqrt_NegativeValue_ShouldThrowArgumentOutOfRangeException()
        {
            MyMath.Sqrt(-1);
        }

        [TestMethod]
        [DataRow(9, 9)]
        [DataRow(-9, 9)]
        [DataRow(0, 0)]
        [DataRow(0.1, 0.1)]
        public void Abs_CorrectValues_ShouldBeOk(double number, double expected)
        {
            var actual = MyMath.Abs(number);
            Assert.AreEqual(expected, actual);
        }
    }
}
