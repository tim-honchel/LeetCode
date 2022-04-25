using System;
using Shared;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class Challenge
    {
        
        public int[] TwoSum(int[] nums, int target) // #1
        {
            int[] answer = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                var j = Array.IndexOf(nums, target - nums[i], i+1);
                if (j > -1)
                {
                    answer[0] = i;
                    answer[1] = j;
                    return answer;
                }
            }
            return answer;
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
           public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public Shared.Library.ListNode AddTwoNumbers(Shared.Library.ListNode l1, Shared.Library.ListNode l2) // #2
        {
            return new Shared.Library.ListNode();
        }

        public int LengthOfLongestSubstring(string s) // # 3
        {
            var currentString = "";
            var maxLength = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (currentString.Contains(s[i].ToString()))
                {
                    if (currentString.Length > maxLength)
                    {
                        maxLength = currentString.Length;
                    }

                    currentString = currentString.Split(s[i])[1] + s[i].ToString();
                }
                else if (i == s.Length - 1)
                {
                    currentString += s[i].ToString();
                    if (currentString.Length > maxLength)
                    {
                        maxLength = currentString.Length;
                    }
                }
                else
                {
                    currentString += s[i].ToString();
                }
            }
            return maxLength;
        }

        public static double FindMedianSortedArrays(int[] nums1, int[] nums2) // # 4
        {
            var combined = nums1.Concat(nums2).OrderBy(x => x).ToArray();
            foreach(int num in combined)
            {
                Console.WriteLine(num);
            }
            double medianIndex = Convert.ToDouble(combined.Count()) / 2;
            Console.WriteLine($"median index: {medianIndex}");
            double median;
            if (combined.Count() % 2 == 0)
            {
                Console.WriteLine("even");
                median = (combined[Convert.ToInt32(medianIndex - 1)] + combined[Convert.ToInt32(medianIndex)]) / 2.0;
            }
            else
            {
                Console.WriteLine("odd");
                median = combined[Convert.ToInt32(medianIndex-0.5)];
            }
            return median;
        }

        static void Main(string[] args)
        {
            var test1 = new int[] { 1, 4 };
            var test2 = new int[] { 3, 2 };
            var answer = FindMedianSortedArrays(test1, test2);
            Console.WriteLine(answer);
            Console.ReadKey();
        }
    }
}
