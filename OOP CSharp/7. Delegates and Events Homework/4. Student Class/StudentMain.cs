using System;
using System.Collections.Generic;

class StudentMain
{
    static void Main()
    {
        Student s1 = new Student("Stoyan", 41);
        Console.WriteLine(s1);
        
        s1.studentChannge += (student, args) =>
            {
                if (args.OldAge != args.NewAge)
                    Console.WriteLine("Property changed: Age (from {0} to {1})", args.OldAge, args.NewAge);
                else
                    Console.WriteLine("Student has changed: Name (from {0} to {1})", args.OldName, args.NewName);
            };
        s1.Age = 25;
        Console.WriteLine(s1);
        s1.Name = "Ivan";
        Console.WriteLine(s1);
        s1.Name = "Gogo";
        Console.WriteLine(s1);
    }
}
