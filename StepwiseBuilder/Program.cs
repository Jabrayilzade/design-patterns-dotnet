using System;

namespace StepwiseBuilder
{
    public enum CarType
    {
        Sedan,
        Crossover
    }

    public class Car
    {
        public CarType Type;
        public int WheelSize;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}