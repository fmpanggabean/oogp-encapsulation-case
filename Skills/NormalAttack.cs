using System;

namespace Ecapsulation
{
    internal class NormalAttack : ISkill
    {
        public string Name => name;
        private string name;

        public int ManaCost => ManaCost;
        private int manaCost;

        public NormalAttack(string name, int manaCost)
        {
            this.name = name;
            this.manaCost = manaCost;
        }

        public void Execute(IEntity source, IEntity target)
        {
            if (source.Status.Mana.Current >= manaCost)
            {
                source.Status.Mana.Decrease(manaCost);
                target.Status.Health.Decrease(source.Status.Attack);
                Console.WriteLine($"{source.Name} uses {Name} on {target.Name}, dealing {source.Status.Attack} damage.");
            }
        }
    }
}