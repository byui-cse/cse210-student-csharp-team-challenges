using System;

namespace _05_jumper
{
    /// <Summary>
    /// Main class of program, manages game loop.
    /// </Summary>
    class Director
    {
        UserService _userService;
        Jumper _jumper;
        Word _word;
        bool _playing;

        /// <Summary>
        /// Initializes the game.
        /// </Summary>
        private void StartGame()
        {
            _userService = new UserService();
            _jumper = new Jumper();
            _word = new Word();
            _word.SelectWord();
            _playing = true;
            DoOutput();
        }

        /// <Summary>
        /// Monitors main gameplay loop.
        /// </Summary>
        public void PlayGame()
        {
            StartGame();
            while(_playing){
                char guess = GetGameInput();
                DoUpdates(guess);
                DoOutput();
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
            if (!_word.CheckGuess(guess)){
                _jumper.LoseLife();
            }
            if (!_jumper.IsAlive() || _word.IsGuessed()){
                _playing = false;
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
            string wordState = _word.GetFinalWord();
            string jumperState = _jumper.GetStatus();
            _userService.DisplayBoard(wordState, jumperState);
            return _userService.GetPlayAgain();
        }
    }
}