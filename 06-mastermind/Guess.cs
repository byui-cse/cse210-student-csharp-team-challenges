//pulls from user service then throws to player
using System;

namespace _06_mastermind
{
    class Guess
    {
        private string _guess;

        public string getGuess()
        {
            return _guess;
        }
        public void setGuess(string guess)
        {
            _guess = guess;
        }
    }
}