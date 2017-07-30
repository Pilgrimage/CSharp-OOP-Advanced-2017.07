﻿namespace p07_EqualityLogic
{
    using System;
    public class Person : IComparable<Person>
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; }
        public int Age { get; }

        public int CompareTo(Person other)
        {
            int result = this.Name.CompareTo(other.Name);
            if (result==0)
            {
                result = this.Age.CompareTo(other.Age);
            }
            return result;
        }

        public override bool Equals(object obj)
        {
            return (this.GetHashCode() == obj.GetHashCode());
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode() * 29 + this.Age.GetHashCode();
        }
    }
}