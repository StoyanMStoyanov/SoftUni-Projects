using System;

class BookProblem
{
    static void Main()
    {
        int bookPages = int.Parse(Console.ReadLine());
        int cumpingDays = int.Parse(Console.ReadLine());
        int readPages = int.Parse(Console.ReadLine());

        
        int normalDays = 30 - cumpingDays;
        if (normalDays <= 0) Console.WriteLine("newer");
        else
        {
            int readNormalDays = normalDays * readPages;
            int neededMonths = bookPages / readNormalDays;
            int ostatak = bookPages % readNormalDays;
            

            double years = neededMonths / 12;
            double month = neededMonths - (years * 12);
            if (ostatak > 0) month++;
            //Console.WriteLine("need months {0}, years{1}, month{2}, Ostatak {3}", neededMonths, years, month, ostatak);
            
            Console.WriteLine();
            Console.WriteLine("{0} years {1} months", years, month);
        }
            
    }
}
