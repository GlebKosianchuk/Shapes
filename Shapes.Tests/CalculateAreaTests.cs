using Shapes;
using NUnit.Framework;

namespace Shapes.Tests;

[TestFixture]
public class CalculateAreaTests
{
    [Test]
    public void CalculateArea_ForArrayOfShapes_ReturnsCorrectAreas()
    {
        IShape[] shapes = new IShape[]
        {
            new Circle(5),
            new Triangle(3, 4, 5),
        };

        double[] expectedAreas = new double[]
        {   
            78.53981633974483, 
            6,
        };
            
        for (var i = 0; i < shapes.Length; i++)
        {
            Assert.That(shapes[i].CalculateArea(), Is.EqualTo(expectedAreas[i]));
        }
    }
}