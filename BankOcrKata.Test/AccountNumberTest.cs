using Xunit;

namespace BankOcrKata.Test
{
    public class AccountNumberTest
    {
        [Fact]
        public void Parse_ReturnsCorrectValue_When_RawTextIsValid()
        {
            var rawText = new string[] {
                "    _  _     _  _  _  _  _ ",
                "  | _| _||_||_ |_   ||_||_|",
                "  ||_  _|  | _||_|  ||_| _|",
                ""
            };
            var acctNum = new AccountNumber(rawText);
            Assert.Equal("123456789", acctNum.Value);
        }

        [Fact]
        public void Parse_ReturnsErrorStatus_When_RawTextIsInvalid()
        {
            var rawText = new string[] {
                " _  _  _     _  _  _  _  _ ",
                " _| _| _||_||_ |_   ||_||_|",
                "  ||_  _|  | _||_|  ||_| _|",
                ""
            };
            var acctNum = new AccountNumber(rawText);
            Assert.Equal("?23456789", acctNum.Value);
            Assert.Equal(0, acctNum.Checksum);
            Assert.Equal(ParseStatus.Illegible, acctNum.Status);
        }

        [Fact]
        public void Parse_Returns0Checksum_When_TextIsValid()
        {
            var rawText = new string[] {
                " _                         ",
                "  |  |  |  |  |  |  |  |  |",
                "  |  |  |  |  |  |  |  |  |",
                ""
            };
            var acctNum = new AccountNumber(rawText);
            Assert.Equal("711111111", acctNum.Value);
            Assert.Equal(0, acctNum.Checksum);
            Assert.Equal(ParseStatus.Success, acctNum.Status);
        }
    }
}