namespace p02_Blobs.Interfaces
{
    using Entities;

    public interface IBehavior
    {
        bool IsTriggered { get; }

        void Trigger(Blob source);

        void ApplyPostTriggerEffect(Blob source);
    }
}