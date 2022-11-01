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

        public static int RomanToInt(string roman)
        {
            var sum = 0;
            string? lastDigit = null;
            string? lastTwoDigits = null;
            Console.WriteLine(roman);
            while (roman.Length > 0)
            {
                lastDigit = roman[roman.Length - 1].ToString();
                if (lastDigit == "I")
                {
                    sum++;
                    roman = roman.Substring(0, roman.Length - 1);
                }
                else
                {
                    lastTwoDigits = roman.Length > 1 ? roman.Substring(roman.Length - 2, 2) : lastDigit;
                    if (lastTwoDigits == "IV")
                    {
                        sum += 4;
                        roman = roman.Substring(0, roman.Length - 2);
                    }
                    else if (lastTwoDigits == "IX")
                    {
                        sum += 9;
                        roman = roman.Substring(0, roman.Length - 2);
                    }
                    else if (lastTwoDigits == "XL")
                    {
                        sum += 40;
                        roman = roman.Substring(0, roman.Length - 2);
                    }
                    else if (lastTwoDigits == "XC")
                    {
                        sum += 90;
                        roman = roman.Substring(0, roman.Length - 2);
                    }
                    else if (lastTwoDigits == "CD")
                    {
                        sum += 400;
                        roman = roman.Substring(0, roman.Length - 2);
                    }
                    else if (lastTwoDigits == "CM")
                    {
                        sum += 900;
                        roman = roman.Substring(0, roman.Length - 2);
                    }
                    else if (lastDigit == "V")
                    {
                        sum += 5;
                        roman = roman.Substring(0, roman.Length - 1);
                    }
                    else if (lastDigit == "X")
                    {
                        sum += 10;
                        roman = roman.Substring(0, roman.Length - 1);
                    }
                    else if (lastDigit == "L")
                    {
                        sum += 50;
                        roman = roman.Substring(0, roman.Length - 1);
                    }
                    else if (lastDigit == "C")
                    {
                        sum += 100;
                        roman = roman.Substring(0, roman.Length - 1);
                    }
                    else if (lastDigit == "D")
                    {
                        sum += 500;
                        roman = roman.Substring(0, roman.Length - 1);
                    }
                    else if (lastDigit == "M")
                    {
                        sum += 1000;
                        roman = roman.Substring(0, roman.Length - 1);
                    }
                }
                
                
                Console.WriteLine(roman);
            }

            return sum;
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
        public static int Reverse(int x)
        {
            var stringify = Math.Abs(x).ToString().ToCharArray();
            var answer = 0;
            var place = 1;
            var digit = 0;
            foreach (char c in stringify)
            {

                digit = Convert.ToInt32(char.GetNumericValue(c));
                if (place > 1000000000 || answer > 2147483647 || (place == 100000000 && digit > 2))
                {
                    return 0;
                }
                if (c != '0' || place != 1)
                {
                    answer += digit * place;
                    Console.WriteLine($"{c}*{place}={digit * place} => {answer}");
                    place *= 10;
                }
            }
            return x < 0 ? answer * -1: answer;
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            var digitsInShortestWord = strs.OrderBy(x => x.Length).FirstOrDefault().Length;
            var oldPrefixReference = "";
            var newPrefixReference = "";
            var answer = "";
            for (int digits = 1; digits <= digitsInShortestWord; digits++)
            {
                oldPrefixReference = newPrefixReference;
                newPrefixReference = strs[0].Substring(0, digits);
                foreach (string word in strs)
                {
                    if (word.Substring(0, digits) != newPrefixReference)
                    {
                        answer = oldPrefixReference;
                        Console.WriteLine($"break: {newPrefixReference}");
                        return answer;
                    }
                }
                Console.WriteLine($"continue: {newPrefixReference}");
                answer = newPrefixReference;
            }
            return answer;
        }


        static void Main(string[] args)
        {
            var test1 = new string[] { "flower", "flow", "flight" };
            var answer = LongestCommonPrefix(test1);
            Console.WriteLine(answer);
            Console.ReadKey();
        }
    }
}
