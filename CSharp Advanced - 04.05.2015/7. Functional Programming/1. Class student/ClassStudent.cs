﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;
using Students;


    class ClassStudent
    {
        static void Main()
        {
            StreamReader reader = new StreamReader("../../Students-data.txt");
            List<Student> students = new List<Student>();
            using (reader)
            {
                string line = reader.ReadLine();
                line = reader.ReadLine();
                while (line != null)
                {

                    AddStudentInCollection(line, students);
                    line = reader.ReadLine();
                }
            }
            //------------------------------------------------------------------------
            Console.WriteLine("Print students from group2:");
            var arr = students.Where(s => s.GroupNumber == 2).
                OrderBy(s => s.FirstName).
                Select(s => s);
            Console.WriteLine(" FN Full name ");
            foreach (var item in arr)
            {
                Console.WriteLine("{0,3} {1} {2}",
                    item.FacultyNumber,
                    item.FirstName,
                    item.LastName
                    );
            }
            Console.WriteLine(new string('-', 50));
            //------------------------------------------------------------------------
            Console.WriteLine("Print students by age.");
            var ageStudents =
                from s in students
                where s.Age >= 18 && s.Age <= 24
                orderby s.Age
                select s;
            Console.WriteLine("Age Full name");
            foreach (var item in ageStudents)
            {
                Console.WriteLine("{0,3} {1} {2}",
                    item.Age,
                    item.FirstName,
                    item.LastName
                    );
            }
            Console.WriteLine(new string('-', 50));
            //------------------------------------------------------------------------
            Console.WriteLine("Sort students");
            Console.WriteLine(" FN Full Name");
            var sortedStudents = students.OrderBy(s => s.FirstName).ThenBy(s => s.LastName);
            foreach (var item in sortedStudents)
            {
                Console.WriteLine("{0,3} {1} {2}",
                    item.FacultyNumber,
                    item.FirstName,
                    item.LastName);
            }
            Console.WriteLine(new string('-', 50));
            var sortStudents =
                from s in students
                orderby s.FirstName
                orderby s.LastName
                select s;
            Console.WriteLine(" FN Full Name");
            foreach (var item in sortedStudents)
            {
                Console.WriteLine("{0,3} {1} {2}",
                    item.FacultyNumber,
                    item.FirstName,
                    item.LastName);
            }
            Console.WriteLine(new string('-', 50));
            //------------------------------------------------------------------------
            Console.WriteLine("Print students with email domain: abv.bg.");
            var studentsEmail = from s in students
                                where s.Email.Contains("@abv.bg")
                                select s;
            Console.WriteLine(" FN Full Student Name");
            foreach (var item in studentsEmail)
            {
                Console.WriteLine("{0,3} {1} {2} Email: {3}",
                    item.FacultyNumber,
                    item.FirstName,
                    item.LastName,
                    item.Email);
            }
            Console.WriteLine(new string('-', 50));
            //------------------------------------------------------------------------
            Console.WriteLine("Print students with phone in Sofia.");
            var studentsPhones = from s in students
                                where PhoneValidate(s.Phone)                                
                                select s;
            Console.WriteLine(" FN Full Student Name");
            foreach (var item in studentsPhones)
            {
                Console.WriteLine("{0,3} {1} {2} Phone: {3}",
                    item.FacultyNumber,
                    item.FirstName,
                    item.LastName,
                    item.Phone);
            }
        }

        private static bool PhoneValidate(string phone)
        {
            string pattern = @"(\+359/2)|(\+3592)|(02)";
            return Regex.IsMatch(phone, pattern);
        }
        private static void PrintStudents(List<Student> temp)
        {
            for (int i = 0; i < temp.Count; i++)
            {
                Console.WriteLine("{0,3} {1,8} {2,8} Age: {3,2} Email: {4} Group number: {5,3}",
                    temp[i].FacultyNumber,
                    temp[i].FirstName,
                    temp[i].LastName,
                    temp[i].Age,
                    temp[i].Email,
                    temp[i].GroupNumber);
            }
        }

        private static void AddStudentInCollection(string line, List<Student> students)
        {
            string[] split = Regex.Split(line, @"\s+");
            Student temp = new Student(int.Parse(split[0]),
                split[1], split[2], int.Parse(split[7]),
                int.Parse(split[9]), split[6], split[3], 5, int.Parse(split[8]));
            students.Add(temp);
        }
    }
