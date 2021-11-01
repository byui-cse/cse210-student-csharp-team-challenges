using Raylib_cs;


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

        public bool IsKeyPressed(KeyboardKey key)
        {
            if(Raylib.IsKeyPressed(key))
            {
                return true;
            }
            else
            {
                return false;
            }
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