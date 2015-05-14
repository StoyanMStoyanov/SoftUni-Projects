using System;
using System.Text;

class EncryptedMatrix
{
    static void Main()
    {
        string message = Console.ReadLine();
        string diagonal = Console.ReadLine();
        int[] lastDigits = new int[message.Length+2];
        lastDigits[0] = 0;
        lastDigits[message.Length] = 0;
        for (int i = 0; i < message.Length; i++)
        {
            lastDigits[i+1] = (int)message[i] % 10;
            //Console.WriteLine("{0}  {1}  {2}", message[i], (int)message[i], lastDigits[i+1]);
        }

        StringBuilder encrypt = new StringBuilder();
        int tempValue;
        for (int i = 0; i < message.Length; i++)
        {
            if (lastDigits[i + 1] % 2 != 0)
            {
                tempValue = lastDigits[i] + lastDigits[i + 1] + lastDigits[i + 2];
                encrypt.Append(tempValue);
            }
            else
            {
                encrypt.Append(lastDigits[i + 1] * lastDigits[i + 1]);
            }
        }
        
        string str = encrypt.ToString();

        if (diagonal == "\\")
        {
            for (int i = 0; i < encrypt.Length; i++)
            {
                for (int j = 0; j < encrypt.Length; j++)
                {
                    if (i == j) Console.Write(str[i] + " ");
                    else Console.Write(0 + " ");
                }
                Console.WriteLine();
            }
        }
        else
        {
            int n = encrypt.Length - 1;
            for (int i = 0; i < encrypt.Length; i++)
            {
                for (int j = 0; j < encrypt.Length; j++)
                {
                    if (j == n) Console.Write("{0} ", str[n]);
                    else Console.Write("{0} ", 0);
                }
                n--;
                Console.WriteLine();
            }
        }
    }
}
