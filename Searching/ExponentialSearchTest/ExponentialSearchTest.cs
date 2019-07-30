using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExponentialSearchTest
{
    [TestClass]
    public class ExponentialSearchTest
    {
        [TestMethod]
        public void FindValue()
        {
            int[] values = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var valueToFind = 8;
            var indexToFind = 7;
            var indexFound = ExponentialSearch.ExponentialSearch.Search(values, valueToFind);

            Assert.AreEqual(indexFound, indexToFind);
        }

        [TestMethod]
        public void FindValueOnFirstElement()
        {
            int[] values = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var valueToFind = 1;
            var indexToFind = 0;
            var indexFound = ExponentialSearch.ExponentialSearch.Search(values, valueToFind);

            Assert.AreEqual(indexFound, indexToFind);
        }

        [TestMethod]
        public void FindValueOnLastElement()
        {
            int[] values = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var valueToFind = 9;
            var indexToFind = 8;
            var indexFound = ExponentialSearch.ExponentialSearch.Search(values, valueToFind);

            Assert.AreEqual(indexFound, indexToFind);
        }


        [TestMethod]
        public void FindValueOnBinaryLeftElement()
        {
            int[] values = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var valueToFind = 5;
            var indexToFind = 4;
            var indexFound = ExponentialSearch.ExponentialSearch.Search(values, valueToFind);

            Assert.AreEqual(indexFound, indexToFind);
        }

        [TestMethod]
        public void FindValueOnBinaryRightElement()
        {
            int[] values = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var valueToFind = 7;
            var indexToFind = 6;
            var indexFound = ExponentialSearch.ExponentialSearch.Search(values, valueToFind);

            Assert.AreEqual(indexFound, indexToFind);
        }

        [TestMethod]
        public void NotFindGreaterValue()
        {
            int[] values = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var valueToFind = 10;
            var indexToFind = -1;
            var indexFound = ExponentialSearch.ExponentialSearch.Search(values, valueToFind);

            Assert.AreEqual(indexFound, indexToFind);
        }

        [TestMethod]
        public void NotFindLesserValue()
        {
            int[] values = {2, 3, 4, 5, 6, 7, 8, 9 };
            var valueToFind = 1;
            var indexToFind = -1;
            var indexFound = ExponentialSearch.ExponentialSearch.Search(values, valueToFind);

            Assert.AreEqual(indexFound, indexToFind);
        }

        [TestMethod]
        public void NotFindMiddleValue()
        {
            int[] values = {1, 2, 3, 4, 5, 6, 7, 9 };
            var valueToFind = 8;
            var indexToFind = -1;
            var indexFound = ExponentialSearch.ExponentialSearch.Search(values, valueToFind);

            Assert.AreEqual(indexFound, indexToFind);
        }

        [TestMethod]
        public void NotFindEmptyArray()
        {
            int[] values = { };
            int indexToFind = -1;
            var indexFound = ExponentialSearch.ExponentialSearch.Search(values, indexToFind);

            Assert.AreEqual(indexFound, indexToFind);
        }


        [TestMethod]
        public void NotFindNullArray()
        {
            int[] values = null;
            int indexToFind = -1;
            var indexFound = ExponentialSearch.ExponentialSearch.Search(values, indexToFind);

            Assert.AreEqual(indexFound, indexToFind);
        }
    }
}
