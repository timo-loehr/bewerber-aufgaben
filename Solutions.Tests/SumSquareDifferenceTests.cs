namespace Solutions.Tests;

public class SumSquareDifferenceTests
{
    [Fact]
    public void First10NaturalNumbers_Returns2640()
    {
        var result = SumSquareDifference.GetDifferenceBetweenSquareOfSumAndSumOfSquares(10);
        Assert.Equal(2640, result);
    }

    [Fact]
    public void First100NaturalNumbers_Returns25164150()
    {
        var result = SumSquareDifference.GetDifferenceBetweenSquareOfSumAndSumOfSquares(100);
        Assert.Equal(25164150, result);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(0)]
    [InlineData(-5)]
    public void NLessThanOrEqualTo1_Returns0(int n)
    {
        var result = SumSquareDifference.GetDifferenceBetweenSquareOfSumAndSumOfSquares(n);
        Assert.Equal(0, result);
    }
}
