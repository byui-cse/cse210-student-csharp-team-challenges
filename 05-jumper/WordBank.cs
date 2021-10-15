using System;
using System.Collections.Generic;

namespace _05_jumper
{
    public class WordBank
    {
        public List<string> _bank = new List<string>();
        
        public string GetWord()
        {
            _bank.Add("Funkytown");
            return _bank[0];
        }
    }
}
