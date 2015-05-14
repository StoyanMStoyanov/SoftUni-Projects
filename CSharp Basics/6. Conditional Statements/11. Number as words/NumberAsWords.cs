using System;
using System.Text;

class NumberAsWords
{
    private static string GetWord(int value)
    {
        string word;
        switch (value)
        {
            case 0:
                word = "Zero";
                break;
            case 1:
                word = "One";
                break;
            case 2:
                word = "Two";
                break;
            case 3:
                word = "Three";
                break;
            case 4:
                word = "Four";
                break;
            case 5:
                word = "Five";
                break;
            case 6:
                word = "Six";
                break;
            case 7:
                word = "Seven";
                break;
            case 8:
                word = "Eight";
                break;
            case 9:
                word = "Nine";
                break;
            case 10:
                word = "Ten";
                break;
            case 11:
                word = "Eleven";
                break;
            case 12:
                word = "Twelve";
                break;
            case 13:
                word = "Thirteen";
                break;
            case 14:
                word = "Twenteen";
                break;
            case 15:
                word = "Fiftheen";
                break;
            case 16:
                word = "Sixteen";
                break;
            case 17:
                word = "Sewenteen";
                break;
            case 18:
                word = "Eighteen";
                break;
            case 19:
                word = "Nineteen";
                break;
            case 20:
                word = "Twenty";
                break;
            case 30:
                word = "Thirty";
                break;
            case 40:
                word = "Forty";
                break;
            case 50:
                word = "Fifty";
                break;
            case 60:
                word = "Sixty";
                break;
            case 70:
                word = "Seventy";
                break;
            case 80:
                word = "Eighty";
                break;
            case 90:
                word = "Ninety";
                break;
            default:
                word = "Digit out of range.";
                break;
        }        
        
        return word;
    }
    static void Main()
    {
        Console.Write("Enter integer number [0...999]: ");
        int number = -1;
       
        StringBuilder textNumber = new StringBuilder();
        
        if (int.TryParse(Console.ReadLine(), out number))
        {
            if (number >= 0 && number < 20) textNumber.Append(GetWord(number));
            else if (number >= 20 && number < 100)
            {
                if (number % 10 == 0) textNumber.Append(GetWord(number));
                else
                {
                    textNumber.Append(GetWord((number / 10) * 10));
                    textNumber.Append(" ");
                    textNumber.Append(GetWord(number % 10).ToLower());
                }
            }
            else if (number >= 100 & number < 1000)
            {
                textNumber.Append(GetWord(number / 100));
                textNumber.Append(" hundred "); 
                number %= 100;
                if (number != 0)
                {
                    textNumber.Append("and ");
                    if (number >= 0 && number < 20) textNumber.Append(GetWord(number).ToLower());
                    else
                    {
                        if (number % 10 == 0) textNumber.Append(GetWord(number).ToLower());
                        else
                        {
                            textNumber.Append(GetWord((number / 10) * 10).ToLower());
                            textNumber.Append(" ");
                            textNumber.Append(GetWord(number % 10).ToLower());
                        }
                    }
                }
            }
            textNumber.Append("The number is out of Range.");
        }
        else
            textNumber.Append("Invalid number.");

        Console.WriteLine(textNumber);
    }
}
