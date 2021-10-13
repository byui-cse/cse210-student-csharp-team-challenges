using System;

namespace _05_jumper
{
    public class UserService
    {
        public char GetLetterChoice(string prompt)
        {
            Console.Write(prompt);
            char guess = Convert.ToChar(Console.ReadLine());
        }   

        public void DisplayText(string text)
        {
            Console.WriteLine(text);
        }

        public void getLetterInput(string promptText)
        {
            Console.Write(promptText);
            string letter = Console.ReadLine();

        } 
    }
}

