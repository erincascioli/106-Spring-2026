using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Demo
{
    /// <summary>
    /// CLASS (Reference type) that represents a Rectangle in 2D space.
    /// </summary>
    internal class RectangleClass
    {
        private float x;
        private float y;
        private float width;
        private float height;

        public float X
        {
            get { return x; }
            set { x = value; }
        }

        public float Y
        {
            get { return y; }
            set { y = value; }
        }

        /// <summary>
        /// Returns the area of this Rectangle
        /// </summary>
        public float Area
        {
            get { return width * height; }
        }

        /// <summary>
        /// Constructs a Rectangle object
        /// </summary>
        /// <param name="x">X coordinate (on a 2D plane)</param>
        /// <param name="y">Y coordinate (on a 2D plane)</param>
        /// <param name="width">Width</param>
        /// <param name="height">Height</param>
        public RectangleClass(float x, float y, float width, float height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        /// <summary>
        /// Prints information about this Rectangle's coordinates
        /// </summary>
        public void PrintRectangle()
        {
            Console.WriteLine($"({x}, {y})");
        }

        /// <summary>
        /// Returns a string representation of this RectangleClass object
        /// </summary>
        /// <returns>String representation of a RectangleClass object</returns>
        public override string ToString()
        {
            return $"({x}, {y})";
        }

        /// <summary>
        /// Overloading the addition operator to return the combined areas of both Rectangles
        /// </summary>
        /// <param name="r1">First Rectangle (left operand)</param>
        /// <param name="r2">Second Rectangle (right operand)</param>
        /// <returns>Combined area of both Rectangles</returns>
        public static float operator +(RectangleClass r1, RectangleClass r2)
        {
            // return the combined area of both rectangles
            return r1.Area + r2.Area;
        }
    }
}
