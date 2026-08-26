namespace ShapesLibrary;
public class Circle
{
    public double Radius {get; set;}
    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
    public double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}