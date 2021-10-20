//communicating with terminal
using System;

namespace _06_mastermind
{
    class UserService
    {
        public string GetStringInput(string promptText)
        {
            Console.Write(promptText);
            string userInput = Console.ReadLine();

            return userInput;
        }
    }
}