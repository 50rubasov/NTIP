using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Areas;

namespace UnitTests.Areas
{
    class CircleTest
    {
        [Test]
        [TestCase(0.1, TestName = "Тестирование конструктора при присваивании 0.1.")]
        [TestCase(1.1, TestName = "Тестирование конструктора при присваивании 1.1.")]
        [TestCase(1000000000.0, TestName = "Тестирование конструктора при присваивании 1000000000.0.")]
        [TestCase(1000000000.0 - 1, TestName = "Тестирование конструктора при присваивании 1000000000.0.")]
        public void ConstructorTest(double r)
        {
            var circle = new Circle(r);
        }

        [Test]
        [TestCase(-1.5, TestName = "Тестирование конструктора при присваивании -1.5.")]
        [TestCase(0, TestName = "Тестирование конструктора при присваивании 0.")]
        [TestCase(1000000000.0 + 1, TestName = "Тестирование конструктора при присваивании 1000000000.0 +1.")]

        public void ConstructorNegativeTest(double r)
        {
            Assert.Throws<Exception>
            (
                delegate
                {
                    var circle = new Circle(r);
                }
            );
        }

        [Test]
        [TestCase(0.1, TestName = "Тестирование метода при присваивании 0.1 и 0.1.")]
        [TestCase(1.1, TestName = "Тестирование метода при присваивании 1.1 и 1.1.")]
        [TestCase(1000000000.0, TestName = "Тестирование метода при присваивании 1000000000.0.")]
        [TestCase(1000000000.0 - 1, TestName = "Тестирование метода при присваивании 1000000000.0. - 1.")]
        public void AreaTest(double r)
        {
            var circle = new Circle(r);
            var area = circle.Area;
            Assert.AreEqual(2 * Math.PI * r, area);
        }

        [Test]
        [TestCase(-1.5, TestName = "Тестирование метода при присваивании -1.5.")]
        [TestCase(0, TestName = "Тестирование метода при присваивании 0.")]
        [TestCase(1000000000.0 + 1, TestName = "Тестирование метода при присваивании 1000000000.0 +1.")]
        public void NegativeAreaTest(double r)
        {
            Assert.Throws<Exception>
            (
                delegate
                {
                    var circle = new Circle(r);
                    var area = circle.Area;
                    Assert.AreEqual(2 * Math.PI * r, area);
                }
            );
        }
    }
}
