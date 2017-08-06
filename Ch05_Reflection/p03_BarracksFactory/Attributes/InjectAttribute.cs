namespace p03_BarracksFactory.Attributes
{
    using System;

    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
    public class InjectAttribute : Attribute
    {
        
    }
}