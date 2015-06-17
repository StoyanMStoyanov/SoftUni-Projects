using System;
struct Fraction
{
    long numerator;
    long denumerator;

    public Fraction(long numerator, long denumerator)
        :this()

    {
        this.Numerator = numerator;
        this.Denumerator = denumerator;
    }

    public long Numerator
    {
        get
        {
            return this.numerator;
        }
        set
        {
            if (value < long.MinValue || value > long.MaxValue)
                throw new ArgumentOutOfRangeException("numerator", "Numerator is out of range." );
            this.numerator = value;
        }
    }
    public long Denumerator
    {
        get
        {
            return this.denumerator;
        }
        set
        {
            if (value < long.MinValue || value > long.MaxValue )
                throw new ArgumentOutOfRangeException("numerator", "Numerator is out of range.");
            if (value == 0)
                throw new ArgumentOutOfRangeException("denumerator", "Denumerator should be different from zero.");
            this.denumerator = value;
        }
    }

    public static Fraction operator +(Fraction x, Fraction y)
    {
        long a = x.Numerator;
        long b = x.Denumerator;
        long c = y.Numerator;
        long d = y.Denumerator;
        return new Fraction((a*d)+(b*c), b*d);
    }

    public static Fraction operator -(Fraction x, Fraction y)
    {
        long a = x.Numerator;
        long b = x.Denumerator;
        long c = y.Numerator;
        long d = y.Denumerator;
        return new Fraction((a * d) - (b * c), b * d);
    }

    public override string ToString()
    {
        return string.Format("{0}", (double)this.Numerator/this.Denumerator);
    }
}
