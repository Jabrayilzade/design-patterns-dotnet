using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using SolidPrinciples.DependencyInversionPrinciple;

namespace SolidPrinciples.InterfaceSegregationPrinciple
{
    public class Research
    {
        public Research(IRelationshipBrowser browser)
        {
            foreach (var person in browser.FindAllChildrenOf("John"))
            {
                Console.WriteLine($"John has a child called {person.Name}");
            }
        }
    }
}