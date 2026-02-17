/*
Task 5 - Smallest multiple
2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
*/
namespace Solutions;

public class SmallestMultiple
{
    public static long FindSmallestNumberDivisibleByAllNumbersFrom1To(int n)
    {
        long smallestMultiple = 1;
        for (int i = 2; i <= n; i++)
        { smallestMultiple = GetLeastCommonMultiple(smallestMultiple, i); }
        return smallestMultiple;
    }
    private static long GetLeastCommonMultiple(long a, long b)
    {
        return a * b / GetGreatestCommonDivisor(a, b);
    }

    private static long GetGreatestCommonDivisor(long a, long b)
    {
        while (b != 0)
        {
            long temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}