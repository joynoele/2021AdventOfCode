using System;

namespace SonarSweep
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            Console.WriteLine("Day 1: Sonar Sweep");

            var increasedDepth = Part2();

            Console.WriteLine($"Went deeper {increasedDepth} time");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        private static int Part1()
        {
            var input = @"C:\Projects\Repos\ElsaVezino\2021AdventOfCode\Day01\SonarSweep\SonarSweep\TestInput.txt";

            var increasedDepth = 0;
            int? priorDepth = null;
            foreach (string reading in System.IO.File.ReadLines(input))
            {
                var depthReading = Convert.ToInt32(reading);

                string msg;

                if (priorDepth == null)
                {
                    msg = "N/A - no previous measurement";
                }
                else if (depthReading > priorDepth)
                {
                    increasedDepth++;
                    msg = "INCREASED";
                }
                else
                {
                    msg = "decreased";
                }
                Console.WriteLine($"{reading} ({msg})");
                priorDepth = depthReading;
            }

            return increasedDepth;
        }

        private static int Part2()
        {
            var input = @"C:\Projects\Repos\ElsaVezino\2021AdventOfCode\Day01\SonarSweep\SonarSweep\Input.txt";

            var increasedDepth = 0;
            int? priorWindowReading = null;
            int[] depthWindow = new int[3];
            var readingIndex = 0;
            foreach (string reading in System.IO.File.ReadLines(input))
            {
                var depthReading = Convert.ToInt32(reading);
                depthWindow[readingIndex % 3] = depthReading;

                var windowReading = SumWindowDepths(depthWindow);

                string msg;
                if (priorWindowReading == null && readingIndex < depthWindow.Length - 1)
                {
                    msg = "N/A - no previous sum";
                }
                else
                {
                    if (windowReading > priorWindowReading)
                    {
                        increasedDepth++;
                        msg = "INCREASED";
                    }
                    else if (windowReading == priorWindowReading)
                    {
                        msg = "no change";
                    }
                    else
                    {
                        msg = "decreased";
                    }
                    priorWindowReading = windowReading;
                    msg = $"{priorWindowReading} ({msg})";
                }
                Console.WriteLine($"{readingIndex}: [{depthWindow[0]}, {depthWindow[1]}, {depthWindow[2]}] {msg}");
                readingIndex++;
            }

            return increasedDepth;
        }

        private static int SumWindowDepths(int[] window)
        {
            var runningSum = 0;
            foreach (var e in window)
            {
                runningSum += e;
            }
            return runningSum;
        }
    }
}