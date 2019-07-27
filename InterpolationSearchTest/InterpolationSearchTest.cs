using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterpolationSearchTest
{
    [TestClass]
    public class InterpolationSearchTest
    {
        [TestMethod]
        public void FindValue()
        {
            int valueToFind = 26;
            int indexToReturn = 4;
            int[] values = { 1, 3, 7, 19, 26, 32, 36, 45, 89 };

            Assert.AreEqual(InterpolationSearch.InterpolationSearch.Search(values, valueToFind), indexToReturn);
        }

        [TestMethod]
        public void FindValueOnLastNumber()
        {
            int valueToFind = 91;
            int[] values = { 1, 3, 7, 19, 26, 32, 36, 45, 89, 91 };
            int indexToReturn = 9;

            Assert.AreEqual(InterpolationSearch.InterpolationSearch.Search(values, valueToFind), indexToReturn);
        }


        [TestMethod]
        public void FindValueOnFirstNumber()
        {
            int valueToFind = 1;
            int[] values = { 1, 3, 7, 19, 26, 32, 36, 45, 89, 91 };
            int indexToReturn = 0;

            Assert.AreEqual(InterpolationSearch.InterpolationSearch.Search(values, valueToFind), indexToReturn);
        }

        [TestMethod]
        public void NotFindValue()
        {
            int valueToFind = 8;
            int indexToReturn = -1;
            int[] values = { 1, 3, 7, 19, 26, 32, 36, 45, 89 };

            Assert.AreEqual(InterpolationSearch.InterpolationSearch.Search(values, valueToFind), indexToReturn);
        }

        [TestMethod]
        public void NotFindGreaterValue()
        {
            int valueToFind = 90;
            int indexToReturn = -1;
            int[] values = { 1, 3, 7, 19, 26, 32, 36, 45, 89 };

            Assert.AreEqual(InterpolationSearch.InterpolationSearch.Search(values, valueToFind), indexToReturn);
        }

        [TestMethod]
        public void NotFindLesserValue()
        {
            int valueToFind = 2;
            int indexToReturn = -1;
            int[] values = { 3, 7, 19, 26, 32, 36, 45, 89 };

            Assert.AreEqual(InterpolationSearch.InterpolationSearch.Search(values, valueToFind), indexToReturn);
        }
        [TestMethod]
        public void FindValueOnOneNumberArray()
        {
            int valueToFind = 1;
            int indexToReturn = 0;
            int[] values = { 1 };

            Assert.AreEqual(InterpolationSearch.InterpolationSearch.Search(values, valueToFind), indexToReturn);
        }

        [TestMethod]
        public void FindValueOnTwoNumbersArray()
        {
            int valueToFind = 1;
            int indexToReturn = 1;
            int[] values = { 0, 1 };

            Assert.AreEqual(InterpolationSearch.InterpolationSearch.Search(values, valueToFind), indexToReturn);
        }

        [TestMethod]
        public void NotFindNullArray()
        {
            int valueToFind = 1;
            int[] values = null;
            int valueToReturn = -1;

            Assert.AreEqual(InterpolationSearch.InterpolationSearch.Search(values, valueToFind), valueToReturn);
        }

        [TestMethod]
        public void NotFindEmptyArray()
        {
            int valueToFind = 1;
            int[] values = { };
            int valueToReturn = -1;

            Assert.AreEqual(InterpolationSearch.InterpolationSearch.Search(values, valueToFind), valueToReturn);
        }
    }
}
