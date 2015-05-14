using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Quotes_in_Strings
{
    class QuotesInStrings
    {
        static void Main(string[] args)
        {
            string strWithQuotes = "The \"use\" of quotations causes difficulties.";
            string strWithOutQuotes = "The use of quotations causes difficulties.";
            Console.WriteLine(strWithQuotes);
            Console.WriteLine(strWithOutQuotes);
        }
    }
}
