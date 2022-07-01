using System;
using System.Collections.Generic;

namespace ConsoleMon
{
    public class Program
    {
        static void Main(string[] args)
        {
            ConsoleMon a = new ConsoleMon(250, "Lucario");

            ConsoleMon b = new ConsoleMon(300, "Pikachu");

            Skill blackbolt = new Skill("blackbolt", 30);
            Skill blacklightning = new Skill("blacklightning", 20);
            Skill blackstring = new Skill("blackstring", 13);
            Skill blackfire = new Skill("blackfire", 50);

            
            
            a.ListSkills.Add(blackbolt);
            a.ListSkills.Add(blacklightning);

            b.ListSkills.Add(blackstring);
            b.ListSkills.Add(blackfire);

            ConsoleMonArena arena = new ConsoleMonArena();
            arena.DoBattle(a, b);
        }
    }
}
