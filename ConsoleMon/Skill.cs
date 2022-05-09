using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleMon
{
    class Skill
    {
        int damage = 10;
        int energyCost = 25;
        string name = "LightningBall";
        internal void UseOn(ConsoleMon target, ConsoleMon caster)
        {
            target.TakeDamage(damage);
            caster.DepleteEnergy(energyCost);
        }
    }
}
