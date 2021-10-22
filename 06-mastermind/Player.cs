//creating new players and holds guess
using System;

namespace _06_mastermind
{
    class Player
    {
        private string _name;
        private Guess _guess;
        
        public Player(string name)
        {
            _name = name;
        }
        public string getName()
        {
            return _name;
        }

        public string getGuess()
        {
            _guess.getGuess();
            return null;
        }
        
    }
}