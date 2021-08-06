using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using SolidPrinciples.SingleResponsibility;


namespace SolidPrinciples
{
    public class Persistence
    {
        public void SaveToFile(Journal j, string fileName, bool overwrite = false)
        {
            if (overwrite || !File.Exists(fileName))
                File.WriteAllText(fileName, j.ToString());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var j = new Journal();
            j.AddEntry("I cried today");
            j.AddEntry("I ate a bug");
            Console.WriteLine(j);

            var p = new Persistence();
            var fileName = @"/Desktop";
            p.SaveToFile(j, fileName, true);
            Process.Start(fileName);
        }
    }
}