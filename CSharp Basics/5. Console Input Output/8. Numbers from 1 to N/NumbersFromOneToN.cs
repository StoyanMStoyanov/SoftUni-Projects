using System;

class NumbersFromOneToN
{
    static void Main()
    {        
        int number = 0;
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Enter 0 for quit.");
            Console.Write("Enter integer number 0<N<=100: ");
            if (int.TryParse(Console.ReadLine(), out number))
            {
                if(number == 0) break;
                if (number < 1 || number > 100) continue;
                for (int i = 1; i <= number; i++)
                    Console.WriteLine(i);
            }
            else
                Console.WriteLine("Incorrect value.");
            Console.WriteLine("Press Enter.");
            Console.ReadLine();            
        }
       
    }
}
