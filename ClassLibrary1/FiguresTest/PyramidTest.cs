using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using NUnit.Framework;

namespace UnitTest.iFigures
{
    [TestFixture]
    public class PyramidTest
    {
        [Test]
        //позитивные тесты
        [TestCase(int.MaxValue, TestName = "Тестирование при присваивание максимального значения")]
        //негативные тесты
        [TestCase(-1, ExpectedException = typeof(ArgumentException), TestName = "Тестирование при присваивание -1")]

        public void Height (int Height)
        {
            var pyramid = new Pyramid();
            pyramid.Height = Height;
        }
        [Test]
        //позитивные тесты
        [TestCase(9, TestName = "Тестирование при присваивание 9")]
        //негативные тесты
        [TestCase(0, ExpectedException = typeof(ArgumentException), TestName = "Тестирование при присваивание 0")]

        public void Area( int Area)
        {
            var pyramid = new Pyramid();
            pyramid.Area = Area;
        }

        [Test]
        [TestCase(2,3, 2, TestName = "Тестирование Volume при значениях равных 2,3")]
        [TestCase(9,5,15, TestName = "Тестирование Volume при значениях равных 9,5")]

        public void Volume(double Height, double Area , double volume)
        {
            var pyramid = new Pyramid();
            pyramid.Height = Height;
            pyramid.Area = Area;
            var result = pyramid.Volume;
            Assert.AreEqual(volume, result);
        }
    }
}
