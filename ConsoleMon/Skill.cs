using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleMon
{
    public class Skill
    {
        Elements element;
        int damage = 10;
        int energyCost = 25;
        string name = "LightningBall";
        internal void UseOn(ConsoleMon target, ConsoleMon caster)
        {
            target.TakeDamage(damage);
            caster.DepleteEnergy(energyCost);
            
        }
        internal Skill(string aName, int someDamage)
        {
            name = aName;
            damage = someDamage;
            
            
        }
        internal Skill(Skill copyFrom) //je kan ook gebruik maken van reflection inplaats van "copyFrom"
        {
            this.damage = copyFrom.damage;
            this.energyCost = copyFrom.energyCost;
            this.name = copyFrom.name;

        }

    }
}
