using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinearSearch;

namespace LinearSearchAlgorithmUnitTest
{
    [TestClass]
    public class LinearSerchAlgorithmUnitTest
    {
        [TestMethod]
        public void FindAValueOnArray()
        {
            var inputArray = new int[]{10, 20, 80, 30, 60, 50, 110, 100, 130, 170 };
            var valueToFind = 110;
            var valueIndex = 6;

            var foundIndexValue=LinearSearch.LinearSearch.Search(inputArray, valueToFind);
            Assert.AreEqual(foundIndexValue, valueIndex);
        }

        [TestMethod]
        public void NotFindAValueOnArray()
        {
            var inputArray = new int[] { 10, 20, 80, 30, 60, 50, 110, 100, 130, 170 };
            var valueToFind = 26;
            var valueNotFoundIndex = -1;
            
            var foundIndexValue = LinearSearch.LinearSearch.Search(inputArray, valueToFind);
            Assert.AreEqual(foundIndexValue, valueNotFoundIndex);
        }

        [TestMethod]
        public void NullValueOnArray()
        {
            int[] inputArray = null ;
            var valueToFind = 26;
            var valueIndex = -1;

            var foundIndexValue = LinearSearch.LinearSearch.Search(inputArray, valueToFind);
            Assert.AreEqual(foundIndexValue,valueIndex);
        }

        [TestMethod]
        public void EmptyValueOnArray()
        {
            int[] inputArray = null;
            var valueToFind = 26;
            var valueIndex = -1;
            var foundIndexValue = LinearSearch.LinearSearch.Search(inputArray, valueToFind);
            Assert.AreEqual(foundIndexValue,valueIndex);
        }
    }
}
