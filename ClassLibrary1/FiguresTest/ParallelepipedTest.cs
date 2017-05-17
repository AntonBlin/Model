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
    public class ParallelepipedTest
    {
        [Test]
        //позитивные тесты
        [TestCase(8, TestName = "Тестирование при присваивание 4")]
        [TestCase(int.MaxValue-1, TestName = "Тестирование при присваивание максимального значеният минус 1")] 
        //негативные тесты
        [TestCase(-1, ExpectedException = typeof(ArgumentException), TestName = "Тестирование при присваивание -1")]


        public void Height(int Height)
        {
            var parallelepiped = new Parallelepiped();
            parallelepiped.Height = Height;
        }

        [Test]
        //позитивные тесты
        [TestCase(1, TestName = "Тестирование при присваивание 1")]
        [TestCase(int.MaxValue, TestName = "Тестирование при присваивание максимального значения")]
        //негативные тесты
        [TestCase(int.MinValue, ExpectedException = typeof(ArgumentException), TestName = "Тестирование при присваивание минимального значения")]


        public void Width(int Width)
        {
            var parallelepiped = new Parallelepiped();
            parallelepiped.Width = Width;
        }

        [Test]
        //позитивные тесты
        [TestCase(6, TestName = "Тестирование при присваивание 6")]
        [TestCase(int.MaxValue - 1, TestName = "Тестирование при присваивание максимального значения - 1")]
        //негативные тесты
        [TestCase(0, ExpectedException = typeof(ArgumentException), TestName = "Тестирование при присваивание 0")]


        public void Lenght (int Lenght)
        {
            var parallelepiped = new Parallelepiped();
            parallelepiped.Lenght = Lenght;
        }

        [Test]
        [TestCase(2, 3, 2,12, TestName = "Тестирование Volume при значениях равных 2,3,2")]
        [TestCase(9, 5, 15,675, TestName = "Тестирование Volume при значениях равных 9,5,15")]

        public void Volume(double Height, double Width, double Lenght, double volume)
        {
            var parallelepiped = new Parallelepiped();
            parallelepiped.Height = Height;
            parallelepiped.Width = Width;
            parallelepiped.Lenght = Lenght;
            var result = parallelepiped.Volume;
            Assert.AreEqual(volume, result);
        }
    }
}
