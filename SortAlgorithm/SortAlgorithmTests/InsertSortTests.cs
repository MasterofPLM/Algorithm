namespace SortAlgorithm.Tests
{
    using SortAlgorithm;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class InsertSortTests
    {
        private InsertSort insertSort;
        private ArrayGenerator arrayGenerator;
        private int[] testArray;
        private int Length = 10;

        [SetUp]
        public void Setup()
        {
            this.insertSort = new InsertSort();
            this.arrayGenerator = new ArrayGenerator();
        }

        [Test]
        public void BaseTest()
        {
            this.arrayGenerator.RandomGenerator(this.Length);
            this.testArray = this.arrayGenerator.output;
            this.insertSort.Sort(this.testArray);

            for (int i = 0; i < this.Length - 1; i++)
            {
                Assert.LessOrEqual(this.testArray[i], this.testArray[i + 1]);
            }
        }

        [Test]
        public void SpeedTest()
        {
            this.Length = 100000;
            this.arrayGenerator.RandomGenerator(this.Length);
            this.testArray = this.arrayGenerator.output;

            var startTime = DateTime.Now;
            this.insertSort.Sort(this.testArray);
            var endTime = DateTime.Now;

            var dur = endTime.Subtract(startTime);
            Console.WriteLine("Timespan: {0} ms.", dur.TotalMilliseconds);
        }

        [Test]
        public void WorstSpeedTest()
        {
            this.Length = 100000;
            this.arrayGenerator.DescendGenerator(this.Length);
            this.testArray = this.arrayGenerator.output;

            var startTime = DateTime.Now;
            this.insertSort.Sort(this.testArray);
            var endTime = DateTime.Now;

            var dur = endTime.Subtract(startTime);
            Console.WriteLine("Timespan: {0} ms.", dur.TotalMilliseconds);
        }

        [Test]
        public void BestSpeedTest()
        {
            this.Length = 100000;
            this.arrayGenerator.AscendGenerator(this.Length);
            this.testArray = this.arrayGenerator.output;

            var startTime = DateTime.Now;
            this.insertSort.Sort(this.testArray);
            var endTime = DateTime.Now;

            var dur = endTime.Subtract(startTime);
            Console.WriteLine("Timespan: {0} ms.", dur.TotalMilliseconds);
        }

        [Test]
        public void EmptyTest()
        {
            this.Length = 0;
            this.arrayGenerator.RandomGenerator(this.Length);
            this.testArray = this.arrayGenerator.output;
            this.insertSort.Sort(this.testArray);
            Assert.IsEmpty(this.testArray);

            this.Length = 1;
            this.arrayGenerator.RandomGenerator(this.Length);
            this.testArray = this.arrayGenerator.output;
            this.insertSort.Sort(this.testArray);
            Assert.AreEqual(this.testArray.Length, 1);
            Assert.AreEqual(this.testArray[0], this.arrayGenerator.output[0]);

            this.testArray = null;
            this.insertSort.Sort(this.testArray);
            Assert.IsNull(this.testArray);
        }
    }
}