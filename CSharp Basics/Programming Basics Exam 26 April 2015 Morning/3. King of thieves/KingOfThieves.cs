using System;

class KingOfThieves
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string ch = Console.ReadLine();
        int temp = 1;
        
        for (int i = 0; i <= n / 2; i++)
        {
            Console.Write(new string('-', (n / 2) - i));
            for (int j = 0; j < temp; j++)            
                Console.Write(ch[0]);
            Console.WriteLine(new string('-', (n / 2) - i));
            temp += 2;            
        }
        temp -= 4;
        for (int i =1; i <= n/2; i++)
        {
            Console.Write(new string('-', i));
            for (int j = 0; j < temp; j++)
                Console.Write(ch[0]); 
            Console.WriteLine(new string('-', i));
            temp -= 2;
        }
    }
}
