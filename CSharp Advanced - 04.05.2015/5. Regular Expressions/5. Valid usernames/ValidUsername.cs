using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class ValidUsername
{
    static void Main()
    {
        //string userNames = @"ds3bhj y1ter/wfsdg 1nh_jgf ds2c_vbg\4htref";
        //string userNames = @"min23/ace hahah21 (    sasa  )  att3454/a/a2/abc";
        string userNames = @"chico/ gosho \ sapunerka (3sas) mazut  lelQ_Van4e";
        //string userNames = Console.ReadLine();
        string splitSeparators = @"\s+|\/|\\|\(|\)";

        Regex regex = new Regex(splitSeparators);
        string[] splitUsrNames = Regex.Split(userNames, splitSeparators);

        List<string> matches = new List<string>();
        foreach (var item in splitUsrNames)        
            if (Regex.IsMatch(item, @"\b[a-z]\w{2,24}\s?\b"))
                matches.Add(item);        
        
        Console.WriteLine(CalculateLongestUserNames(matches));
    }

    private static string CalculateLongestUserNames(List<string> validate)
    {
        int tempLong = validate.Count;
        int maxLong = 0;
        int index = 0;
        for (int i = 0; i < validate.Count - 1; i++)
        {
            tempLong = validate[i].Length + validate[i + 1].Length;
            if (maxLong < tempLong)
            {
                maxLong = tempLong;
                index = i;
            }
        }
        return string.Format("{0}\n{1}", validate[index], validate[index + 1]);
    }
}
