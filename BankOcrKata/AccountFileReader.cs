using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BankOcrKata
{
    public class AccountFileReader
    {
        public AccountNumber[] AccountNumbers { get; private set; }
        public AccountFileReader(string path)
        {
            AccountNumbers = ParseFile(path);
        }

        private AccountNumber[] ParseFile(string path)
        {
            var accountNumbers = new List<AccountNumber>();

            var lines = File.ReadLines(path);
            for (int i = 0; i + 4 <= lines.Count(); i += 4)
            {
                var rawText = lines.Skip(i).Take(4).ToArray();
                accountNumbers.Add(new AccountNumber(rawText));
            }

            return accountNumbers.ToArray();
        }
    }
}