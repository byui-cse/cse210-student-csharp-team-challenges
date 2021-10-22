//displaying board and doing the logic for each guess
using System;

namespace _06_mastermind
{
    class Board
    {
        private string _number;
        public Board()
        {
            Random rnd = new Random();
            _number += rnd.Next(1000,10000);
        }
        public string Display(string name, string guess)
        {
            string DisplayText = "";
            DisplayText += $"Player {name}: {guess}, ";
            DisplayText += GetHint(guess);

            return DisplayText;
        }

        private string GetHint(string guess)
        {
            string HintText = "";
            for (int i = 0; i < 4; i++)
            {
                if (guess[i] == _number[i])
                {
                    HintText += "x";
                }
                else if (_number.Contains(guess[i]))
                {
                    HintText += "o";
                }
                else
                {
                    HintText += "*";
                }
            }

            return HintText;
        }

        public bool CheckWin(string guess)
        {
            if (guess == _number)
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
