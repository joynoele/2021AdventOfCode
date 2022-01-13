using AdventOfCode.Library.Day1;
using System;

namespace AdventOfCode
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Day2();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        private static void Day1()
        {
            Console.WriteLine(SonarSweep.Title);

            var increasedDepth1 = SonarSweep.Part1();
            Console.WriteLine($"Went deeper {increasedDepth1} time/s");

            var increasedDepth2 = SonarSweep.Part2();
            Console.WriteLine($"Went deeper {increasedDepth2} time/s");
        }

        private static void Day2()
        {
            Console.WriteLine(SonarSweep.Title);

            var increasedDepth1 = SonarSweep.Part1();
            Console.WriteLine($"Went deeper {increasedDepth1} time/s");

            var increasedDepth2 = SonarSweep.Part2();
            Console.WriteLine($"Went deeper {increasedDepth2} time/s");
        }
    }
}