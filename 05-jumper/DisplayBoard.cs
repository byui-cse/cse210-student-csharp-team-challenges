using System;
using System.Collections.Generic;

namespace _05_jumper
{
    public class Board
    {
        public static int _fails = 0;
        public WordBank _words = new WordBank();
        public static string _word;
        public static List<char> _hiddenWord = new List<char>();
        public Board()
        {
            _word = _words.GetWord();
            for(int i = 0; i < _word.Length; i++)
            {
                _hiddenWord.Add('_');
            }
        }
        public void DisplayBoard()
        {
            foreach(char place in _hiddenWord)
            {
                Console.Write(place + " ");
            }
            Console.WriteLine("");
        }
        public void DisplayParachute()
        {
            UserService UseSer = new UserService();
            if(_fails < 1)
            {
                UseSer.DisplayText("    ___ ");
            }
            if(_fails < 2)
            {
                UseSer.DisplayText(@"   /   \");
            }
            if(_fails < 3)
            {
                UseSer.DisplayText(@"   \___/");
                UseSer.DisplayText(@"    \|/");
                UseSer.DisplayText("     o");
                UseSer.DisplayText(@"    /I\");
                UseSer.DisplayText(@"    / \");
                UseSer.DisplayText("\n^^^^^^^^^^");
            }
            else
            {
                UseSer.DisplayText(" x");
                UseSer.DisplayText(@"/I\");
                UseSer.DisplayText(@"/ \");          
            }
        }

        public void CheckGuess(char letter)
        {
            bool isHere = false;
           for(int i = 0; i < _word.Length; i++)
           {
               if(letter == _word[i])
               {
                   _hiddenWord[i] = letter;
                    isHere = true;
               }
           }
           if(!isHere)
           {
               _fails += 1;
           }
        }

        public bool IsAlive()
        {
            if(_fails >= 3)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool CheckWin()
        {
            if(_hiddenWord.Contains('_'))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
