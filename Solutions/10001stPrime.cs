/*
Task 7 - 10001st Prime

By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
What is the 10 001st prime number?
*/
namespace Solutions;

public class Prime10001st
{
    public static int GetNthPrimeNumber(int n)
    {
        if (n < 1) throw new ArgumentOutOfRangeException(nameof(n), "N must be a positive integer.");

        return GeneratePrimes()
            .Skip(n - 1)
            .First();
    }

    private static IEnumerable<int> GeneratePrimes()
    {
        var knownPrimes = new List<int> { 2 };
        yield return 2;

        for (var candidate = 3; ; candidate += 2)
        {
            if (IsPrime(candidate, knownPrimes))
            {
                knownPrimes.Add(candidate);
                yield return candidate;
            }
        }
    }

    private static bool IsPrime(int number, List<int> knownPrimes)
    {
        var limit = (int)Math.Sqrt(number);
        return knownPrimes
            .TakeWhile(p => p <= limit)
            .All(p => number % p != 0);
    }
}
