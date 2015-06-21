using System;
class StudentChangeEventArgs:EventArgs
{
    public StudentChangeEventArgs(string oldName, string newName)
    {
        this.OldName = oldName;
        this.NewName = newName;
    }
    public StudentChangeEventArgs(int oldAge, int newAge)
    {
        this.OldAge = oldAge;
        this.NewAge = newAge;
    }
    public string OldName { get; set; }
    public string NewName { get; set; }
    public int OldAge { get; set; }
    public int NewAge { get; set; }

}
