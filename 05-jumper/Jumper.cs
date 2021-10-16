using System;

namespace _05_jumper
{
    class Jumper
    {
        int _lives = 4;

        public void LoseLife()
        {
            _lives -= 1;
        }

        public string GetStatus()
        {
            string jumper = "";

            if (_lives == 4)
            {
                jumper += @" ___  " + "\n";
                jumper += @"/___\" + "\n";
                jumper += @"\   / " + "\n";
                jumper += @" \ /  " + "\n";
                jumper += "   0   " + "\n";
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
                jumper += "   0   " + "\n";
                jumper += @" /|\  " + "\n";
                jumper += @" / \  " + "\n";
                jumper += "\n";
                jumper += "^^^^^^^";
            }
            else if (_lives == 2)
            {
                jumper += @"\   / " + "\n";
                jumper += @" \ /  " + "\n";
                jumper += "   0   " + "\n";
                jumper += @" /|\  " + "\n";
                jumper += @" / \  " + "\n";
                jumper += "\n";
                jumper += "^^^^^^^";
            }
            else if (_lives == 1)
            {
                jumper += @" \ /  " + "\n";
                jumper += "   0   " + "\n";
                jumper += @" /|\  " + "\n";
                jumper += @" / \  " + "\n";
                jumper += "\n";
                jumper += "^^^^^^^";
            }
            else if (_lives == 0)
            {
                jumper += "   X   " + "\n";
                jumper += @" /|\  " + "\n";
                jumper += @" / \  " + "\n";
                jumper += "\n";
                jumper += "^^^^^^^";
            }
            return jumper;
        }

        public bool IsAlive()
        {
            return _lives != 0;
        }
    }
}