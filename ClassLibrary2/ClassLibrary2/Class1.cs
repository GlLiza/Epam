using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    [TestFixture]
    public class Class1
    {

        [Test]
        public void TestPlus()
        {
            //////
            int result = Calculator.Add(3, 2);
            Assert.AreEqual(5, result);

            result = Calculator.Add(5, -4);
            Assert.AreEqual(1, result);

            result = Calculator.Add(145, 3);
            Assert.AreEqual(148, result);

            result = Calculator.Add(-15, 0);
            Assert.AreEqual(-15, result);

            result = Calculator.Add(-6, -23);
            Assert.AreEqual(-29, result);
        }

        [Test]
        public void TestMinus()
        {
            int result = Calculator.Difference(3, 2);
            Assert.AreEqual(1, result);

            result = Calculator.Difference(45, 50);
            Assert.AreEqual(-5, result);

            result = Calculator.Difference(2, 5);
            Assert.AreEqual(-3, result);

            result = Calculator.Difference(8, 5);
            Assert.AreEqual(3, result);

            result = Calculator.Difference(-13, 2);
            Assert.AreEqual(-15, result);
        }

        [Test]
        public void Mult()
        {
            int result = Calculator.Multiplication(3, 2);
            Assert.AreEqual(6, result);

            result = Calculator.Multiplication(0, 2);
            Assert.AreEqual(0, result);

            result = Calculator.Multiplication(-1, 2);
            Assert.AreEqual(-2, result);

            result = Calculator.Multiplication(-6, -14);
            Assert.AreEqual(84, result);

            result = Calculator.Multiplication(7, 4);
            Assert.AreEqual(28, result);
        }

        [Test]
        public void Divis()
        {
            int result = Calculator.Division(8, 2);
            Assert.AreEqual(4, result);

            result = Calculator.Division(3, 3);
            Assert.AreEqual(1, result);

            result = Calculator.Division(3, 6);
            Assert.AreEqual(0, result);

            result = Calculator.Division(33, 11);
            Assert.AreEqual(3, result);

            result = Calculator.Division(30, 2);
            Assert.AreEqual(15, result);
        }
    }
}
