using System;
using System.Collections;
using System.Collections.Generic;

// ---- Open-Closed Principle
// In object-oriented programming, the open–closed principle states "software entities (classes, modules, functions, etc.)
// should be open for extension, but closed for modification"; that is, such an entity can allow its behaviour to be
// extended without modifying its source code.

namespace SolidPrinciples.OpenClosedPrinciple
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T t);
    }

    public enum Color
    {
        Red,
        Green,
        Blue
    }

    public enum Size
    {
        Small,
        Medium,
        Large,
        Yuge
    }

    public class Product
    {
        public string Name;
        public Color Color;
        public Size Size;

        public Product(string name, Color color, Size size)
        {
            Name = name ?? throw new ArgumentNullException(paramName: nameof(name));
            Color = color;
            Size = size;
        }
    }
}