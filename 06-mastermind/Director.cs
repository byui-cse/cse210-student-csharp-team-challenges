using System;

namespace _06_mastermind
{
    class Director
    {
        Board _board;
        public Director()
        {
            _board = new Board();

        }
        public void StartGame()
        {
            int winningPlayer = 2;

            UserService _userservice = new UserService();
            string name = _userservice.GetInput("What is the name of player 1: ");
            Player _player1 = new Player(name);
            name = _userservice.GetInput("What is the name of player 2: ");
            Player _player2 = new Player(name);

            while (!_board.CheckWin(_player1.getGuess()) && !_board.CheckWin(_player2.getGuess()))
            {
                string hyphen = "--------------------";
                _userservice.DisplayText(hyphen);
                _userservice.DisplayText(_board.Display(_player1.getName(),_player1.getGuess()));
                _userservice.DisplayText(_board.Display(_player2.getName(),_player2.getGuess()));
                _userservice.DisplayText(hyphen);

                _userservice.DisplayText($"{_player1.getName()}'s turn:");
                _player1.setGuess(_userservice.GetInput("What is your guess? "));

                if (_board.CheckWin(_player1.getGuess()))
                {
                    winningPlayer = 1;
                    continue;
                }

                _userservice.DisplayText(hyphen);
                _userservice.DisplayText(_board.Display(_player1.getName(),_player1.getGuess()));
                _userservice.DisplayText(_board.Display(_player2.getName(),_player2.getGuess()));
                _userservice.DisplayText(hyphen);

                _userservice.DisplayText($"{_player2.getName()}'s turn:");
                _player2.setGuess(_userservice.GetInput("What is your guess? "));
            }
            if (winningPlayer == 1)
            {
                _userservice.DisplayText($"{_player1.getName()} won!");
            }
            else
            {
                _userservice.DisplayText($"{_player2.getName()} won!");
            }
        }
    }
}
