/* 
Third task - Largest Prime Factor

The prime factors of 13195 are 5, 7, 13 and 29.
What is the largest prime factor of the number 600851475143 ?
*/
namespace Solutions;

public class LargestPrimeFactor
{

    public static long GetLargestPrimeFactor(long number)
    {
        if (number < 2)
        {
            return 0;
        }

        long remaining = number;
        long largestFactor = 1;

        while (remaining % 2 == 0)
        {
            largestFactor = 2;
            remaining /= 2;
        }

        for (long factor = 3; factor * factor <= remaining; factor += 2)
        {
            while (remaining % factor == 0)
            {
                largestFactor = factor;
                remaining /= factor;
            }
        }

        return remaining > 1 ? remaining : largestFactor;
    } 

}
