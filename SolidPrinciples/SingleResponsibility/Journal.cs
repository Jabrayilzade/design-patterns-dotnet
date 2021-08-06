using System;
using System.Collections.Generic;

// ------ Single Responsibility Principle ------
// The single-responsibility principle (SRP) is a computer-programming principle that states that every module,
// class or function in a computer program should have responsibility over a single part of that program's
// functionality, and it should encapsulate that part.

namespace SolidPrinciples.SingleResponsibility
{
    public class Journal // Single Responsibility Principle
    {
        private readonly List<string> entries = new List<string>();
        private static int count = 0;

        public int AddEntry(string text)
        {
            entries.Add($"{++count}: {text}");
            return count; // momento
        }

        public void RemoveEntry(int index)
        {
            entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }
    }
}