﻿using NUnit.Framework;
using GeometricFigures;

namespace NUnit.TriangleTesting
{
    [TestFixture]
    public class TestClass
    {
        [TestFixtureSetUp]
        public void TestFixtureSetUp()
        {
            System.Console.WriteLine("Start Triangle test suite");
        }

        [TestFixtureTearDown]
        public void TestFixtureTearDown()
        {
            System.Console.WriteLine("End Triangle test suite");
        }

        [SetUp]
        public void SetUp()
        {
            System.Console.WriteLine("Start test case");
        }

        [TearDown]
        public void TearDown()
        {
            System.Console.WriteLine("End test case");
        }


        [Test, TestCaseSource("incomingPositiveValues")]
        public void getLengthTriangle(int x)
        {
            Triangle positiveLength = new Triangle(x);
            var lengthByMethod = positiveLength.getLengthSquare();
            var lengthByMath = 4 * x;
            Assert.IsTrue(lengthByMethod == lengthByMath, "Expected {0} but {1}", lengthByMethod, lengthByMath);
        }

        [Test, TestCaseSource("incomingPositiveValues")]
        public void getAreaSquare(int x)
        {
            Square positiveArea = new Square(x);
            var squareByMethod = positiveArea.getAreaSquare();
            var squareByMath = x * x;
            Assert.IsTrue(squareByMethod == squareByMath, "Expected {0} but {1}", squareByMethod, squareByMath);
        }

        static object[] incomingPositiveValues =
            {
                new object[] { 0 },
                new object[] { 1 },
                new object[] { 2 },
                new object[] { 3 },
                new object[] { 4 },
                new object[] { 5 },
                new object[] { 6 },
                new object[] { 7 },
                new object[] { 8 },
                new object[] { 9 },
                new object[] { 10 },
                new object[] { 11 },
                new object[] { 12 },
                new object[] { 13 },
                new object[] { 14 },
                new object[] { 15 },
                new object[] { 16 },
                new object[] { 17 },
                new object[] { 18 },
                new object[] { 19 },
                new object[] { 20 },
            };

    }
}
