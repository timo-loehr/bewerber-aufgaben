namespace Solutions.Tests;

public class Prime10001stTests
{
    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    [InlineData(-100)]
    public void NLessThan1_ThrowsException(int n)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => Prime10001st.GetNthPrimeNumber(n));
    }

    [Theory]
    [InlineData(1, 2)]
    [InlineData(2, 3)]
    [InlineData(3, 5)]
    [InlineData(6, 13)]
    public void SmallN_ReturnsExpectedPrime(int n, int expected)
    {
        var result = Prime10001st.GetNthPrimeNumber(n);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void N10001_Returns104743()
    {
        var result = Prime10001st.GetNthPrimeNumber(10001);
        Assert.Equal(104743, result);
    }
}
