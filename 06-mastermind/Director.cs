using System;

namespace _06_mastermind
{
    class Director
    {
        public Director()
        {

        }
        public void StartGame()
        {
            UserService _userservice = new UserService();
            string name = _userservice.GetStringInput("What is the name of player 1?  ");
            Player _player1 = new Player(name);
            name = _userservice.GetStringInput("What is the name of player 2?  ");
            Player _player2 = new Player(name);
        }
    }
}
