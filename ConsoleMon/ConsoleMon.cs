using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleMon
{
     class ConsoleMon
    {
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
