using NUnit.Framework;
using LeetCode;

namespace LeetCodeTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(new int[] { 2, 7, 11, 15 }, 9, new int[] {0, 1})]

        public void TwoSumTest(int[] input1, int input2, int[] expected)
        {
            var test = new Challenge();
            var actual = test.TwoSum(input1,input2);
            Assert.AreEqual(expected, actual);
                
        }
    }
}