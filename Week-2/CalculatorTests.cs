using CalcLibrary;
using NUnit.Framework;
using System;

namespace CalcLibrary.Tests
{
   [TestFixture]
   public class CalculatorTests
    {
      Calculator calc;
        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
        }
        [TearDown]
        public void Cleanup()
        {
            calc = null;
        }
        [TestCase(2, 3, 5)]
        [TestCase(-1, 1, 0)]
        [TestCase(0, 0, 0)]
        public void TestAddition(int a, int b, int expected)
        {
            double result = calc.Add(a, b);  // Replace 'Add' with actual method name if needed
            Assert.That(result, Is.EqualTo(expected));
        }
        [TestCase(5, 3, 2)]
        [TestCase(10, 5, 5)]
        public void TestSubtraction(int a, int b, int expected)
        {
            double result = calc.Subtraction(a, b);
            Assert.That(result,Is.EqualTo(expected));
        }
        [TestCase(2, 3, 6)]
        [TestCase(-2, 4, -8)]
        public void TestMultiplication(int a, int b, int expected)
        {
            double result = calc.Multiplication(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }
        [TestCase(10, 2, 5)]
        [TestCase(9, 3, 3)]
        public void TestDivision(int a, int b, int expected)
        {
            double result = calc.Division(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TestDivisionByZero()
        {
            try
            {
                calc.Division(10, 0);
                Assert.Fail("Division by zero");  // only triggers if no exception is thrown
            }
            catch (ArgumentException ex)
            {
                Assert.That(ex.Message, Is.EqualTo("Second Parameter Can't be Zero"));  // ✅ match the actual string
            }
        }

        [Test]
        public void TestAddAndClear()
        {
            calc.Add(5, 5);
            Assert.That(calc.GetResult, Is.EqualTo(10));

            calc.AllClear();
            Assert.That(calc.GetResult, Is.EqualTo(0));
        }
    }
}
