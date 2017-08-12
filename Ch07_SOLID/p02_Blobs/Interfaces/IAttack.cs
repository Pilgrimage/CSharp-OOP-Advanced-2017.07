namespace p02_Blobs.Interfaces
{
    using Entities;

    public interface IAttack
    {
        void Execute(Blob attacker, Blob target);
    }
}