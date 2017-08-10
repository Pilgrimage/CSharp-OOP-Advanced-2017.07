namespace p02_Blobs.Entities.Attacks
{
    using p02_Blobs.Interfaces;

    public abstract class Attack : IAttack
    {
        public abstract void Execute(Blob attacker, Blob target);
    }
}