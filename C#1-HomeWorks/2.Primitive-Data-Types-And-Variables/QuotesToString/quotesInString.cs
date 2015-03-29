using System;

namespace QuotesInString
{
    class quotesInString
    {
        static void Main()
        {
            string ecaping = "The \"use\" of quotations causes difficulties.";
            string doubleQuote = @"The ""use"" of quotations causes difficulties.";

            System.Console.WriteLine(ecaping);
            System.Console.WriteLine(doubleQuote);
        }
    }
}
