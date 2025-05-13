namespace lb6_2;

public class Oval
{
    public string namefigure;
    public double area;
    public string NameFigure
    {
        get => namefigure;
        set => namefigure = value;
    }
    public double Area
    {
        get => area;
        set
        {
            if (value < 0) throw new ArgumentException("The area cannot be less zero");
            area = value;
        }
    }
    
}