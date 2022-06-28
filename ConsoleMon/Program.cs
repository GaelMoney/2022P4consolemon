using System;
using System.Collections.Generic;

namespace ConsoleMon
{
    public class Program
    {
        static void Main(string[] args)
        {
            ConsoleMon a = new ConsoleMon();

            ConsoleMon b = new ConsoleMon();

            Skill fire = new Skill();
            Skill water = new Skill();
            Skill lightning = new Skill();
            Skill shadow = new Skill();

            a.ListSkills.Add(fire);
            a.ListSkills.Add(water);

            b.ListSkills.Add(lightning);
            b.ListSkills.Add(shadow);

            ConsoleMonArena arena = new ConsoleMonArena();
            arena.DoBattle(a, b);
        }
    }
}
