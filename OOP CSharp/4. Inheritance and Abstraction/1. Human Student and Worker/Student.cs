using System;
using System.Collections.Generic;

class Student:Human
{
    //Fields
    private int facultyNumber;

    //Constructors
    public Student(string firstName, string lastName, int facNumber)
        :base(firstName, lastName)
    {
        this.FacultyNumber = facNumber;
    }
    //Properties
    public int FacultyNumber
    {
        get
        {
            return this.facultyNumber;
        }
        private set
        {
            if (value <= 0)
                throw new ArgumentException("Faculty number", "The faculty number should be greater than zeto.");
            this.facultyNumber = value;
        }
    }

    //Methods
    public override string ToString()
    {
        return this.FacultyNumber + " " + base.ToString();
    }
}
