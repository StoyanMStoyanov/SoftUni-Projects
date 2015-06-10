using System;
using System.Collections.Generic;
using System.Linq;

class HumanStudentWorkerMain
{
    static void Main()
    {
        Student[] students = {
                                 new Student("Stoyan","Stoyanov",1),
                                 new Student("Ivan","Ivanov",21),
                                 new Student("Nikolay","Nikolov",5),
                                 new Student("George","Vasilev",30),
                                 new Student("John","Ivanov",8),
                                 new Student("Vasil","Nikolov",16),
                                 new Student("Violeta","Guineva",9),
                                 new Student("Mariika","Ivanova",32),
                                 new Student("Nadejda","Stoyanova",17),
                                 new Student("Slavcho","Vasilev",42)
                             };
        var studentsOrdered = students.OrderByDescending(s => s.FacultyNumber);
        foreach (var student in studentsOrdered)        
            Console.WriteLine(student);

        Worker[] workers = {
                                 new Worker("Stoyan","Stoyanov",250, 8),
                                 new Worker("Ivan","Ivanov",180, 7),
                                 new Worker("Nikolay","Nikolov",300, 8),
                                 new Worker("George","Vasilev",220, 7),
                                 new Worker("John","Ivanov",150,6),
                                 new Worker("Vasil","Nikolov",160, 7),
                                 new Worker("Violeta","Guineva",400, 10),
                                 new Worker("Mariika","Ivanova",320, 8),
                                 new Worker("Nadejda","Stoyanova",170, 7),
                                 new Worker("Slavcho","Vasilev",420, 9)
                             };
        var workerOrdered = workers.OrderByDescending(w => w.MoneyPerHour());
        Console.WriteLine("\nWorkers - Salary by hours:");
        foreach (var worker in workerOrdered)
            Console.WriteLine("{0:f2}lv  - {1}", worker.MoneyPerHour(), worker);
    }
}
