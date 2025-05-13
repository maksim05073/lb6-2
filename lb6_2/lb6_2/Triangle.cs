namespace lb6_2;

public class Triangle:GeometricFigure
{
    public double a;
    public double b;
    public double c;
    public double A
    {
        get => a;
        set
        {
            if (value < 0) throw new ArgumentException("The side cannot be less zero");
            a = value;
        }
    }
    public double B
    {
        get => b;
        set
        {
            if (value < 0) throw new ArgumentException("The side cannot be less zero");
            b = value;
        }
    }
    public double C
    {
        get => c;
        set
        {
            if (value < 0) throw new ArgumentException("The side cannot be less zero");
            c = value;
        }
    }
}