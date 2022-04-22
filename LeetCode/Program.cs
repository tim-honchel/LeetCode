using System;
using Shared;
using System.Collections.Generic;

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

        public int LengthOfLongestSubstring(string s)
        {
            var currentString = "";
            var maxLength = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (currentString.Contains(s[i].ToString()) || s[i] == s.Length)
                {
                    if (currentString.Length > maxLength)
                    {
                        maxLength = currentString.Length;
                    }
                    currentString = currentString.Split(s[i])[1] + s[i].ToString();
                }
                else
                {
                    currentString += s[i].ToString();
                }
            }
            return maxLength;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
