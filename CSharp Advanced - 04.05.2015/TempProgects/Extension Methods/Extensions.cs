using System.Text;
namespace MyExtension
{
    public static class Extensions
    {
        public static string ReverseString(this string inputString)
        {
            StringBuilder temp = new StringBuilder();
            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                temp.Append(inputString[i]);
            }
            return temp.ToString();
        }

        public static string ReverseToUpper(this StringBuilder sb)
        {
            StringBuilder temp = new StringBuilder();
            for (int i = 0; i < sb.Length; i++)
            {
                temp.Append(char.ToUpper(sb[i]));
            }
            return temp.ToString();
        }
    }
}
