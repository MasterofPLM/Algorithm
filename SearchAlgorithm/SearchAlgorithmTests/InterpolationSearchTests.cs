namespace SearchAlgorithm.Tests
{
    using SortAlgorithm;
    using SearchAlgorithm;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class InterpolationSearchTests
    {
        private InterpolationSearch interpolationSearch;
        private MergeSort mergeSort = new MergeSort();
        private ArrayGenerator arrayGenerator;
        private Random rd = new Random();
        private int[] testArray;
        private int Length = 10;

        [SetUp]
        public void Setup()
        {
            this.interpolationSearch = new InterpolationSearch();
            this.arrayGenerator = new ArrayGenerator();
            this.arrayGenerator.AscendGenerator(this.Length);
            this.testArray = this.arrayGenerator.output;
        }

        [Test]
        public void BaseTest()
        {
            int index = this.interpolationSearch.Search(this.testArray, this.testArray[this.Length - 1]);

            Assert.AreEqual(index, this.Length - 1);
        }

        [Test]
        public void SpeedTest()
        {
            this.Length = 1000000;
            this.arrayGenerator.AscendGenerator(this.Length);
            this.testArray = this.arrayGenerator.output;
            int index = rd.Next(0, this.Length - 1);

            var startTime = DateTime.Now;
            for (int i = 0; i < 10000; i++)
            {
                this.interpolationSearch.Search(this.testArray, this.testArray[index]);
            }
            var endTime = DateTime.Now;

            var dur = endTime.Subtract(startTime);
            Console.WriteLine("Timespan: {0} ms.", dur.TotalMilliseconds);
        }

        [Test]
        public void WorstSpeedTest()
        {
            this.Length = 1000000;
            this.arrayGenerator.RandomGenerator(this.Length);
            this.testArray = this.arrayGenerator.output;
            this.mergeSort.Sort(this.testArray);
            int index = rd.Next(0, this.Length - 1);

            var startTime = DateTime.Now;
            for (int i = 0; i < 10000; i++)
            {
                this.interpolationSearch.Search(this.testArray, this.testArray[index]);
            }
            var endTime = DateTime.Now;

            var dur = endTime.Subtract(startTime);
            Console.WriteLine("Timespan: {0} ms.", dur.TotalMilliseconds);
        }

        [Test]
        public void BestSpeedTest()
        {
            this.Length = 1000000;
            this.arrayGenerator.AscendGenerator(this.Length);
            this.testArray = this.arrayGenerator.output;

            var startTime = DateTime.Now;
            for (int i = 0; i < 10000; i++)
            {
                this.interpolationSearch.Search(this.testArray, this.testArray[this.Length - 1]);
            }  
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
            int index = this.interpolationSearch.Search(this.testArray, this.Length + 1);
            Assert.AreEqual(index, -1);

            this.Length = 1;
            this.arrayGenerator.AscendGenerator(this.Length);
            this.testArray = this.arrayGenerator.output;
            index = this.interpolationSearch.Search(this.testArray, this.Length + 1);
            Assert.AreEqual(index, -1);

            this.testArray = null;
            index = this.interpolationSearch.Search(this.testArray, this.Length + 1);
            Assert.AreEqual(index, -1);
        }
    }
}