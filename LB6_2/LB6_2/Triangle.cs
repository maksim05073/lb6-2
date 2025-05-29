namespace LB6_2;

public class Triangle : GeometricFigure
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }

    public Triangle(double a, double b, double c):base("Triangle")
    {
        A = a;
        B = b;
        C = c;
    }

    public override double CalculateArea()
    {
        double s = (A + B + C) / 2;
        return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
    }

    public override double CalculatePerimeter()
    {
        return A + B + C;
    }
    public override string ToString()
    {
        return $"Area: {Math.Round(CalculateArea(),2)}\nPerimeter: {Math.Round(CalculatePerimeter(),2)}";
    }
}