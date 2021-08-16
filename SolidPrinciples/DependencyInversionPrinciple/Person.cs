using System;

namespace SolidPrinciples.DependencyInversionPrinciple
{
    // ---- The Dependency Inversion Principle ----
    // The Dependency Inversion Principle (DIP) states that high level modules should not depend on low level modules; 
    // both should depend on abstractions. Abstractions should not depend on details. Details should depend upon abstractions.
    public enum Relationship
    {
        Parent,
        Child,
        Sibling
    }

    public class Person
    {
        public string Name;
        public DateTime DateOfBirth;
    }
}