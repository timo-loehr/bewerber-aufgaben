/*
Task 6 - Sum Square Difference

The sum of the squares of the first ten natural numbers is
1² + 2² + … + 10² = 385

The square of the sum of the first ten natural numbers is
(1 + 2 + … + 10)² = 55² = 3025

Hence the difference between the sum of the squares of the first ten natural numbers and
the square of the sum is
3025 – 385 = 2640

Find the difference between the sum of the squares of the first one hundred natural
numbers and the square of the sum.
*/
namespace Solutions;

public class SumSquareDifference
{
    public static long GetDifferenceBetweenSquareOfSumAndSumOfSquares(int n)
    {
        return n <= 1 ? 0 : GetSquareOfSum(n) - GetSumOfSquares(n);
    }

    private static long GetSquareOfSum(int n)
    {
        var sum = Enumerable
            .Range(1, n)
            .Sum(i => (long)i);

        return sum * sum;
    }

    private static long GetSumOfSquares(int n)
    {
        return Enumerable
            .Range(1, n)
            .Sum(i => (long)i * i);
    }
}
