using System;
using System.Collections.Generic;

namespace _07_snake
{
    /// <summary>
    /// Represents the snake in the game which is composed of a list
    /// of overlapping segments.
    /// </summary>
    class Word : Actor
    {
        private List<string> _words = new List<string>();
        

        public Word()
        {
            PrepareBody();
        }

        /// <summary>
        /// Prepares the initial body in the middle of the screen.
        /// </summary>
        private void PrepareBody()
        {
            Random rnd = new Random();
            int x = Constants.MAX_X;
            int y = rnd.Next(20,Constants.MAX_Y - 20);

            Point position = new Point(x, y);
            Point velocity = new Point(rnd.Next(-10,0), 0);
            SetVelocity(velocity);
        }
        public void Move()
        {
            // First move them all forward...
            MoveNext();

            
        }

    }

}