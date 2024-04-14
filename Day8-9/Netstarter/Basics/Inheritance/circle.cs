using system;
namespace Inhertance;
class Circle : IShape2D
{
    public Circle(double r)
    {
        Radius = r;
    }

    protected double radius;
    
    public virtual double GetArea() => Math.PI*radius*radius;
    public virtual double GetPerimeter => 2*Math.PI*radius;
}