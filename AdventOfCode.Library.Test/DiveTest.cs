using Microsoft.VisualStudio.TestTools.UnitTesting;
using static AdventOfCode.Library.Day2.Dive;

namespace AdventOfCode.Library.Day2.Test
{
    [TestClass]
    public class Day2DiveTest
    {
        [TestMethod]
        public void Part1_SampleData_CorrectAnswer()
        {
            var testInput = new string[] { "forward 5",
                                        "down 5",
                                        "forward 8",
                                        "up 3",
                                        "down 8",
                                        "forward 2" };
            var expectedAnswer = new Coords(15, 10);

            var part1Result = Dive.Part1(testInput);

            Assert.AreEqual(expectedAnswer, part1Result);
        }

        [TestMethod]
        public void Part1_RealData_GetsAndAnswer()
        {
            var part1Result = Dive.Part1();

            Assert.IsNotNull(part1Result);
            Assert.AreEqual(1250395, part1Result);
        }

        //[TestMethod]
        //public void Part2Test()
        //{
        //    var testInput = new int[] { 199, 200, 208, 210, 200, 207, 240, 269, 260, 263 };
        //    var expectedAnswer = 5;

        //    var part1Result = SonarSweep.Part2(testInput);

        //    Assert.AreEqual(expectedAnswer, part1Result);
        //}

        //[TestMethod]
        //public void Part2_RealData_GetsAndAnswer()
        //{
        //    var part1Result = SonarSweep.Part1();

        //    Assert.IsNotNull(part1Result);
        //    Assert.AreEqual(1633, part1Result);
        //}
    }
}