/*
Task 4 - Largest palindrome product

A palindromic number reads the same both ways. The largest palindrome made from the product
of two 2-digit numbers is 9009 = 91 × 99.
Find the largest palindrome made from the product of two 3-digit numbers.
*/
using System.Diagnostics.Contracts;

namespace Solutions
{
    public class LargestPalindromeProduct
    {
        public static int GetLargestPalindrome(int digits)
        {
            if (digits <= 0)
                throw new ArgumentOutOfRangeException(nameof(digits), "Number of digits must be positive.");

            int max = (int)Math.Pow(10, digits) - 1;
            int min = (int)Math.Pow(10, digits - 1);
            int largestPalindrome = 0;

            for (int i = max; i >= min; i--)
            {
                for (int j = i; j >= min; j--)
                {
                    int product = i * j;
                    if (product <= largestPalindrome)
                        break;

                    if (IsPalindrome(product))
                        largestPalindrome = product;
                }
            }

            return largestPalindrome;
        }

        public static bool IsPalindrome(int number)
        {
            string str = number.ToString();
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return str == new string(charArray);
        }
    }
}