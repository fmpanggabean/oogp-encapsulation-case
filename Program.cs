namespace Ecapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create player
            RangedValue _health = new RangedValue(name: "Health", min: 0, max: 30, current: 30);
            RangedValue _mana = new RangedValue(name: "Mana", min: 0, max: 10, current: 10);
            Status _playerStatus = new Status(health: _health, mana: _mana, attack: 5);

            Player adam = new Player(name: "Adam", status: _playerStatus);

            // display player info
            adam.DisplayInfo();

            // attempt to use heal skill
            adam.UseSkill(name: "Heal", adam);

            // create heal skill
            ISkill heal = new Heal(name: "Heal", manaCost: 3, healAmount: 10);
            adam.LearnSkill(heal);

            // attempt to use skill
            adam.UseSkill(name: "Heal", adam);

            // display player info
            adam.DisplayInfo();

            // attempt to use attack skill
            adam.UseSkill(name: "Normal Attack", adam);

            // create attack skill
            ISkill normalAttack = new NormalAttack(name: "Normal Attack", manaCost: 0);
            adam.LearnSkill(normalAttack);
            adam.UseSkill(name: "Normal Attack", adam);

            // display player info
            adam.DisplayInfo();

            // case 1: create enemy Willow
            RangedValue _willowHealth = new RangedValue(name: "Health", min: 0, max: 20, current: 20);
            RangedValue _willowMana = new RangedValue(name: "Mana", min: 0, max: 00, current: 00);
            Status _willowStatus = new Status(health: _willowHealth, mana: _willowMana, attack: 2);

            Enemy willow = new Enemy(name: "Willow", status: _willowStatus);

            // case 2: battle against Willow
            willow.LearnSkill(normalAttack);

            adam.UseSkill(name: "Normal Attack", willow);
            willow.UseSkill(name: "Normal Attack", adam);

            // case 3: display enemy info
            willow.DisplayInfo();

            // case 4: create Willow's Skill (bebas)
            ISkill willowSpecial = new ...
            willow.LearnSkill(willowSpecial);

            // case 5: battle against Willow again
            willow.UseSkill(name: "Willow Special", adam);
            adam.UseSkill(name: "Heal", adam);

            // display player info
            adam.DisplayInfo();
        }
    }
}
