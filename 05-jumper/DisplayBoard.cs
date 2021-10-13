using System;

namespace _05_jumper
{
    public class Board
    {
        public int _incorrectCount = 0;
        static void DisplayBoard()
        {
            Console.WriteLine("Starting point for the Jumper project.");
        }
        static void DisplayParachute(int incorrect_guess)
        {
            UserService UseSer = new UserService();
            if(incorrect_guess == 0)
            {
                UseSer.DisplayText(" ___ ");
            }
            if(incorrect_guess < 1)
            {
                UseSer.DisplayText(@"/   \");
            }
            if(incorrect_guess < 2)
            {
                UseSer.DisplayText(@"\___/");
                UseSer.DisplayText("||| \no");
                UseSer.DisplayText(@"/I\");
                UseSer.DisplayText(@"/\");
            }
            else
            {
                UseSer.DisplayText("x");
                UseSer.DisplayText(@"/I\");
                UseSer.DisplayText(@"/\");          
            }
        }
    }
}
