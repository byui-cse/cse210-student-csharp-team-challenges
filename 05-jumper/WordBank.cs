using System;
using System.Collections.Generic;

namespace _05_jumper
{
    public class WordBank
    {
        public Random rand = new Random();
        public List<string> lines = new List<string>();
        
        public string GetWord()
        {
            lines.Add("apple");
            lines.Add("bannana");
            lines.Add("charlie");
            lines.Add("delta");
            lines.Add("echo");
            lines.Add("foxtrot");
            lines.Add("gumbo");
            lines.Add("hotel");
            lines.Add("indigo");
            lines.Add("jamaica");
            lines.Add("kleptomaniac");
            lines.Add("lymphoid");
            lines.Add("monster");
            lines.Add("nashville");
            lines.Add("opulent");
            lines.Add("person");
            lines.Add("quail");
            lines.Add("rainbow");
            lines.Add("slytherin");
            lines.Add("trite");
            lines.Add("undulating");
            lines.Add("vehement");
            lines.Add("wondering");
            lines.Add("xylophone");
            lines.Add("yale");
            lines.Add("zirconium");
            return lines[rand.Next(0,lines.Count - 1)];
        }
    }
}
