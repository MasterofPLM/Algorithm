namespace SortAlgorithm.Tests
{
    using SortAlgorithm;
    using NUnit.Framework;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using SortAlgorithmTests;
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
            this.arrayGenerator.Generate(this.Length);
            this.testArray = this.arrayGenerator.output;
            Console.WriteLine(this.testArray[this.Length - 1]);
        }

        [Test]
        public void BaseTest()
        {
            this.arrayGenerator.Generate(this.Length);
            this.testArray = this.arrayGenerator.output;
            this.testArray = this.insertSort.Sort(this.testArray);
            for(int i = 0; i < this.Length - 1; i++)
            {
                Assert.LessOrEqual(this.testArray[i], this.testArray[i+1]);
            }
        }

        [Test]
        public void SpeedTest()
        {
            this.Length = 10000;
            this.arrayGenerator.Generate(this.Length);
            this.testArray = this.arrayGenerator.output;

            var startTime = DateTime.Now;
            this.testArray = this.insertSort.Sort(this.testArray);
            var endTime = DateTime.Now;

            var dur = endTime - startTime;
            Console.WriteLine(dur.ToString("fff"));
        }

        [Test]
        public void EmptyTest()
        {
            this.Length = 0;
            this.arrayGenerator.Generate(this.Length);
            this.testArray = this.arrayGenerator.output;
            this.testArray = this.insertSort.Sort(this.testArray);
            Assert.IsEmpty(this.testArray);

            this.Length = 1;
            this.arrayGenerator.Generate(this.Length);
            this.testArray = this.arrayGenerator.output;
            this.testArray = this.insertSort.Sort(this.testArray);
            Assert.AreEqual(this.testArray.Length, 1);
            Assert.AreEqual(this.testArray[0], this.arrayGenerator.output[0]);

            this.testArray = null;
            this.testArray = this.insertSort.Sort(this.testArray);
            Assert.IsNull(this.testArray);
        }
    }
}