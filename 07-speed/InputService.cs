using Raylib_cs;
using System;


namespace _07_speed
{
    /// <summary>
    /// Handles all the interaction with the user input library.
    /// </summary>
    public class InputService
    {
        
        public InputService()
        {

        }

        public string ReturnKeyPressed()
        {
            int asciiLetter = Raylib.GetKeyPressed();
            char letter = ((char)asciiLetter);
            if (asciiLetter > 64 && asciiLetter < 132)
            {
                return letter.ToString();
            }
            else
            {
                return "";
            }
        }

        public bool EnterPressed()
        {
            return Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER);
        }
            
        
        /// <summary>
        /// Returns true if the user has attempted to close the window.
        /// </summary>
        /// <returns></returns>
        public bool IsWindowClosing()
        {
            return Raylib.WindowShouldClose();
        }
    }

}