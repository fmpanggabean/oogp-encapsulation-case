using System;

namespace Ecapsulation
{
    internal class Heal : ISkill
    {
        public string Name => name;
        private string name;
        public int ManaCost => manaCost;
        private int manaCost;

        private int healAmount; 

        public Heal(string name, int manaCost, int healAmount)
        {
            this.name = name;
            this.manaCost = manaCost;
            this.healAmount = healAmount;
        }

        public void Execute(IEntity source, IEntity target)
        {
            if (source.Status.Mana.Current >= manaCost)
            {
                source.Status.Mana.Decrease(manaCost);
                target.Status.Health.Increase(healAmount);
                Console.WriteLine($"{source.Name} uses {Name} on {target.Name}, healing {healAmount} health.");
            }
        }
    }
}