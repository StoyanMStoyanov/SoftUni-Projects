using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

   class RageQuit
    {
        static void Main(string[] args)
        {
            const string pattern = @"(.+?)(\d+)";
            string inputString = Console.ReadLine();// @"aSd2&5s@1";

            MatchCollection matches = Regex.Matches(inputString, pattern);
            //int uniqueSumbols = 0;
            StringBuilder result = new StringBuilder();
            HashSet<char> unSumbols = new HashSet<char>();
            foreach (Match item in matches)
            {
                //Console.WriteLine(item.Groups[1] + "    " + item.Groups[2]);
                string replace = StrRep(item.Groups[1].ToString(), int.Parse(item.Groups[2].ToString()));
                foreach (var ch in item.Groups[1].ToString())
                {
                    unSumbols.Add(char.ToUpper(ch));
                }
                //result = Regex.Replace(inputString, item.Groups[1].ToString(), replace);
                result.Append(replace);
            }
            Console.WriteLine("Unique symbols used: {0}\n{1}", unSumbols.Count, result);
        }

        private static string StrRep(string p1, int p2)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < p2; i++)
            {
                result.Append(p1.ToUpper());
            }
            return result.ToString();
        }
   }
