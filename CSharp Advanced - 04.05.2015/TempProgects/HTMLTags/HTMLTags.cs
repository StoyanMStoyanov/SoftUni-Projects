using System;
using System.Text.RegularExpressions;
using System.Text;

namespace HTMLTags
{
    class HTMLTags
    {
        static void Main()
        {
            //string tag = "snasdjadc <a          href=http://softuni.bg>  SoftUni</a>masdlja D";
            //string tag = "<a href=\"http://softuni.bg\" class=\"new\"></a>   <a href=\"http://softuni1.bg\" class=\"new\"></a>";
            StringBuilder tag = new StringBuilder();
            while (true)
            {
                string temp = Console.ReadLine();
                if (temp == "END") break;
                tag.Append(temp);
            }
            string pattern = @"<a\b[^>]*>(.*?)</a>"; //pattern without subpatterns       
            MatchCollection collection = Regex.Matches(tag.ToString(), pattern);


            string hrefPattern = @"\bhref\s*=\s*(?<hrefference>'[^']*|""[^""]*|\S*)";
            
            Regex href = new Regex(hrefPattern);
            
            foreach (var item in collection)
            {
                //Console.WriteLine(item);
                var aaa = href.Match(item.ToString());
                Console.WriteLine(aaa.Groups["hrefference"].Value);
            }
            
        }
    }
}
