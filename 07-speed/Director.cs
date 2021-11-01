using System;
using System.Collections.Generic;
using Raylib_cs;

namespace _07_speed
{
    /// <summary>
    /// The director is responsible to direct the game, including to keep track of all
    /// the actors and to control the sequence of play.
    /// 
    /// Stereotype:
    ///     Controller
    /// </summary>
    public class Director
    {
        private bool _keepPlaying = true;

        OutputService _outputService = new OutputService();
        InputService _inputService = new InputService();

        TextBox _textBox = new TextBox();
        private string _buffer = "";


        Word _word = new Word();
        List<Actor> _words = new List<Actor>();
        List<Actor> _excludeWords = new List<Actor>();
        ScoreBoard _scoreBoard = new ScoreBoard();

        /// <summary>
        /// This method starts the game and continues running until it is finished.
        /// </summary>
        public void StartGame()
        {
            PrepareGame();

            while (_keepPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();

                if (_inputService.IsWindowClosing())
                {
                    _keepPlaying = false;
                }
            }

            Console.WriteLine("Game over!");
        }

        /// <summary>
        /// Performs any initial setup for the game.
        /// </summary>
        private void PrepareGame()
        {
            _outputService.OpenWindow(Constants.MAX_X, Constants.MAX_Y, "Speed", Constants.FRAME_RATE);
        }

        private void GetInputs()
        {
            _buffer += _inputService.ReturnKeyPressed();
            if (_inputService.EnterPressed())
            {
                foreach(Word word in _words)
                {
                    if (word.CheckGuess(_buffer))
                    {
                        _scoreBoard.AddPoints(word.GetLength());
                        _excludeWords.Add(word);
                    }
                }
                _buffer = "";
            }

        }

        /// <summary>
        /// Get any input needed from the user.
        /// </summary>

        /// <summary>
        /// Update any of the actors.
        /// </summary>
        private void DoUpdates()
        {
            for(int i = 0; i < 10; i++)
            {
                _words.Add(new Word());
                _words[i].MoveNext();

                if(IsCollision(_words[i]))
                {
                    _scoreBoard.AddPoints(-_words[i].GetLength());
                    _words.Remove(_words[i]);
                }
            }

        }

        /// <summary>
        /// Display the updated state of the game to the user.
        /// </summary>
        private void DoOutputs()
        { 

            _outputService.StartDrawing();

            _outputService.DrawActor(_scoreBoard);

            _textBox.UpdateTextBox(_buffer);

            _outputService.DrawActor(_textBox);

            for(int i = 0; i < 10; i++)
            {
                _outputService.DrawText(_words[i].GetX(),_words[i].GetY(),_words[i].GetText(),true);
            }

            _outputService.EndDrawing();
        }

        /// <summary>
        /// Looks for and handles collisions between the snake's head
        /// and it's body.
        /// </summary>
        

        public bool IsCollision(Actor actor)
        {
            int x1 = actor.GetX();
            if(x1 <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
