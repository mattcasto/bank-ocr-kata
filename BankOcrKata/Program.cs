using System;
using System.IO;
using System.Reflection;

namespace BankOcrKata
{
    class Program
    {
        static void Main(string[] args)
        {
            var projPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location );
            var testFilePath = Path.Combine(projPath, "BankOcr.txt");
            var accountFileReader = new AccountFileReader(testFilePath);

            foreach (var accountNumber in accountFileReader.AccountNumbers)
            {
                Console.WriteLine(accountNumber.RawText);
                Console.WriteLine($"=> {accountNumber.Value} {accountNumber.Checksum} {ParseResult.StatusCode(accountNumber.Status)}");
            }
        }
    }
}
