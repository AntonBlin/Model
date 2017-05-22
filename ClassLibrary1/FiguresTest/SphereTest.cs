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
    public class SphereTest
    {
        [Test]
        //позитивные тесты
        [TestCase(4, TestName = "Тестирование при присваивание 4")]
        [TestCase(int.MaxValue, TestName = "Тестирование при присваивание максимального значения")]
        //негативные тесты
        [TestCase(int.MinValue, ExpectedException = typeof(ArgumentException), TestName = "Тестирование при присваивание минимального значения")]
        [TestCase(0, ExpectedException = typeof(ArgumentException), TestName = "Тестирование при присваивание 0")]
        
        public void  Sphere(int radius)
        {
            var sphere = new Sphere();
            sphere.Radius = radius;
        }


        [Test]
        [TestCase(4, 268, TestName = "Тестирование Volume при значении радиуса равного 4")]
        [TestCase(9, 3054, TestName = "Тестирование Volume при значении радиуса равного 9")]

        public void Volume(double radius, double volume)
        {
            var sphere = new Sphere();
            sphere.Radius = radius;
            var result = sphere.Volume;
            Assert.AreEqual(volume, result);
        }
    }
}
