using System;

namespace BankOcrKata
{
    public enum ParseStatus
    {
        Success = 0,
        Error = 1,
        Illegible = 2
    }

    public static class ParseResult
    {
        public static string StatusCode(ParseStatus status)
        {
            switch(status)
            {
                case ParseStatus.Error:
                    return "ERR";
                case ParseStatus.Illegible:
                    return "ILL";
                default:
                    return string.Empty;
            }
        }
    }
}