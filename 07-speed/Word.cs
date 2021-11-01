using System;
using System.Collections.Generic;

namespace _07_speed
{
    /// <summary>
    /// Represents the snake in the game which is composed of a list
    /// of overlapping segments.
    /// </summary>
    class Word : Actor
    {
        private List<Actor> _words = new List<Actor>();
        

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
            int y = rnd.Next(20,Constants.MAX_Y - 25);

            Point position = new Point(x, y);
            Point velocity = new Point(rnd.Next(-10,0)/2,0);
            _text = GetRandWord();
            SetVelocity(velocity);
            SetPosition(position);
        }

        public string GetRandWord()
        {
            string[] lines = System.IO.File.ReadAllLines("WordBank.txt");
            Random rnd = new Random();
            return lines[rnd.Next(lines.Length)];
        }
        public void Move()
        {
            // First move them all forward...
            MoveNext();

            
        }
        public Actor GetWord()
        {
            PrepareBody();
            return new Actor();
        }

        public bool CheckGuess(string guess)
        {
            if(guess.ToLower().Contains(_text.ToLower()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

}