namespace SearchAlgorithm.Tests
{
    using SortAlgorithm;
    using SearchAlgorithm;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class BinarySearchTests
    {
        private BinarySearch binarySearch;
        private ArrayGenerator arrayGenerator;
        private Random rd = new Random();
        private int[] testArray;
        private int Length = 10;

        [SetUp]
        public void Setup()
        {
            this.binarySearch = new BinarySearch();
            this.arrayGenerator = new ArrayGenerator();
            this.arrayGenerator.AscendGenerator(this.Length);
            this.testArray = this.arrayGenerator.output;
        }

        [Test]
        public void BaseTest()
        {
            int index = this.binarySearch.Search(this.testArray, this.testArray[this.Length - 1]);

            Assert.AreEqual(index, this.Length - 1);
        }

        [Test]
        public void SpeedTest()
        {
            this.Length = 100000000;
            this.arrayGenerator.AscendGenerator(this.Length);
            this.testArray = this.arrayGenerator.output;
            int index = rd.Next(0, this.Length - 1);

            var startTime = DateTime.Now;
            this.binarySearch.Search(this.testArray, this.testArray[index]);
            var endTime = DateTime.Now;

            var dur = endTime.Subtract(startTime);
            Console.WriteLine("Timespan: {0} ms.", dur.TotalMilliseconds);
        }

        [Test]
        public void WorstSpeedTest()
        {
            this.Length = 100000000;
            this.arrayGenerator.AscendGenerator(this.Length);
            this.testArray = this.arrayGenerator.output;

            var startTime = DateTime.Now;
            this.binarySearch.Search(this.testArray, this.testArray[this.Length - 1]);
            var endTime = DateTime.Now;

            var dur = endTime.Subtract(startTime);
            Console.WriteLine("Timespan: {0} ms.", dur.TotalMilliseconds);
        }

        [Test]
        public void BestSpeedTest()
        {
            this.Length = 100000000;
            this.arrayGenerator.AscendGenerator(this.Length);
            this.testArray = this.arrayGenerator.output;

            var startTime = DateTime.Now;
            this.binarySearch.Search(this.testArray, this.testArray[this.Length/2]);
            var endTime = DateTime.Now;

            var dur = endTime.Subtract(startTime);
            Console.WriteLine("Timespan: {0} ms.", dur.TotalMilliseconds);
        }

        [Test]
        public void EmptyTest()
        {
            this.Length = 0;
            this.arrayGenerator.AscendGenerator(this.Length);
            this.testArray = this.arrayGenerator.output;
            int index = this.binarySearch.Search(this.testArray, this.Length + 1);
            Assert.AreEqual(index, -1);

            this.Length = 1;
            this.arrayGenerator.AscendGenerator(this.Length);
            this.testArray = this.arrayGenerator.output;
            index = this.binarySearch.Search(this.testArray, this.Length + 1);
            Assert.AreEqual(index, -1);

            this.testArray = null;
            index = this.binarySearch.Search(this.testArray, this.Length + 1);
            Assert.AreEqual(index, -1);
        }
    }
}