using System;
using System.Collections;

class StringDisperser
{
    public StringDisperser(string first, string second, string third)
    {
        this.First = first;
        this.Second = second;
        this.Third = third;
    }

    public string First { get; set; }
    public string Second { get; set; }
    public string Third { get; set; }

    public override bool Equals(object obj)
    {
        StringDisperser dispenser = obj as StringDisperser;
        if (dispenser == null) return false;

        if (!Object.Equals(this.First, dispenser.First)
            || Object.Equals(this.Second, dispenser.Second)
            || Object.Equals(this.Third, dispenser.Third))
            return false;

        return true;
    }

    public override int GetHashCode()
    {
        return this.First.GetHashCode() ^ this.Second.GetHashCode() ^ this.Third.GetHashCode();
    }

    public override string ToString()
    {
        return this.First + this.Second + this.Third;
    }

    public static bool operator ==(StringDisperser first, StringDisperser second)
    {
        return StringDisperser.Equals(first, second);
    }

    public static bool operator !=(StringDisperser first, StringDisperser second)
    {
        return !StringDisperser.Equals(first, second);
    }

}
