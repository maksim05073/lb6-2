namespace LB6_2;

public class Circle : GeometricFigure
{
    public double Radius { get; set; }

    public Circle(double radius):base("Circle")
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }
    public override string ToString()
    {
        return $"Area: {Math.Round(CalculateArea(),2)}\nPerimeter: {Math.Round(CalculatePerimeter(),2)}";
    }
}