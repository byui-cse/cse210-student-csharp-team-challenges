using System;

namespace _05_jumper
{
    public class Director
    {      
        bool done = false;
        public bool _keepPlaying;
        public Jumper _jumper;
        public Board _board;
        public UserService _userService;

        Jumper jumper = new Jumper();

        public Director()
        {
            _keepPlaying = true;
            _jumper = new Jumper();
            _board = new Board();
            _userService = new UserService();
        }

        public void startGame()
        {   
            while (!done)
            {   
                GetInputs();
                DoUpdates();
                DoOutput();
            }
        }
    }
}
