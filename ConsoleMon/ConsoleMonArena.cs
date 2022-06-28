﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMon
{
     class ConsoleMonArena
    {
        public void DoBattle(ConsoleMon a, ConsoleMon b)
        {
            Random random = new Random();

            Skill skillA = a.ListSkills[random.Next(2)];
            Skill skillB = b.ListSkills[random.Next(2)];

            while (a.hp > 0 || b.hp > 0)
            {
                skillA.UseOn(b, a);
                skillB.UseOn(a, b);

                Console.WriteLine(a.hp);
                Console.WriteLine(b.hp);
            }
        }
    }
}
