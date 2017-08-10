namespace lab04_RechargeV2
{
    using System;

    public class Employee : Worker, ISleeper
    {
        public Employee(string id) : base (id)
        {
        }

        public override void Sleep()
        {
            // sleep...
        }

        public override void Recharge()
        {
            throw new InvalidOperationException("Employees cannot recharge");
        }
    }
}