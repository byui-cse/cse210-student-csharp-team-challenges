using System;

namespace _05_jumper
{
    public class UserService
    {
        public char GetLetterChoice(string prompt)
        {
            Console.Write(prompt);
            char guess = Convert.ToChar(Console.ReadLine());
            
            return guess;
        } 
    }
}

