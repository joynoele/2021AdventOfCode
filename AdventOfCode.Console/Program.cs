using AdventOfCode.Library.Day1;
using System;

namespace AdventOfCode
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(SonarSweep.Title);

            var increasedDepth = SonarSweep.Part2();

            Console.WriteLine($"Went deeper {increasedDepth} time/s");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}