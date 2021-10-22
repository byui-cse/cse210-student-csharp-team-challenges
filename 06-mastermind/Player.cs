//creating new players and holds guess
using System;

namespace _06_mastermind
{
    class Player
    {
        private string _name;
        private Guess _guess = new Guess();

        public Player(string name)
        {
            _name = name;
            _guess = new Guess();
        }
        public string getName()
        {
            return _name;
        }
        public string getGuess()
        {
            string guess = _guess.Get();
            return guess;
        }
        public void setGuess(string guess)
        {
            _guess.Set(guess);
        }
    }
}