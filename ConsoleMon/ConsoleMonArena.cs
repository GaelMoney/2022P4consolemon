using System;
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

            Skill skillA = a.ListSkills[random.Next(a.ListSkills.Count)];
            Skill skillB = b.ListSkills[random.Next(b.ListSkills.Count)];

            while (a.hp > 0 && b.hp > 0)
                    
            {
                skillA.UseOn(b, a);
                if (b.hp <= 0)
                {
                    break;
                }
                skillB.UseOn(a, b);

                Console.WriteLine("ä: "+a.hp);
                Console.WriteLine("b: "+b.hp);
            }
        }
    }
}
