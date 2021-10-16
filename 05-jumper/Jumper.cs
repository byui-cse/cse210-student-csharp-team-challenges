using System;

namespace _05_jumper
{
    class Jumper
    {
        int _lives = 4;

        /// <summary>
        /// Indicates how many lives the user has to play with by taking away one life. 
        /// </summary>
        /// <returns>updated lives minus one</returns>
        public void LoseLife()
        {
            _lives -= 1;
        }

        /// <summary>
        /// Displays the status of the jumper. Shows the variation of lives.
        /// </summary>
        /// <returns>Returns the string jumper with correct correlation to lives</returns>
        public string GetStatus()
        {
            string jumper = "";

            if (_lives == 4)
            {
                jumper += @" ___  " + "\n";
                jumper += @"/___\" + "\n";
                jumper += @"\   / " + "\n";
                jumper += @" \ /  " + "\n";
                jumper += @"  0   " + "\n";
                jumper += @" /|\  " + "\n";
                jumper += @" / \  " + "\n";
                jumper += "\n";
                jumper += "^^^^^^^";
            }
            else if (_lives == 3)
            {
                jumper += @"/___\" + "\n";
                jumper += @"\   / " + "\n";
                jumper += @" \ /  " + "\n";
                jumper += @"  0   " + "\n";
                jumper += @" /|\  " + "\n";
                jumper += @" / \  " + "\n";
                jumper += "\n";
                jumper += "^^^^^^^";
            }
            else if (_lives == 2)
            {
                jumper += @"\   / " + "\n";
                jumper += @" \ /  " + "\n";
                jumper += @"  0   " + "\n";
                jumper += @" /|\  " + "\n";
                jumper += @" / \  " + "\n";
                jumper += "\n";
                jumper += "^^^^^^^";
            }
            else if (_lives == 1)
            {
                jumper += @" \ /  " + "\n";
                jumper += @"  0   " + "\n";
                jumper += @" /|\  " + "\n";
                jumper += @" / \  " + "\n";
                jumper += "\n";
                jumper += "^^^^^^^";
            }
            else if (_lives == 0)
            {
                jumper += @"   X   " + "\n";
                jumper += @" /|\  " + "\n";
                jumper += @" / \  " + "\n";
                jumper += "^^^^^^^";
            }
            return jumper;
        }

        /// <summary>
        /// Determines if the jumper is alive and has remaining lives.
        /// </summary>
        /// <returns>Returns true if lives is greater than one</returns>
        public bool IsAlive()
        {
            return _lives != 0;
        }
    }
}