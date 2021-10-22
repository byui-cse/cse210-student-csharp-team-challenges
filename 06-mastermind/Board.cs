//displaying board and doing the logic for each guess
using System;

namespace _06_mastermind
{
    class Board
    {
        private int code;
        public Board()
        {
            Random rng = new Random();
            code= rng.Next(1000,10000);
        }
    }
}
