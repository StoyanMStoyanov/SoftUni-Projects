using System;
using System.Text;

class GameOfBits
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        StringBuilder sb = new StringBuilder();
        int count = 0;
        while (true)
        {
            string command = Console.ReadLine();
            if (command == "Game Over!") break;
            if (command == "Odd")
            {
                for (int p = 30; p >= 0; p -= 2)
                {
                    if ((number & (1 << p)) != 0) sb.Append(1);
                    else sb.Append(0);
                }
                number = Convert.ToInt32(sb.ToString(), 2);
                //sb.Clear();
            }
            else
            {
                for (int p = 31; p >= 0; p -= 2)
                {
                    if ((number & (1 << p)) != 0) sb.Append(1);
                    else sb.Append(0);
                }
                number = Convert.ToInt32(sb.ToString(), 2);
                //sb.Clear(); 
            }
            //Console.WriteLine("{0}      {1}", sb, Convert.ToInt32(sb.ToString(), 2));
            sb.Clear();
        }
        for (int p = 0; p < 32; p++)
        {
            if ((number & (1 << p)) != 0) count++;            
        }        
        Console.WriteLine("{0} -> {1}", number, count);
    }
}
