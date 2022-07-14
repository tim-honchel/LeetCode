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

        public static string LongestPalindrome(string s)
        {
            for (int length = s.Length; length > 0; length--)
            {
                for (int start = 0; start < s.Length; start++)
                {
                    if (start + length > s.Length)
                    {
                        break;
                    }
                    var substring = s.Substring(start, length);
                    char[] chars = substring.ToCharArray();
                    Array.Reverse(chars);
                    var reverse = new string(chars);
                    Console.WriteLine(substring);
                    if (substring == reverse)
                    {
                        return substring;
                    }
                }
            }
            return "";
        }

        //public static bool isPalindrome(int x)
        //{
        //    var forward = Convert.ToString(x);
        //    var chars = forward.ToCharArray();
        //    Array.Reverse(chars);
        //    var reverse = new string(chars);
        //    Console.WriteLine(forward);
        //    Console.WriteLine(reverse);
        //    return (forward.Equals(reverse) ? true : false);
 
        //}

        public static bool isPalindrome(int x)
        {
            var number = Convert.ToString(x);
            var digits = number.Length;
            for (int i = 0; i < digits / 2; i++)
            {
                //Console.WriteLine($"{forward[i]}={forward[digits - i - 1]}");
                if (number[i] != number[digits - i -1])
                {
                    return false;
                }
            }
            return true;

        }
        public static string IntToRoman(int num)
        {
                var roman = "";
                Sub(1000, "M");
                Sub(900, "CM");
                Sub(500, "D");
                Sub(400, "CD");
                Sub(100, "C");
                Sub(90, "XC");
                Sub(50, "L");
                Sub(40, "XL");
                Sub(10, "X");
                Sub(9, "IX");
                Sub(5, "V");
                Sub(4, "IV");
                Sub(1, "I");
                return roman;

                void Sub(int value, string numeral)
                {
                    var answer = "";
                    while (num >= value)
                    {
                        roman += numeral;
                        num -= value;
                    }
                }
            
        }

        public static string ZigZagConvert(string s, int numRows)
        {
            if (numRows == 1)
            {
                return s;
            }
            var array = new string[numRows];
            var direction = "down";
            var row = -1;
            for (int i = 0; i < s.Length; i++)
            {
                row += direction == "down" ? 1 : -1;
                array[row] += s[i];
                if (row == 0 && direction == "up")
                {
                    direction = "down";
                }
                else if (row == numRows -1 && direction == "down")
                {
                    direction = "up";
                }
            }
            var answer = array[0];
            for (int j = 1; j < numRows; j++)
            {
                answer += array[j];
            }
            return answer;
        }

        static void Main(string[] args)
        {
            var test1 = 4300;
            var answer = ZigZagConvert("PAYPALISHIRING", 3);
            Console.WriteLine(answer);
            Console.ReadKey();
        }
    }
}
