using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleMon
{
    class ConsoleMon
    {
        int hp = 100;
        int energy = 120;
        int damage = 5;
        public int drain = 10;
        string name = "pikachu";

        internal void TakeDamage(int damage)
        {
            hp = hp - damage;

        }
        internal void DepleteEnergy(int drain)
        {
            energy = energy - drain;
        }
    }
}
