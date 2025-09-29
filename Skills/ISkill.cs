namespace Ecapsulation
{
    internal interface ISkill
    {
        string Name { get; }
        int ManaCost { get; }

        void Execute(IEntity source, IEntity target);
    }
}