using System;

namespace SonarSweep
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var input = @"C:\Projects\Repos\ElsaVezino\2021AdventOfCode\Day01\SonarSweep\SonarSweep\Input.txt";
            foreach (string reading in System.IO.File.ReadLines(input))
            {
                Console.WriteLine($"{reading}");
            }
        }
    }
}