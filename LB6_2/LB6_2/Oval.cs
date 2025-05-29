namespace LB6_2;

public class Oval : GeometricFigure
{
    public double MajorAxis { get; set; }
    public double MinorAxis { get; set; }

    public Oval(double major, double minor) : base("Oval")
    {
        MajorAxis = major;
        MinorAxis = minor;
    }

    public override double CalculateArea()
    {
        return Math.PI * MajorAxis * MinorAxis;
    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * Math.Sqrt((Math.Pow(MajorAxis, 2) + Math.Pow(MinorAxis, 2)) / 2);
    }
    
    public override string ToString()
    {
        return $"Area: {Math.Round(CalculateArea(),2)}\nPerimeter: {Math.Round(CalculatePerimeter(),2)}";
    }
}