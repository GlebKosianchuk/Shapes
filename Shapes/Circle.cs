namespace Shapes;

public class Circle : IShape
{
    private double Radius { get; }

    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Radius must be greater than 0");
        Radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius; 
    }
}