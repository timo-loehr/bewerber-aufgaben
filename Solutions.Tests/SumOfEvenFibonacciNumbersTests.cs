namespace Solutions.Tests;

public class SumOfEvenFibonacciNumbersTest
{
    [Fact]
    public void MaxValue100_Returns44()
    {
        Assert.Equal(44, SumOfEvenFibonacciNumbers.GetSumOfEvenFibonacciNumbers(100));
    }

    [Fact]
    public void MaxValue4000000_Returns4613732()
    {
        Assert.Equal(4613732, SumOfEvenFibonacciNumbers.GetSumOfEvenFibonacciNumbers(4000000));
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(-1)]
    public void MaxValueBelow2_Returns0(int maxValue)
    {
        Assert.Equal(0, SumOfEvenFibonacciNumbers.GetSumOfEvenFibonacciNumbers(maxValue));
    }
}


