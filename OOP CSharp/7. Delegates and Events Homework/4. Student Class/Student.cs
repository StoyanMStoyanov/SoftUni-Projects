using System;

delegate void OnStudentChangeEventHandler(Student sender, StudentChangeEventArgs args);

public class Student
{
    internal event OnStudentChangeEventHandler studentChannge;
    private string name;
    private int age;

    public Student(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))            
                throw new ArgumentNullException("name", "Name cannot be empty");
            
            if (this.studentChannge != null)
                this.studentChannge(this, new StudentChangeEventArgs(this.Name, value));
            this.name = value;
        }
    }
    public int Age
    {
        get
        {
            return this.age;
        }
        set
        {
            if (value < 0 || 120 < value)            
                throw new ArgumentOutOfRangeException("age", "Age should be in the range [0 ... 120].");
            
            if (this.studentChannge != null)
                this.studentChannge(this, new StudentChangeEventArgs(this.Age, value));
            this.age = value;
        }
    }

    public override string ToString()
    {
        return string.Format("Name: {0}, Age: {1}", this.Name, this.Age);
    }
}
