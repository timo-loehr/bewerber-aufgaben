namespace Solutions.Tests;

public class SmallestMultipleTests
{
    [Fact]
    public void NumbersFrom1To10_Returns2520()
    {
        var result = SmallestMultiple.FindSmallestNumberDivisibleByAllNumbersFrom1To(10);
        Assert.Equal(2520, result);
    }

    [Fact]
    public void NumbersFrom1To20_Returns232792560()
    {
        var result = SmallestMultiple.FindSmallestNumberDivisibleByAllNumbersFrom1To(20);
        Assert.Equal(232792560, result);
    }
}