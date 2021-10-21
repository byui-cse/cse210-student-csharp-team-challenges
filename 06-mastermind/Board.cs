using System;
using System.Collections.Generic;

namespace _06_mastermind
{
    class Board
    {
        private Player[] _players;

        private int _activePlayer = 0;

        private int NUM_PLAYERS = 2;

        public Board(){
            _players = new Player[NUM_PLAYERS];
            for (int i = 0; i < NUM_PLAYERS; i++){
                _players[i] = new Player();
            }
        }

        public string formatTurnDisplay()
        {
            string turnDisplay = "---------------------\n";
            foreach (Player person in _players){
                turnDisplay += person.getTurnDisplay();
                turnDisplay += "\n";
            }
            turnDisplay += "---------------------\n";
            return turnDisplay;
        }
        private void updatePlayer(string guess, string hint)
        {
            _players[_activePlayer].setLastGuess(guess);
            _players[_activePlayer].setLastHint(hint);
            switchActivePlayer();
        }

        private void switchActivePlayer(){
            if (_activePlayer == _players.Length - 1){
                _activePlayer = 0;
            } else {
                _activePlayer ++;
            }
        }

        public void namePlayers(List<string> playerNames){
            for (int i = 0; i < playerNames.Count; i++){
                _players[i].setName(playerNames[i]);
            }
        }

    }
}