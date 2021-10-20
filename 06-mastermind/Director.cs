using System;

namespace _06_mastermind
{
    class Director
    {
        static void Main(string[] args)
        {
            UserService _userservice = new UserService();
            string name = _userservice.GetStringInput("What is the name of player 1?  ");
            Player _player1 = new Player(name);
            string name = _userservice.GetStringInput("What is the name of player 2?  ");
            Player _player2 = new Player(name);
        }
    }
}
