using System;
using System.Text.RegularExpressions;

class ValidUsername
{
    static void Main()
    {
        string input = @"ds3bhj y1ter/wfsdg 1nh_jgf ds2c_vbg\4htref"; //min23/ace hahah21 (    sasa  )  att3454/a/a2/abc chico/ gosho \ sapunerka (3sas) mazut  lelQ_Van4e";

        //string tag = "snasdjadc <a          href=http://softuni.bg>  SoftUni</a>masdlja D";
        //string pattern = @"<a\b[^>]*>(.*?)</a>"; //pattern without subpatterns       

        //Console.WriteLine(Regex.Match(tag, pattern));
        //string split = @"[ /\\()]+";
        string validateUserNamesPattren = @"([a-zA-z])\w+";

        //var splittingStr = Regex.Split(input, split); 
        var validate = Regex.Matches(input, validateUserNamesPattren);


        foreach (var item in validate)
        {
            if (Regex.IsMatch(item.ToString(), @"\w+"))
                Console.WriteLine(item);
        }
    }
}
