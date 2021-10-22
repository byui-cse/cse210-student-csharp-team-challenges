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
<<<<<<< HEAD
        }

        public string getGuess()
        {
            _guess.getGuess();
            return null;
=======
>>>>>>> 97eb3c49fcdd0b8f5b775ddacf894d2a298dc821
        }
        
    }
}