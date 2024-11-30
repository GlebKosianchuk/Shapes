using Shapes;
using NUnit.Framework;

namespace Shapes.Tests;

[TestFixture]
public class CircleTests
{
    [Test]
    public void ValidRadius_ReturnsCorrectArea()
    {
        var circle = new Circle(5);
        Assert.That(circle.CalculateArea(), Is.EqualTo(78.53981633974483));
    }

    [Test]
    public void ZeroRadius_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            var circle = new Circle(0);
        });
    }

    [Test]
    public void NegativeRadius_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            var circle = new Circle(-3);
        });
    }
}