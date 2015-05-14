using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

class Program
{
    static void Main()
    {
        string input = 
@"<ul>
<li>
<a          href=http://softuni.bg>
SoftUni</a>
</li>
</ul>";        
        input = Regex.Replace(input, @"<a", "[URL ");
        input = Regex.Replace(input, @">", "]");
        input = Regex.Replace(input, @"</a",@" [/URL");
        Console.WriteLine(input);
    }
}
