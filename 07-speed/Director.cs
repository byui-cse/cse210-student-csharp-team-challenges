using System;
using System.Collections.Generic;


namespace _07_speed
{
    class Director
    {
        Scoreboard _scoreBoard = new Scoreboard();
        

        Scoreboard _lifeBoard = new Scoreboard();


        Difficulty _difficultyManager = new Difficulty();


        int _kills = 0;


        bool _playing = true;


        List<Enemies> _enemiesList = new List<Enemies>{};


        Buffer _buffer = new Buffer();


        InputService _inputService = new InputService();


        OutputService _outputService = new OutputService();        


        public void doInput()
        {

        }

        public void doUpdate()
        {

        }

        public void doOutput()
        {

        }

        public void gameOver()
        {

        }


    }
}
