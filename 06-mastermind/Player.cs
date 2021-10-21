using System;

namespace _06_mastermind
{
    class Player
    {
        string _lastGuess = "----";

        string _lastHint = "****";

        string _name;

        public void setName(string name){
            _name = name;
        }

        public void setLastGuess(string guess)
        {
            _lastGuess = guess;
        }

        public void setLastHint(string hint)
        {
            _lastHint = hint;
        }
        public string getTurnDisplay()
        {
            string turnDisplay = $"Player {_name}: {_lastGuess}, {_lastHint}";
            return turnDisplay;
        }
    }
}