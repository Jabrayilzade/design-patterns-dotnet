using System;

namespace FluentBuilder
{
    public class Person
    {
        public string Name;
        public string Position;

        public class Builder : PersonJobBuilder<Builder>
        {
        }

        public static Builder New => new Builder();

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Position)}: {Position}";
        }
    }

    public abstract class PersonBuilder
    {
        protected readonly Person Person = new Person();

        public Person Build()
        {
            return Person;
        }
    }

    public class PersonInfoBuilder<TSelf> : PersonBuilder
        where TSelf : PersonInfoBuilder<TSelf>
    {
        public TSelf Called(string name)
        {
            Person.Name = name;
            return (TSelf)this;
        }
    }

    public class PersonJobBuilder<TSelf> : PersonInfoBuilder<PersonJobBuilder<TSelf>>
        where TSelf : PersonJobBuilder<TSelf>
    {
        public TSelf WorksAsA(string position)
        {
            Person.Position = position;
            return (TSelf)this;
        }
    }

    internal static class Program
    { 
        private static void Main(string[] args)
        {
            var person = Person.New
                .Called("Nihad")
                .WorksAsA("Programmer")
                .Build();
            
            Console.WriteLine(person);
        }
    }
}