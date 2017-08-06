namespace p03_BarracksFactory.Core.Commands
{
    using Attributes;
    using Contracts;

    public class RetireCommand : Command
    {
        [Inject]
        private IRepository repository;

        public RetireCommand(string[] data) : base(data)
        {
        }

        public override string Execute()
        {
            this.repository.RemoveUnit(Data[1]);
            return $"{this.Data[1]} retired!";
        }
    }
}