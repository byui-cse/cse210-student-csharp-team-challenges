using System;
using System.Collections.Generic;

namespace _07_snake
{
    
    class Word : Actor
    {
        private List<Actor> _words = new List<Actor>();

        public Word()
        {
            SetWord();
        }

        /// <summary>
        /// Prepares the initial body in the middle of the screen.
        /// </summary>
        private void SetWord()
        {
            Random rnd = new Random();
            int x = Constants.MAX_X;
            int y = rnd.Next(20, Constants.MAX_Y - 20);
            Point position = new Point(x, y);
            Point velocity = new Point(rnd.Next(-10,0), 0);
            _words.Add("BoomBaby");
            



        }

        public void Move()
        {
        }

    }

}