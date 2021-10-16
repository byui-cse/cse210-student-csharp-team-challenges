using System;

namespace _05_jumper
{
    class Program
    {
        static void Main(string[] args)
        {
            bool _running = true;
            Director _director = new Director();
            while (_running){
                _director.PlayGame();
                _running = _director.EndGame();
            }
        }
    }
}
