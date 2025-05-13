namespace lb6_2;

public class GeometricFigure:Circle
{
    public int numberofangles;
    public int Numberofangles
    {
        get => numberofangles;
        set
        {
            if (value <=2 ) throw new ArgumentException("The geometric figure may not be less than 3 angles");
            numberofangles = value;
        }
    }
}