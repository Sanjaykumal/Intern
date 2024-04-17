class Triangle
{
    public double SideA;
    public double SideB;
    public double SideC;

    public Triangle(double sideA, double sideB, double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }
    double s = (SideA + SideB + SideC) / 2;
    public double GetArea() => Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));

    public double GetPerimeter() => SideA + SideB + SideC;
    
}
    