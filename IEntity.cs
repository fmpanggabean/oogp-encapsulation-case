namespace Ecapsulation
{
    internal interface IEntity
    {
        string Name { get; }
        Status Status { get; }
        void DisplayInfo();
    }
}