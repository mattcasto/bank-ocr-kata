using Xunit;

namespace BankOcrKata.Test
{
    public class DigitTest
    {
        [Fact]
        public void Parse_Returns0_When_TextIsZero()
        {
            Assert.Equal('0', Digit.Parse(
                " _ " +
                "| |" +
                "|_|"));
        }

        [Fact]
        public void Parse_Returns1_When_TextIsOne()
        {
            Assert.Equal('1', Digit.Parse(
                "   " +
                "  |" +
                "  |"));
        }

        [Fact]
        public void Parse_Returns2_When_TextIsTwo()
        {
            Assert.Equal('2', Digit.Parse(
                " _ " +
                " _|" +
                "|_ "));
        }

        [Fact]
        public void Parse_Returns3_When_TextIsThree()
        {
            Assert.Equal('3', Digit.Parse(
                " _ " +
                " _|" +
                " _|"));
        }

        [Fact]
        public void Parse_Returns4_When_TextIsFour()
        {
            Assert.Equal('4', Digit.Parse(
                "   " +
                "|_|" +
                "  |"));
        }

        [Fact]
        public void Parse_Returns5_When_TextIsFive()
        {
            Assert.Equal('5', Digit.Parse(
                " _ " +
                "|_ " +
                " _|"));
        }

        [Fact]
        public void Parse_Returns6_When_TextIsSix()
        {
            Assert.Equal('6', Digit.Parse(
                " _ " +
                "|_ " +
                "|_|"));
        }

        [Fact]
        public void Parse_Returns7_When_TextIsSeven()
        {
            Assert.Equal('7', Digit.Parse(
                " _ " +
                "  |" +
                "  |"));
        }

        [Fact]
        public void Parse_Returns8_When_TextIsEight()
        {
            Assert.Equal('8', Digit.Parse(
                " _ " +
                "|_|" +
                "|_|"));
        }

        [Fact]
        public void Parse_Returns9_When_TextIsNine()
        {
            Assert.Equal('9', Digit.Parse(
              " _ " +
              "|_|" +
              " _|"));
        }

        [Fact]
        public void Parse_ReturnsQuestionMark_When_TextIsNotValidNumber()
        {
            Assert.Equal('?', Digit.Parse(
              "   " +
              "|_|" +
              " _|"));
        }

        [Fact]
        public void Parse_ReturnsQuestionMark_When_TextIsEmpty()
        {
            Assert.Equal('?', Digit.Parse(""));
        }

        [Fact]
        public void Parse_ReturnsQuestionMark_When_TextIsTooLong()
        {
            Assert.Equal('?', Digit.Parse("1234567890"));
        }
    }
}
