using NUnit.Framework;
using LeetCode;
using Shared;

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

        [TestCase]
        public void AddTwoNumbersTest(Shared.Library.ListNode input1, Shared.Library.ListNode input2, Shared.Library.ListNode expected)
        {
            var test = new Challenge();
            var actual = test.AddTwoNumbers(input1, input2);
            Assert.AreEqual(expected, actual);
        }

        //[TestCase(new string[] { "flower", "flow", "flight" },"fl")]
        //public void LongestCommonPrefixTest(string[] input, string expected)
        //{
        //    var test = new Challenge();
        //    var actual = test.LongestCommonPrefix(input);
        //    Assert.AreEqual(expected, actual);
        //}

    }
}