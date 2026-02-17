namespace Solutions.Tests
{
    public class LargestPalindromeProductTests
    {
        [Theory]
        [InlineData(9009, true)]
        [InlineData(12321, true)]
        [InlineData(12345, false)]
        [InlineData(7, true)]
        [InlineData(0, true)]
        [InlineData(-121, false)]
        public void IsPalindromeReturnsExpected(int n, bool expected)
        {
            Assert.Equal(expected, LargestPalindromeProduct.IsPalindrome(n));
        }

        [Theory]
        [InlineData(1, 9)]
        [InlineData(2, 9009)]
        [InlineData(3, 906609)]
        public void GetLargestPalindromeReturnsExpectedForValidDigits(int digits, int expected)
        {
            Assert.Equal(expected, LargestPalindromeProduct.GetLargestPalindrome(digits));
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-10)]
        public void GetLargestPalindromeThrowsForNonPositiveDigits(int digits)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => LargestPalindromeProduct.GetLargestPalindrome(digits));
        }
    }
}
