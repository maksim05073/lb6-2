namespace lb6_2;

public class Circle:Oval
{
    public double radius;
    public double Radius
    {
        get => radius;
        set
        {
            if (value < 0) throw new ArgumentException("Radius cannot be negative");
            radius = value;
        }
    }
}