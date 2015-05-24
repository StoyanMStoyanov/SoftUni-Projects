using System;
using System.Collections.Generic;

class Student
{
    //Fields
    private int id = 0;
    private string firstName = string.Empty;
    private string lastName = string.Empty;
    private int age = 0;
    private int facultyNumber = 0;
    private string phone = string.Empty;
    private string email = string.Empty;
    private List<int> marks;
    private int groupNumber = 0;

    //Constructors
    public Student(
        int id,
        string firstName,
        string lastName,
        int age,
        int facultyNumber,
        string phone,
        string email,
        int mark,
        int groupNumber)
    {
        ID = id;
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        FacultyNumber = facultyNumber;
        Phone = phone;
        Email = email;
        Mark = mark;
        GroupNumber = groupNumber;
    }
    //Properties
    public int ID
    {
        get { return id; }
        private set { id = value; }
    }
    public string FirstName
    {
        get { return firstName; }
        private set { firstName = value; }
    }
    public string LastName
    {
        get { return lastName; }
        private set { lastName = value; }
    }
    public int Age
    {
        get { return age; }
        private set { age = value; }
    }
    public int FacultyNumber
    {
        get { return facultyNumber; }
        private set { facultyNumber = value; }
    }
    public string Phone {
        get { return phone; }
        set { phone = value; }
    }
    public string Email
    {
        get { return email; }
        set { email = value; }
    }
    public int Mark
    {        
        set {
            if (marks == null)
            {
                marks = new List<int>();
                marks.Add(value);
            }
            else
            {
                marks.Add(value);
            }
        }
    }
    public List<int> Marks
    {
        get { return marks; }
    }

    public int GroupNumber
    {
        get { return groupNumber; }
        set { groupNumber = value; }
    }
    

}

