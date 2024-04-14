//Write console application to calculate area and perimeter of different 2D shapes
namespace Inhertance;
class Rectangle : IShape2D
{
     //Default parameter constructor
     //public rectangle()
     {

     }

    //Parameterized constructor

    public Rectangle(double l, double w)
    {
        length = l;
        width = w;
    }

    double length;
    double width;

    public double GetArea() => length * width;
    public double GetPerimeter() => 2 * (length + width);
}

