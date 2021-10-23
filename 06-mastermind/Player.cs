using System;

namespace _06_mastermind
{
    /// <summary>
    /// Class that basically acts as a struct to hold data about each player
    /// </summary>
    class Player
    {
        string _lastGuess = "----";

        string _lastHint = "****";

        string _name;

        /// <summary>
        /// Sets the player name
        /// </summary>
        /// </params> name: what to set the name as
        public void setName(string name){
            _name = name;
        }

        /// <summary>
        /// Returns the player name
        /// </summary>
        /// <returns> _name
        public void setLastGuess(string guess)
        {
            _lastGuess = guess;
        }

        /// <summary>
        /// Stores the hint in _lastHint
        /// </summary>
        /// </params> hint: what to save in _lastHint
        public void setLastHint(string hint)
        {
            _lastHint = hint;
        }

        /// <summary>
        /// Returns this players portion of the turn display
        /// </summary>
        /// </returns> A string formatted for use in turn display.
        public string getTurnDisplay()
        {
            string turnDisplay = $"Player {_name}: {_lastGuess}, {_lastHint}";
            return turnDisplay;
        }
    }
}