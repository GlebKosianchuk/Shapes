using System.Linq;

namespace Shapes;

public class Triangle : IShape
{
    private double A { get; }
    private double B { get; }
    private double C { get; }

    public Triangle(double a, double b, double c)
    {
        if (a + b <= c || a + c <= b || b + c <= a)
            throw new ArgumentException("A triangle with such sides does not exist.");
        if (a <= 0 || b <= 0 || c <= 0 )
            throw new ArgumentException("All sides of the triangle must be positive numbers.");
        A = a;
        B = b;
        C = c;
    }

    public double CalculateArea()
    {
        var p = (A + B + C) / 2;
        return Math.Sqrt(p * (p - A) * (p - B) * (p - C)); 
    }

    public bool IsTriangleRight()
    {
        var sortedSides = new[] { A, B, C }.OrderBy(side => side).ToArray();
        return Math.Pow(sortedSides[0], 2) + Math.Pow(sortedSides[1], 2) == Math.Pow(sortedSides[2], 2); 
    }
}
