using System;

namespace _05_jumper
{
    public class Director
    {
        public bool _keepPlaying;
        public Parachute _parachute;
        public WordBank _words;
        public UserService _userService;
        public Board _board;

        /// <summary>
        /// Initializes the actors of the game.
        /// </summary>
        public Director()
        {
            _keepPlaying = true;
            _parachute = new Parachute();
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
            string message = _parachute.GetLetter();
            _board.DisplayBoard(message);

            string prompt = "Enter a location [1-1000]: ";
            int location = _userService.GetNumberChoice(prompt);

            _seeker.Move(location);
        }

        /// <summary>
        /// Update any of the actors.
        /// </summary>
        public void DoUpdates()
        {
            _hider.Watch(_seeker._location);
            
            // Keep playing if the hider is not found (the ! symbol means not)
            _keepPlaying = !_hider.IsFound();

        }

        /// <summary>
        /// Display the updated state of the game to the user.
        /// </summary>
        public void DoOutputs()
        {
            string hint = _hider.GetHint();
            _userService.DisplayText(hint);
        }
    }
}
/*board class
check jumper is alive
guess
load words from word bank class*/