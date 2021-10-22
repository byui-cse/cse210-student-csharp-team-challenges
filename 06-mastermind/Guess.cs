//pulls from user service then throws to player
using System;

namespace _06_mastermind
{
    class Guess
    {
        private string _guess;
        public Guess()
        {
            _guess = "----";
        }

        public string Get()
        {
            return _guess;
        }
        public void Set(string guess)
        {
            _guess = guess;
        }
    }
}