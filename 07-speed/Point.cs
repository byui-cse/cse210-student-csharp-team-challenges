using System;

namespace _07_speed
{
    /// <summary>
    /// Represents an X, Y pair.
    /// 
    /// This can be used for both a location and also a velocity.
    /// </summary>
    public class Point
    {
        private int _x;
        private int _y;

        /// <summary>
        /// Accepts a x and y coordinate value and updates the position of X and Y.
        /// </summary>
        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        /// <summary>
        /// Returns the X value of the point.
        /// </summary>
        public int GetX()
        {
            return _x;
        }

        /// <summary>
        /// Returns the Y value of the point.
        /// </summary>
        public int GetY()
        {
            return _y;
        }

        /// <summary>
        /// Returns a new point that is the result of adding this one to the provided one.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public Point Add(Point other)
        {
            int newX = _x + other._x;
            int newY = _y + other._y;

            return new Point(newX, newY);
        }

        /// <summary>
        /// Returns a new point that is the reversed version of this one.
        /// Both X and Y are multiplied by -1.
        /// </summary>
        /// <returns></returns>
        public Point Reverse()
        {
            int newX = _x * -1;
            int newY = _y * -1;

            return new Point(newX, newY);
        }

        /// <summary>
        /// Used by the system when you use == to compare the points.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is Point point &&
                   _x == point._x &&
                   _y == point._y;
        }
 
        /// <summary>
        /// 
        // If you ever override the Equals function, you should also override the GetHashCode function
        /// Returns the hascode and combines the X and Y values.
        ///</summary>
        public override int GetHashCode()
        {
            return HashCode.Combine(_x, _y);
        }
    }

}