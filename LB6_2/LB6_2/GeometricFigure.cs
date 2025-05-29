namespace LB6_2;

public abstract class GeometricFigure
{
    public string Name { get; set; }

    public GeometricFigure(string name)
    {
        Name = name;
    }
    
    public abstract double CalculateArea();
    public abstract double CalculatePerimeter();
}