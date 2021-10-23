using System;
using System.Collections.Generic;

namespace _06_mastermind
{
    /// <summary>
    /// The class that takes care of the current state of the players.
    /// </summary>
    class Board
    {
        private Player[] _players;

        private int _activePlayer = 0;

        private int NUM_PLAYERS = 2;

        /// <summary>
        /// Constructor to generate new player objects on startup.
        /// </summary>
        public Board(){
            _players = new Player[NUM_PLAYERS];
            for (int i = 0; i < NUM_PLAYERS; i++){
                _players[i] = new Player();
            }
        }

        /// <summary>
        /// Creates a string containing the display of the current turn.
        /// </summary>
        /// </param> win: whether or not to include the active player as the winner.
        public string formatTurnDisplay(bool win = false)
        {
            string turnDisplay = "---------------------\n";
            foreach (Player person in _players){
                turnDisplay += person.getTurnDisplay();
                turnDisplay += "\n";
            }
            turnDisplay += "---------------------\n";
            if (win){
                turnDisplay += $"{_players[_activePlayer].getName()} Wins!";
            }
            return turnDisplay;
        }

        /// <summary>
        /// Stores the current moves for the turn in the active player, then switches active player.
        /// </summary>
        /// </params> guess: what the player guessed
        ///         hint: what hint the player was given
        public void updatePlayer(string guess, string hint)
        {
            _players[_activePlayer].setLastGuess(guess);
            _players[_activePlayer].setLastHint(hint);
            switchActivePlayer();
        }

        
        /// <summary>
        /// Switches the active player to the next in the list. If at end of list, returns to start of list.
        /// </summary>
        private void switchActivePlayer(){
            if (_activePlayer == _players.Length - 1){
                _activePlayer = 0;
            } else {
                _activePlayer ++;
            }
        }

        /// <summary>
        /// Sets the name of each player.
        /// </summary>
        public void namePlayers(List<string> playerNames){
            for (int i = 0; i < playerNames.Count; i++){
                _players[i].setName(playerNames[i]);
            }
        }

    }
}