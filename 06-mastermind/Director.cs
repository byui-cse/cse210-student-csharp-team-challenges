using System;

namespace _06_mastermind
{
    class Director
    {
        Board _board;

        Code _code;

        UserService _userService;

      
        bool _keepPlaying;

        private string getInputs()
        {
            string guess = _userService.getGuess();

            return guess;
        }
        private void doUpdates(string guess)
        {
            if (!_code.isSecret(guess))
            {
                string hint = _code.getHint(guess);
                _board.updatePlayer(guess);
            }
            else
            {
                _keepPlaying = false;
            }
        }
        private void doOutput()
        {
            _userService.displayTurn(_board.formatTurnDisplay());
        }
        private void startGame()
        {
            _userService = new UserService();
            _code = new Code();
            _board = new Board();
        }
        public void playGame()
        {
            startGame();
            doOutput();
            while(_keepPlaying)
            {
                string guess = getInputs();
                doUpdates(guess);
                doOutput();
            }

        
        }

    }
}