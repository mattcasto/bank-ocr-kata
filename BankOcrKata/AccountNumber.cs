using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BankOcrKata
{
    public class AccountNumber
    {
        public string Value { get; private set; }
        public string RawText { get; private set; }
        public int Checksum { get; private set; }
        public ParseStatus Status { get; private set; }

        public AccountNumber(string[] rawText)
        {
            RawText = string.Join(Environment.NewLine, rawText);
            Parse(rawText);
        }

        private void Parse(string[] rawText)
        {
            Value = string.Empty;
            Checksum = 0;

            try
            {
                for (int i = 0; i < 25; i += 3)
                {
                    var digitText = string.Empty;
                    for (int j = 0; j < 3; j++)
                    {
                        digitText = digitText + rawText[j].Substring(i, 3);
                    }
                    Value = Value + Digit.Parse(digitText);
                }
                
                if (Value.Contains("?"))
                {
                    Status = ParseStatus.Illegible;
                    return;
                }

                Checksum = CalculateChecksum(Value);

                if (Checksum != 0)
                    Status = ParseStatus.Error;
                else
                    Status = ParseStatus.Success;
            }
            catch
            {
                Status = ParseStatus.Error;
            }
        }

        private int CalculateChecksum(string val)
        {
            if (val.Length != 9)
                return -1;
            
            return val.ToCharArray().Select((char c, int i) => (9 - i) * Int32.Parse(c.ToString())).Sum() % 11;
        }
    }

}