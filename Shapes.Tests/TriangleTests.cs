using Shapes;
using NUnit.Framework;

namespace Shapes.Tests;

[TestFixture]
public class TriangleTests
{
    [Test]
    public void ValidSides_ReturnsCorrectArea()
    {
        var triangle = new Triangle(4, 5, 6);
        Assert.That(triangle.CalculateArea(), Is.EqualTo(9.921567416492215));
    }
    
    [Test]
    public void WithInvalidSides_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            var triangle = new Triangle(1, 2, 3);
        });
    }
    
    [Test]
    public void WithZeroSide_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            var triangle = new Triangle(0, 5, 6);
        });
    }

    [Test]
    public void WithNegativeSide_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            var triangle = new Triangle(-2, 5, 6);
        });
    }

    [Test]
    public void RightTriangle_ReturnsTrue()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.That(triangle.IsTriangleRight(), Is.True);
    }
    
    [Test]
    public void NonRightTriangle_ReturnsFalse()
    {
        var triangle = new Triangle(3, 4, 6);
        Assert.That(triangle.IsTriangleRight(), Is.False);
    }
    
}