using Xunit;

namespace Solutions.Tests;

public class LargestPrimeFactorTests
{
    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 0)]
    [InlineData(-10, 0)]
    public void Below2_Returns0(long n, long expected)
        => Assert.Equal(expected, LargestPrimeFactor.GetLargestPrimeFactor(n));

    [Theory]
    [InlineData(2, 2)]
    [InlineData(3, 3)]
    [InlineData(4, 2)]
    [InlineData(5, 5)]
    [InlineData(6, 3)]
    [InlineData(8, 2)]
    [InlineData(9, 3)]
    public void SmallNumbers(long n, long expected)
        => Assert.Equal(expected, LargestPrimeFactor.GetLargestPrimeFactor(n));

    [Fact]
    public void Example13195_Returns29()
        => Assert.Equal(29, LargestPrimeFactor.GetLargestPrimeFactor(13195));
    [Fact]
    public void Euler3_Returns6857()
        => Assert.Equal(6857, LargestPrimeFactor.GetLargestPrimeFactor(600851475143));
}