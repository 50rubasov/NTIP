using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Areas;

namespace UnitTests.Areas
{
    /// <summary>
    /// Набор тестов для треугольника
    /// </summary>
    [TestFixture]
    class RectangleTest
    {
        [Test]       
        [TestCase(0.1, 0.1, TestName = "Тестирование конструктора при присваивании 0.1 и 0.1.")]
        [TestCase(1.1, 1.1, TestName = "Тестирование конструктора при присваивании 1.1 и 1.1.")]
        [TestCase(1000000000.0, 1000000000.0, TestName = "Тестирование конструктора при присваивании 1000000000.0.")]
        [TestCase(1000000000.0 - 1, 1000000000.0 - 1, TestName = "Тестирование конструктора при присваивании 1000000000.0.")]
        public void ConstructorTest(double a, double b)
        {
            var rectangle = new Rectangle(a, b);
        }

        [Test]
        [TestCase(-1.5, -5.5, TestName = "Тестирование конструктора при присваивании -1.5 и -5.5.")]
        [TestCase(0, 0, TestName = "Тестирование конструктора при присваивании 0 и 0.")]
        [TestCase(1000000000.0 + 1, 1000000000.0 + 1, TestName = "Тестирование конструктора при присваивании 1000000000.0 +1.")]

        public void ConstructorNegativeTest(double a, double b)
        {
            Assert.Throws<Exception>
            (
                delegate
                {
                    var rectangle = new Rectangle(a, b);
                }
            );
        }

        [Test]
        [TestCase(0.1, 0.1, TestName = "Тестирование метода при присваивании 0.1 и 0.1.")]
        [TestCase(1.1, 1.1, TestName = "Тестирование метода при присваивании 1.1 и 1.1.")]
        [TestCase(1000000000.0, 1000000000.0, TestName = "Тестирование метода при присваивании 1000000000.0.")]
        [TestCase(1000000000.0 - 1, 1000000000.0 - 1, TestName = "Тестирование метода при присваивании 1000000000.0.")]
        public void AreaTest(double a, double b)
        {
            var rectangle = new Rectangle(a, b);
            var area = rectangle.Area;
            Assert.AreEqual(a * b, area);
        }

        [Test]
        [TestCase(-1.5, -5.5, TestName = "Тестирование метода при присваивании -1.5 и -5.5.")]
        [TestCase(0, 0, TestName = "Тестирование метода при присваивании 0 и 0.")]
        [TestCase(1000000000.0 + 1, 1000000000.0 + 1, TestName = "Тестирование метода при присваивании 1000000000.0 +1.")]
        public void NegativeAreaTest(double a, double b)
        {
            Assert.Throws<Exception>
            (
                delegate
                {
                    var rectangle = new Rectangle(a, b);
                    var area = rectangle.Area;
                    Assert.AreEqual(a * b, area);
                }
            );
        }
    }
}
