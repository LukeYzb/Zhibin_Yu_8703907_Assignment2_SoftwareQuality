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
            Rectangle rectangle = new Rectangle();

            //arrange
            int expected = 1;

            //act
            int actual = rectangle.GetLength();

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetLength2()
        {
            Rectangle rectangle = new Rectangle(2,3);

            //arrange
            int expected = 2;

            //act
            int actual = rectangle.GetLength();

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetLength3()
        {
            Rectangle rectangle = new Rectangle(3,4);

            //arrange
            int expected = 3;

            //act
            int actual = rectangle.GetLength();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ChangeLength1()
        {
            Rectangle rectangle = new Rectangle();

            //arrange
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
            Rectangle rectangle = new Rectangle();

            //arrange
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
            Rectangle rectangle = new Rectangle();

            //arrange
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
            Rectangle rectangle = new Rectangle();

            //arrange
            int expected = 1;

            //act
            int actual = rectangle.GetWidth();

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetWidth2()
        {
            Rectangle rectangle = new Rectangle(2,3);

            //arrange
            int expected = 3;

            //act
            int actual = rectangle.GetWidth();

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetWidth3()
        {
            Rectangle rectangle = new Rectangle(3,4);

            //arrange
            int expected = 4;

            //act
            int actual = rectangle.GetWidth();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ChangeWidth1()
        {
            Rectangle rectangle = new Rectangle();

            //arrange
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
            Rectangle rectangle = new Rectangle();

            //arrange
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
            Rectangle rectangle = new Rectangle();

            //arrange
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
            Rectangle rectangle = new Rectangle();

            //arrange
            int expected = 4;

            //act
            int actual = rectangle.GetPerimeter();

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetPerimeter2()
        {
            Rectangle rectangle = new Rectangle(2,3);

            //arrange
            int expected = 10;

            //act
            int actual = rectangle.GetPerimeter();

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetPerimeter3()
        {
            Rectangle rectangle = new Rectangle(3,4);

            //arrange
            int expected = 14;

            //act
            int actual = rectangle.GetPerimeter();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetArea1()
        {
            Rectangle rectangle = new Rectangle();

            //arrange
            int expected = 1;

            //act
            int actual = rectangle.GetArea();

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetArea2()
        {
            Rectangle rectangle = new Rectangle(2,3);

            //arrange
            int expected = 6;

            //act
            int actual = rectangle.GetArea();

            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetArea3()
        {
            Rectangle rectangle = new Rectangle(3,4);

            //arrange
            int expected = 12;

            //act
            int actual = rectangle.GetArea();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
