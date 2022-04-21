using System;

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

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
