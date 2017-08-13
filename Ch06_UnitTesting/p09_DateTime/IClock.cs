namespace p09_DateTime
{
    using System;

    public interface IClock
    {
        DateTime Now { get; set; }
    }
}