/* 
    First task - Multiples of 3 or 5

    If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
    The sum of these multiples is 23.

    Find the sum of all the multiples of 3 or 5 below 1000.
*/
namespace Solutions;

public class MultiplesOfThreeOrFive
{

    public static int getSumOfMultiplesOfThreeOrFive(int limit)
    {
        if (limit <= 0) return 0;

        return Enumerable
            .Range(0, limit)
            .Where(n => n % 3 == 0 || n % 5 == 0)
            .Sum();
    }

}
