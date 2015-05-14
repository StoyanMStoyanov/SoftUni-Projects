using System;
using System.Text;
using System.Collections.Generic;

class DecryptTheMessage
{
    static void Main()
    {
        int messageCount = 0;
        List<char> decruptedMessage = new List<char>();
        StringBuilder allMessages = new StringBuilder();
        bool isMessage = false;
        bool isEmpty = true;
        bool isStart = false;
        while (true)
        {
            string comOrMes = Console.ReadLine();
            if (comOrMes == "End" || comOrMes == "END" || comOrMes == "end") isMessage = false;
            if (isMessage)
            {
                allMessages.Append(comOrMes + '\n');                
                continue;
            }
            if (comOrMes == "START" || comOrMes == "Start" || comOrMes == "start")
            {
                isMessage = true;
                isStart = true;
                continue;
            }
            if (!isStart) continue;
            string temp = allMessages.ToString();
            string[] messages = temp.Split('\n');
            allMessages.Clear();
            for (int j = 0; j < messages.Length - 1; j++)
            {
                string message = messages[j];
                
                for (int i = 0; i < message.Length; i++)
                {
                    char tempChar = message[i];
                    if (ConvertChar(tempChar) == '*') continue;
                    decruptedMessage.Add(ConvertChar(tempChar));
                }
                if (decruptedMessage.Count != 0)
                {
                    isEmpty = false;
                    decruptedMessage.Reverse();
                    for (var k = 0; k < decruptedMessage.Count; k++)
                        allMessages.Append((char)decruptedMessage[k]);
                    allMessages.Append('\n');
                    messageCount++;
                }                
                decruptedMessage.Clear();
            }

            break;
        }
        if (isEmpty) Console.WriteLine("No message received.");
        else
        {
            allMessages.Remove(allMessages.Length - 1, 1);
            string[] newString = allMessages.ToString().Split('\n');
            Console.WriteLine("Total number of messages: {0}", messageCount);           
            for (int i = 0; i < newString.Length; i++)                
                Console.WriteLine(newString[i]);
        }
    }

    private static char ConvertChar(char p)
    {
        int temp = (int)p;
        if ((int)p >= 48 && (int)p <= 57) temp = (int)p;
        else if ((int)p >= 65 && (int)p <= 77) temp += 13;
        else if ((int)p >= 78 && (int)p <= 90) temp -= 13;
        else if ((int)p >= 97 && (int)p <= 109) temp += 13;
        else if ((int)p >= 110 && (int)p <= 122) temp -= 13;
        else if (p == '+') temp = (int)' ';
        else if (p == '%') temp = (int)',';
        else if (p == '&') temp = (int)'.';
        else if (p == '#') temp = (int)'?';
        else if (p == '$') temp = (int)'!';
        else temp = (char)'*';

        return (char)temp;
    }
}
