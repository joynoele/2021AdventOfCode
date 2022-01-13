using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Library.Day1
{
    public static class SonarSweep
    {
        public static string Title = "Day 1: Sonar Sweep";

        public static string defaultInput = @"../Input/Day1.txt"; //@"C:\Projects\Repos\ElsaVezino\2021AdventOfCode\Day01\SonarSweep\SonarSweep\TestInput.txt";

        public static int Part1()
        {
            var defaultReadings = GetInput(defaultInput);
            return Part1(defaultReadings);
        }

        /// <summary>
        /// Calculate how many times the reading was deeper than the last reading.
        /// First reading does not count.
        /// </summary>
        /// <returns>Number of times the sonar read a deeper depth than the prior reading.</returns>
        public static int Part1(int[] sonarReadings)
        {
            var increasedDepth = 0;
            int? priorDepth = null;

            foreach (int depthReading in sonarReadings)
            {
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
                Console.WriteLine($"{depthReading} ({msg})");
                priorDepth = depthReading;
            }

            return increasedDepth;
        }

        /// <summary>
        /// Calculate how many times the reading was deeper than the last reading window of 3 readings.
        /// First reading does not count.
        /// </summary>
        /// <returns>Number of times the sonar read a deeper depth than the prior window of reading.</returns>
        public static int Part2()
        {
            var increasedDepth = 0;
            int? priorWindowReading = null;
            int[] depthWindow = new int[3];
            var readingIndex = 0;
            foreach (string reading in System.IO.File.ReadLines(defaultInput))
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

        public static int[] GetInput(string filePath)
        {
            var inputByLines = FileReader.ReadFileByLine(filePath);
            var inputAsNumeric = inputByLines.Select(x => Convert.ToInt32(x)).ToArray();
            return inputAsNumeric;
        }
    }
}