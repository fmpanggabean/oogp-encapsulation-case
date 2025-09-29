using System;
using System.Collections.Generic;

namespace Ecapsulation
{
    internal class Player : ITargetable, IEntity
    {
        public string Name => name;
        private string name;
        public Status Status => status;
        private Status status;
        private List<ISkill> skills = new List<ISkill>();

        public Player(string name, Status status)
        {
            this.name = name;
            this.status = status;
        }

        public void DisplayInfo()
        {
            Console.WriteLine();
            Console.WriteLine("===== Player Info =====");
            Console.WriteLine($"Player Name: {name}");
            status.Display();
            Console.WriteLine("=======================");
            Console.WriteLine();
        }

        internal void LearnSkill(ISkill skill)
        {
            if (skills.Contains(skill))
            {
                Console.WriteLine($"{name} already knows {skill.Name}.");
                return;
            }
            else
            {
                skills.Add(skill);
                Console.WriteLine($"{name} learned {skill.Name} skill.");
            }
        }
        internal void UseSkill(string name, IEntity target)
        {
            if (skills.Count == 0)
            {
                Console.WriteLine($"{this.name} has no skills to use.");
                return;
            }

            ISkill skillToUse = skills.Find(s => s.Name == name);

            if (skillToUse == null)
            {
                Console.WriteLine($"{this.name} does not know the skill {name}.");
                return;
            }
            else
            {
                skillToUse.Execute(source: this, target: target);
            }
        }
    }
}