namespace Solutions.Tests;

public class MultiplesOfThreeOrFiveTest
{
    [Fact]
    public void Below10_Returns23()
    {
        Assert.Equal(23, MultiplesOfThreeOrFive.GetSumOfMultiplesOfThreeOrFive(10));
    }

    [Fact]
    public void Below1000_Returns233168()
    {
        Assert.Equal(233168, MultiplesOfThreeOrFive.GetSumOfMultiplesOfThreeOrFive(1000));
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public void NonPositiveLimit_Returns0(int limit)
    {
        Assert.Equal(0, MultiplesOfThreeOrFive.GetSumOfMultiplesOfThreeOrFive(limit));
    }
}
