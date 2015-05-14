using System;
using System.Text;

class FourDigitNumber
{
    static void Main()
    {
        Console.Write("Enter four digit integer value: ");
        int value = int.Parse(Console.ReadLine());
        string strValue = value.ToString();

        //Sum of value's digits
        int sum = 0;
        for (int i = 0; i < strValue.Length; i++ )        
            sum += int.Parse(strValue[i].ToString());        
        Console.WriteLine("The sum of digits is: {0}", sum);

        //Reverse value's digits
        StringBuilder reverseValue = new StringBuilder();
        for (int i = strValue.Length - 1; i >= 0; i--)        
            reverseValue.Append(strValue[i]);          
        Console.WriteLine("The reversed value is: {0}", reverseValue);

        //Move last digit at first position
        string moveLastDigit = "";
        moveLastDigit += strValue[strValue.Length-1];
        for (int i = 0; i < strValue.Length-1; i ++ )  
            moveLastDigit += strValue[i];
        Console.WriteLine("The value with moved last digit is: {0}.", moveLastDigit);

        //Exchange second and third digits
        string exchangeDigits = "";
        for (int i = 0; i < strValue.Length; i++)
        {
            if (i == 1)
            {
                exchangeDigits += strValue[2];
                exchangeDigits += strValue[1];
                i++;
                continue;
            }
            exchangeDigits += strValue[i];
        }
        Console.WriteLine("The value with changed 2 and 3 position is: {0}.", exchangeDigits);
    }
}
