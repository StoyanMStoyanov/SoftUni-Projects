class Circle:IShape
{
    public Circle(double radius)
    {
        this.Radius = radius;
    }

    public double Radius { get; set; }

    public double CalculatePerimeter()
    {
        return 2 * this.Radius * System.Math.PI;
    }
    public double CalculateArea()
    {
        return System.Math.PI * (this.Radius * 2);
    }
}
