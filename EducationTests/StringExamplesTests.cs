using Xunit;
using Education.BasicString;

namespace EducationTests
{
    public class StringExamplesTests
    {
        [Theory]
        [InlineData("Hello", "World", "HelloWorld")]
        [InlineData("Good", "Morning", "GoodMorning")]
        [InlineData("", "Empty", "Empty")]
        public void Concatenate_TwoStrings_ReturnsConcatenatedString(string a, string b, string expected)
        {
            Assert.Equal(expected, StringExamples.Concatenate(a, b));
        }

        [Theory]
        [InlineData("Hello", 5)]
        [InlineData("Goodbye", 7)]
        [InlineData("", 0)]
        public void GetLength_String_ReturnsCorrectLength(string input, int expected)
        {
            Assert.Equal(expected, StringExamples.GetLength(input));
        }

        [Theory]
        [InlineData("hello", "HELLO")]
        [InlineData("world", "WORLD")]
        [InlineData("", "")]
        public void ToUpper_String_ReturnsUpperCaseString(string input, string expected)
        {
            Assert.Equal(expected, StringExamples.ToUpper(input));
        }

        [Theory]
        [InlineData("HELLO", "hello")]
        [InlineData("WORLD", "world")]
        [InlineData("", "")]
        public void ToLower_String_ReturnsLowerCaseString(string input, string expected)
        {
            Assert.Equal(expected, StringExamples.ToLower(input));
        }

        [Theory]
        [InlineData("HelloWorld", "World", true)]
        [InlineData("HelloWorld", "Test", false)]
        [InlineData("TestString", "String", true)]
        public void Contains_Substring_ReturnsCorrectBoolean(string input, string substring, bool expected)
        {
            Assert.Equal(expected, StringExamples.Contains(input, substring));
        }
    }
}
