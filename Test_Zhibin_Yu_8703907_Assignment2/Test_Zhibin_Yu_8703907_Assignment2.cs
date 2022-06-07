using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zhibin_Yu_8703907_Assignment2;

namespace Test_Zhibin_Yu_8703907_Assignment2
{
    [TestFixture]
    public class Test_Zhibin_Yu_8703907_Assignment2
    {
        [Test]
        public void GetLength1()
        {
            //arrange
            Rectangle rectangle = new Rectangle();
            int expected = 1;

            //act
            int actual = rectangle.GetLength();

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetLength2()
        {
            //arrange
            Rectangle rectangle = new Rectangle(2, 3);
            int expected = 2;

            //act
            int actual = rectangle.GetLength();

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetLength3()
        {
            //arrange
            Rectangle rectangle = new Rectangle(3, 4);
            int expected = 3;

            //act
            int actual = rectangle.GetLength();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ChangeLength1()
        {
            //arrange
            Rectangle rectangle = new Rectangle();
            int newLength = 2;
            int expected = 2;

            //act
            int actual = rectangle.SetLength(newLength);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ChangeLength2()
        {
            //arrange
            Rectangle rectangle = new Rectangle();
            int newLength = 3;
            int expected = 3;

            //act
            int actual = rectangle.SetLength(newLength);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ChangeLength3()
        {
            //arrange
            Rectangle rectangle = new Rectangle();
            int newLength = 4;
            int expected = 4;

            //act
            int actual = rectangle.SetLength(newLength);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetWidth1()
        {
            //arrange
            Rectangle rectangle = new Rectangle();
            int expected = 1;

            //act
            int actual = rectangle.GetWidth();

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetWidth2()
        {
            //arrange
            Rectangle rectangle = new Rectangle(2, 3);
            int expected = 3;

            //act
            int actual = rectangle.GetWidth();

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetWidth3()
        {
            //arrange
            Rectangle rectangle = new Rectangle(3, 4);
            int expected = 4;

            //act
            int actual = rectangle.GetWidth();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ChangeWidth1()
        {
            //arrange
            Rectangle rectangle = new Rectangle();
            int newWidth = 2;
            int expected = 2;

            //act
            int actual = rectangle.SetWidth(newWidth);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ChangeWidth2()
        {
            //arrange
            Rectangle rectangle = new Rectangle();
            int newWidth = 3;
            int expected = 3;

            //act
            int actual = rectangle.SetWidth(newWidth);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ChangeWidth3()
        {
            //arrange
            Rectangle rectangle = new Rectangle();
            int newWidth = 4;
            int expected = 4;

            //act
            int actual = rectangle.SetWidth(newWidth);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetPerimeter1()
        {
            //arrange
            Rectangle rectangle = new Rectangle();
            int expected = 4;

            //act
            int actual = rectangle.GetPerimeter();

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetPerimeter2()
        {
            //arrange
            Rectangle rectangle = new Rectangle(2, 3);
            int expected = 10;

            //act
            int actual = rectangle.GetPerimeter();

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetPerimeter3()
        {
            //arrange
            Rectangle rectangle = new Rectangle(3, 4);
            int expected = 14;

            //act
            int actual = rectangle.GetPerimeter();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetArea1()
        {
            //arrange
            Rectangle rectangle = new Rectangle();
            int expected = 1;

            //act
            int actual = rectangle.GetArea();

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetArea2()
        {
            //arrange
            Rectangle rectangle = new Rectangle(2, 3);
            int expected = 6;

            //act
            int actual = rectangle.GetArea();

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetArea3()
        {
            //arrange
            Rectangle rectangle = new Rectangle(3, 4);
            int expected = 12;

            //act
            int actual = rectangle.GetArea();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
