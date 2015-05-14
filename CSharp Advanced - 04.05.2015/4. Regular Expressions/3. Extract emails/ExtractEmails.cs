using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main()
    {
        //string input = "Please contact us at: support@github.com. Just send email to s.miller@mit.edu and j.hopking@york.ac.uk for more information. Many users @ SoftUni confuse email addresses. We @ Softuni.BG provide high-quality training @ home or @ class. –- steve.parker@softuni.de.";
        string input = "info@softuni-bulgaria.org, kiki@hotmail.co.uk, no-reply@github.com, s.peterson@mail.uu.net, info-bg@software-university.software.academy. support@github.com";
        string pattern = @"[a-z]+[.-]?[a-zA-Z0-9]+@(\w+[.-]?)+\w+[.][a-z]{2,}";
        Regex regex = new Regex(pattern);
        MatchCollection matches = regex.Matches(input);
        foreach (var item in matches)        
            Console.WriteLine(item);        
    }
}
