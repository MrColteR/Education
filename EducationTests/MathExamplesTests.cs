using Xunit;
using Education.BasicMath;

namespace EducationTests
{
    public class MathExamplesTests
    {
        [Theory]
        [InlineData(2, 3, 5)]
        [InlineData(-1, 1, 0)]
        [InlineData(0, 0, 0)]
        public void Add_TwoNumbers_ReturnsCorrectSum(int a, int b, int expected)
        {
            Assert.Equal(expected, MathExamples.Add(a, b));
        }

        [Theory]
        [InlineData(4, 3, 1)]
        [InlineData(-1, 1, -2)]
        [InlineData(0, 5, -5)]
        public void Subtract_TwoNumbers_ReturnsCorrectDifference(int a, int b, int expected)
        {
            Assert.Equal(expected, MathExamples.Subtract(a, b));
        }

        [Theory]
        [InlineData(3, 4, 12)]
        [InlineData(-2, 5, -10)]
        [InlineData(0, 5, 0)]
        public void Multiply_TwoNumbers_ReturnsCorrectProduct(int a, int b, int expected)
        {
            Assert.Equal(expected, MathExamples.Multiply(a, b));
        }

        [Theory]
        [InlineData(9, 3, 3)]
        [InlineData(-10, -2, 5)]
        [InlineData(0, 1, 0)]
        public void Divide_TwoNumbers_ReturnsCorrectQuotient(int a, int b, int expected)
        {
            Assert.Equal(expected, MathExamples.Divide(a, b));
        }

        [Fact]
        public void Divide_ByZero_ThrowsDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => MathExamples.Divide(1, 0));
        }
    }
}
