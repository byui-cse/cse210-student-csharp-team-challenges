using System;
using System.Collections.Generic;

namespace _05_jumper
{
    public class WordBank
    {
        public Random rand = new Random();
        
        public string GetWord()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\dtytr\OneDrive\Documents\GitHub\cse210-student-csharp-team-challenges\05-jumper\WordList");
            return lines[rand.Next(0,lines.Length - 1)];
        }
    }
}
