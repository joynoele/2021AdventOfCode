using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode.Library.Day1.Test
{
    [TestClass]
    public class Day1SonarSweepTest
    {
        [TestMethod]
        public void Part1_SampleData_CorrectAnswer()
        {
            var testInput = new int[] { 199, 200, 208, 210, 200, 207, 240, 269, 260, 263 };
            var expectedAnswer = 7;

            var part1Result = SonarSweep.Part1(testInput);

            Assert.AreEqual(expectedAnswer, part1Result);
        }

        [TestMethod]
        public void Part1_RealData_GetsAndAnswer()
        {
            var part1Result = SonarSweep.Part1();

            Assert.IsNotNull(part1Result);
            Assert.AreEqual(1602, part1Result);
        }

        [TestMethod]
        public void Part2Test()
        {
            var testInput = new int[] { 199, 200, 208, 210, 200, 207, 240, 269, 260, 263 };
            var expectedAnswer = 5;

            var part1Result = SonarSweep.Part2(testInput);

            Assert.AreEqual(expectedAnswer, part1Result);
        }

        [TestMethod]
        public void Part2_RealData_GetsAndAnswer()
        {
            var part1Result = SonarSweep.Part1();

            Assert.IsNotNull(part1Result);
            Assert.AreEqual(1633, part1Result);
        }
    }
}