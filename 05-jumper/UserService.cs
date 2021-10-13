using System;

namespace _05_jumper
{
    public class UserService
    {
        static void DisplayText(string text)
        {
            Console.WriteLine(text);
        }

        static void getLetterInput(string promptText)
        {
            Console.Write(promptText);
            string letter = Console.ReadLine();

        } 
    }
}

