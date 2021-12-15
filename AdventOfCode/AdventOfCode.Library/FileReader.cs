using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Library
{
    internal static class FileReader
    {
        /// <summary>
        /// Each line in the file is an element in the array.
        /// Preserves order.
        /// </summary>
        internal static IEnumerable<string> ReadFileByLine(string filePath)
        {
            // TODO: check that file path is valid and file exists
            var lines = System.IO.File.ReadLines(filePath);

            return lines;
        }
    }
}