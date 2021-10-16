using System;

namespace _05_jumper
{
    /// <Summary>
    /// Main class of program, manages game loop.
    /// </Summary>
    class Director
    {
        UserService _userService = new UserService();
        Jumper _jumper = new Jumper();
        Word _word = new Word();
        bool _playing = true;

        /// <Summary>
        /// Initializes the game.
        /// </Summary>
        private void StartGame()
        {

        }

        /// <Summary>
        /// Monitors main gameplay loop.
        /// </Summary>
        public void PlayGame()
        {
            StartGame();
            while(_playing){
                DoOutput();
                char guess = GetGameInput();
                DoUpdates(guess);
            }
        }
        
        /// <Summary>
        /// Input processor for main gameplay loop
        /// </Summary>
        private char GetGameInput()
        {
            char guess =_userService.GetGuess();
            return guess;
        }

        /// <Summary>
        /// Updates gameplay state based on user input
        /// </Summary>
        private void DoUpdates(char guess)
        {
            if (!_jumper.IsAlive() || _word.isGuessed()){
                _playing = false;
            } else if (!_word.CheckGuess(guess)){
                _jumper.LoseLife();
            }
        }

        /// <Summary>
        /// Displays game state to user
        /// </Summary>
        private void DoOutput()
        {
            string wordState = _word.GetWordDisplay();
            string jumperState = _jumper.GetStatus();
            _userService.DisplayBoard(wordState,jumperState);
        }

        /// <Summary>
        /// Displays end of game output prompting to play again
        /// </Summary>
        public bool EndGame()
        {
            return _userService.GetPlayAgain();
        }
    }
}