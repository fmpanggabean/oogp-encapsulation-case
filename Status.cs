using System;

namespace Ecapsulation
{
    internal class Status
    {
        public RangedValue Health => health;
        private RangedValue health;
        public RangedValue Mana => mana;
        private RangedValue mana;
        public int Attack => attack;
        private int attack;

        public Status(RangedValue health, RangedValue mana, int attack)
        {
            this.health = health;
            this.mana = mana;
            this.attack = attack;
        }

        internal void Display()
        {
            Console.WriteLine($"Health: {health.Current} / {health.Max}");
            Console.WriteLine($"Mana: {mana.Current} / {mana.Max}");
            Console.WriteLine($"Attack: {attack}");
        }
    }
}