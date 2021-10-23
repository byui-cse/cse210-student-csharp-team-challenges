using System;
using System.Collections.Generic;
using System.IO;

namespace _05_jumper
{

    ///<summary> Word class handles everything to do with the secret word that the player is trying to guess.<summary>
    ///The functions include:
    ///      SelectWord() generates a random word
    ///      CheckGuess() compares the guess to the true word and updates the displayed word
    ///      IsGuessed() determines whether or not the display and true word match
    ///      GetWordDisplay() returns the displayed word  
    class Word
    {
        string _word = "";
        string _wordDisplay = "";

        ///<summary> Selects a word at random from a txt file and changes the _word member variable and creates blank _wordDisplay.
        ///<params> none
        ///<returns> none
        public void SelectWord()
        {
            List<string> lines = new List<string>(File.ReadAllLines("WordList.txt"));
            Random r = new Random();
            int randomLineNumber = r.Next(0, lines.Count - 1);
            string word = lines[randomLineNumber];

            _word = word;
            _wordDisplay = "";
            
            foreach (char _ in _word)
            {
                _wordDisplay += "_";
            }
        }

        /// <summary> Check to see if the guessed letter is in the word, if so, update the displayed word
        ///<params> char guess - This is the guessed letter from the user
        ///<returns> bool - whether or not the guess was correct
        public bool CheckGuess(char guess)
        {
            if (_word.Contains(guess))
            {
                for(int i = 0; i < _word.Length; i++)
                {
                    if (guess == _word[i])
                    {
                        char[] charList = _wordDisplay.ToCharArray();
                        charList[i] = guess;
                        string updatedWord = new string (charList);

                        _wordDisplay = updatedWord;
                    }
                }

                return true;
            }

            else
            {
                return false;
            }
        }

        ///<summary> This method checks to see if the answer word and display word are the same, indicating end of game
        ///<params> none
        ///<returns> bool
        public bool IsGuessed()
        {
            if (_word == _wordDisplay)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        ///<summary> returns the display word for use in other places in the program
        ///<params> none
        ///<returns> string _wordDisplay
        public string GetWordDisplay()
        {
            return _wordDisplay;
        }

        ///<summary> returns the  word for use in other places in the program
        ///<params> none
        ///<returns> string _word
        public string GetFinalWord()
        {
            return _word;
        }
    }
}