using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Test.Classwork
{
    [TestFixture]
    class MathFunkTest
    {
        [Test]
        public void MultiplyTest()
        {
            int a = 2;
            int b = 2;
            int expected = 4;
            Main.Classwork.Lesson3.MathFunk mathFunk = new Main.Classwork.Lesson3.MathFunk();
            Assert.AreEqual(expected, mathFunk.Multiply(a, b));
        }

        [Test]
        public void AditionTest()
        {
            int a = 2;
            int b = 12;
            int expected = 14;
            Main.Classwork.Lesson3.MathFunk mathFunk = new Main.Classwork.Lesson3.MathFunk();
            Assert.AreEqual(expected, mathFunk.Adition(a, b));
        }

        [Test]
        public void SubstractionTest()
        {
            int a = 2;
            int b = 1;
            int expected = 1;
            Main.Classwork.Lesson3.MathFunk mathFunk = new Main.Classwork.Lesson3.MathFunk();
            Assert.AreEqual(expected, mathFunk.Substraction(a, b));
        }

        [Test]
        public void DivisionTest()
        {
            Main.Classwork.Lesson3.MathFunk mathFunk = new Main.Classwork.Lesson3.MathFunk();
            Assert.AreEqual(3.3333333333333335d, mathFunk.Division(10, 3));
        }
    }
}