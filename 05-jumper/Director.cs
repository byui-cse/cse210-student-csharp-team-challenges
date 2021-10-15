using System;

namespace _05_jumper
{
    public class Director
    {
        public bool _keepPlaying;
        public WordBank _words;
        public UserService _userService;
        public Board _board;

        /// <summary>
        /// Initializes the actors of the game.
        /// </summary>
        public Director()
        {
            _keepPlaying = true;
            _words = new WordBank();
            _userService = new UserService();
            _board = new Board();
        }

        /// <summary>
        /// This method starts the game and continues running until it is finished.
        /// </summary>
        public void StartGame()
        {
            while (_keepPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        /// <summary>
        /// Get any input needed from the user.
        /// </summary>
        public void GetInputs()
        {
            // char guess = _userService.GetLetter();
            // _board.DisplayBoard();

            _board.DisplayBoard();
            _board.DisplayParachute();
            string prompt = "Guess a letter [a-z]: ";
            char guess = _userService.GetLetterChoice(prompt);

            _board.CheckGuess(guess);
        }

        /// <summary>
        /// Update any of the actors.
        /// </summary>
        public void DoUpdates()
        {   
            _keepPlaying = _board.IsAlive();
        }

        /// <summary>
        /// Display the updated state of the game to the user.
        /// </summary>
        public void DoOutputs()
        {
            if (_keepPlaying == false)
                _board.DisplayParachute();
                Console.WriteLine("Game Over");
            if(_board.CheckWin())
            {
                _board.DisplayParachute();
                Console.WriteLine("You Win!!");
                _keepPlaying = false;
            }
        }
    }
}
/*board class
check jumper is alive
guess
load words from word bank class*/