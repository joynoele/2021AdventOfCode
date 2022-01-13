using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Library.Day2
{
    public static class Dive
    {
        public static string Title = "Day 2: Dive";

        public static string defaultInput = @"../../../../Input/Day2.txt";

        public static int Part1()
        {
            var defaultReadings = GetInput(defaultInput);
            var position = Part1(defaultReadings);
            return position.X * position.Y;
        }

        //public static int Part2()
        //{
        //    var defaultReadings = GetInput(defaultInput);
        //    return Part2(defaultReadings);
        //}

        /// <summary>
        /// Calculates the coordinants of your new position given the input
        /// </summary>
        /// <returns>Hoizontal and depth positions, respectively.</returns>
        public static Coords Part1(string[] rawCommands)
        {
            var locationChanges = TranslateInput(rawCommands);

            var startingPosition = new Coords(0, 0);
            foreach (var change in locationChanges)
            {
                startingPosition = startingPosition.Add(change);
            }

            return startingPosition;
        }

        ///// <summary>
        ///// Calculate how many times the reading was deeper than the last reading window of 3 readings.
        ///// First reading does not count.
        ///// </summary>
        ///// <returns>Number of times the sonar read a deeper depth than the prior window of reading.</returns>
        //public static int Part2(int[] sonarReadings)
        //{
        //    var increasedDepth = 0;
        //    int? priorWindowReading = null;
        //    int[] depthWindow = new int[3];
        //    var readingIndex = 0;
        //    foreach (int depthReading in sonarReadings)
        //    {
        //        string msg;

        //        depthWindow[readingIndex % 3] = depthReading;
        //        var windowReading = SumWindowDepths(depthWindow);

        //        if (priorWindowReading == null && readingIndex < depthWindow.Length - 1)
        //        {
        //            msg = "N/A - no previous sum";
        //        }
        //        else
        //        {
        //            if (windowReading > priorWindowReading)
        //            {
        //                increasedDepth++;
        //                msg = "INCREASED";
        //            }
        //            else if (windowReading == priorWindowReading)
        //            {
        //                msg = "no change";
        //            }
        //            else
        //            {
        //                msg = "decreased";
        //            }
        //            priorWindowReading = windowReading;
        //            msg = $"{priorWindowReading} ({msg})";
        //        }
        //        Console.WriteLine($"{readingIndex}: [{depthWindow[0]}, {depthWindow[1]}, {depthWindow[2]}] {msg}");
        //        readingIndex++;
        //    }

        //    return increasedDepth;
        //}

        public static string[] GetInput(string filePath)
        {
            var inputByLines = FileReader.ReadFileByLine(filePath).ToArray();
            return inputByLines;
        }

        public static Coords[] TranslateInput(string[] commands)
        {
            var coordChanges = new List<Coords>();

            foreach (var command in commands)
            {
                var cmdPieces = command.Split(' ');
                var direction = cmdPieces[0];
                var distance = int.Parse(cmdPieces[1]);

                switch (direction)
                {
                    case "forward":
                        // increases the horizontal position
                        coordChanges.Add(new Coords(distance, 0));
                        break;

                    case "down":
                        // increases the depth
                        coordChanges.Add(new Coords(0, distance));
                        break;

                    case "up":
                        // decreases the depth
                        coordChanges.Add(new Coords(0, -distance));
                        break;

                    default:
                        throw new NotSupportedException($"Command {cmdPieces[0]} not a valid keyword: forward|down|up");
                }
            }

            return coordChanges.ToArray();
        }

        public struct Coords
        {
            public Coords(int x, int y)
            {
                X = x;
                Y = y;
            }

            public int X { get; }
            public int Y { get; }

            public override string ToString() => $"({X}, {Y})";

            public Coords Add(Coords change)
            {
                return new Coords(X + change.X, Y + change.Y);
            }
        }
    }
}