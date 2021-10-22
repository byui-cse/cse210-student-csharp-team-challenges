//communicating with terminal
using System;

namespace _06_mastermind
{
    class UserService
    {
        static void DisplayText(string text)
        {
            Console.WriteLine(text);
        }

        public string GetInput(string prompt)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            return input;
        }
    }
}