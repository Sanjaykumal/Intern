class Circle
{
    public Circle(double r)
    {
        Radius = r;
    }

    protected double radius;
    
    public double GetArea() => Math.PI*radius*radius;
    public double GetPerimeter => 2*Math.PI*radius;
}