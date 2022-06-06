using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zhibin_Yu_8703907_Assignment2
{
    internal class Rectangle
    {
        private int length;
        private int width;

        public int GetLength() { return length; }
        public int SetLength(int length) { this.length = length; return length; }
        public int GetWidth() { return width; }
        public int SetWidth(int width) { this.width = width; return width; }
        public int GetPerimeter() { return (length+width)*2; }
        public int GetArea() { return length*width; }

        public Rectangle()
        {
            this.length = 1;
            this.width = 1;
        }
        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }
    }
}
