using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class PINValidation
{
    static void Main()
    {
#if DEBUG
        var file = new StreamReader("..\\..\\18. PIN Validation_Тестове\\test.009.in.txt");
        Console.SetIn(file);
#endif

        StringBuilder resultJSON = new StringBuilder();

        
        string name = Regex.Replace(Console.ReadLine(), @"\s{2,}", " ").Trim();
        bool isValidateName = ValidateName(name);
        string gender = Console.ReadLine().Trim();
        string pin = Console.ReadLine();
        string year = pin[0].ToString() + pin[1];
        string month = pin[2].ToString() + pin[3];
        int mon = int.Parse(month);
        string day = pin[3].ToString() + pin[4];

        bool validatePin = PinValidate(pin, gender, mon);
        if (isValidateName && validatePin)
        {
            resultJSON.Append("{\"name\":\"");
            resultJSON.Append(name);
            resultJSON.Append("\",\"gender\":\"");
            
            resultJSON.Append(gender);
            resultJSON.Append("\",\"pin\":\"");

            resultJSON.Append(pin);
            resultJSON.Append("\"}");
        }
        else
        {
            resultJSON.Clear();
            resultJSON.Append("<h2>Incorrect data</h2>");
        }
        Console.WriteLine(resultJSON);
    }

    private static bool ValidateName(string inputName)
    {
        var name = inputName.Split();
        if(name.Length == 1)
            return false;
        if(char.IsUpper(name[0][0]) && char.IsUpper(name[1][0]))
            return true;
        return false;
    }

    private static bool PinValidate(string pin, string gender, int mon)
    {
        bool isReminderCorrect = false;
        long sum = 0;
        int checkSum = int.Parse(pin[9].ToString());
        int digitForGender = int.Parse(pin[8].ToString());
        
        if ((mon > 0 && mon <= 12) || (mon > 20 && mon <= 32) || (mon > 40 && mon <= 52))
        {
            if (((digitForGender % 2 == 0) && gender == "male") ||
                ((digitForGender % 2 != 0) && gender == "female"))
            {
                sum = (int.Parse(pin[0].ToString()) * 2) +
                      (int.Parse(pin[1].ToString()) * 4) +
                      (int.Parse(pin[2].ToString()) * 8) +
                      (int.Parse(pin[3].ToString()) * 5) +
                      (int.Parse(pin[4].ToString()) * 10) +
                      (int.Parse(pin[5].ToString()) * 9) +
                      (int.Parse(pin[6].ToString()) * 7) +
                      (int.Parse(pin[7].ToString()) * 3) +
                      (int.Parse(pin[8].ToString()) * 6);
                long reminder = sum % 11;
                if (reminder == 10) reminder = 0;
                //Console.WriteLine(reminder);
                if (reminder == checkSum)
                {
                    isReminderCorrect = true;
                }
            }
        }
        return isReminderCorrect;
    }
}