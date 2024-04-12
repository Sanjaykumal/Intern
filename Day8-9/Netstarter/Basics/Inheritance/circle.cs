class Circle
{
 public Circle (double r)
 {
    radius = r;
 }
 double radius;

 public double GetArea=>Math.PI*r*r;
 public double GetPerimeter=>2*Math.PI*radius;
}