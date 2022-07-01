using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleMon
{
    enum Elements
    {
        Fire = 1,
        Water = 2,
        Wind = 3,
        Earth = 4,

    }
    class ConsoleMon
    {
        Elements weakness;
        public int hp = 100;
        int energy = 120;
        int damage = 5;
        public int drain = 10;
        string name = "pikachu";
        public List<Skill> ListSkills = new List<Skill>();

        internal void TakeDamage(int damage)
        {
            hp = hp - damage;

        }
        internal void DepleteEnergy(int drain)
        {
            energy = energy - drain;
        }
        internal ConsoleMon()
        {

        }

        internal ConsoleMon(int isHealth, string aName)
        {
            hp = isHealth;
            name = aName;
        }
        internal ConsoleMon(ConsoleMon copyFrom)
        {
            this.hp = copyFrom.hp;
            this.energy = copyFrom.energy;
            this.damage = copyFrom.damage;
            this.drain = copyFrom.drain;
            this.name = copyFrom.name;

        }
    }
}
