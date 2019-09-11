using System;
using System.Collections.Generic;

namespace BankOcrKata
{
    public static class Digit
    {
        public static Dictionary<string, char> DigitDefinitions = new Dictionary<string, char>() {
            { " _ " +
              "| |" +
              "|_|", '0' },
            { "   " +
              "  |" +
              "  |", '1' },
            { " _ " +
              " _|" +
              "|_ ", '2' },
            { " _ " +
              " _|" +
              " _|", '3' },
            { "   " +
              "|_|" +
              "  |", '4' },
            { " _ " +
              "|_ " +
              " _|", '5' },
            { " _ " +
              "|_ " +
              "|_|", '6' },
            { " _ " +
              "  |" +
              "  |", '7' },
            { " _ " +
              "|_|" +
              "|_|", '8' },
            { " _ " +
              "|_|" +
              " _|", '9' },
        };

        public static char Parse(string rawText)
        {
            var txt = rawText.Replace(Environment.NewLine, "");
            if (txt.Length != 9) return '?';
            
            txt = txt.Substring(0, 9);
            return DigitDefinitions.ContainsKey(txt) ? DigitDefinitions[txt] : '?';
        }
    }
}