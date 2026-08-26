namespace ShapesLibrary;
public class Triangle
{
    public double Side1 {get; set;}
    public double Side2 {get; set;}
    public double Side3 {get; set;}
    public double CalculatePerimeter()
    {
        return Side1 + Side2 + Side3;
    }
}