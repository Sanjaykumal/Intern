﻿//top level statement
//Student s1 = new();
//Student s2 = new();
//Student s3 = new();
//Student s4 = new();
//Student s5 = new();
//Student s6 = new();

//s1.name = "Bishnu";
//s1.address= "Ktm";
//s1.roll = 23;
//s1.dob = new DateTime(1990, 12, 12);





//s1.PrintDetails();

//create  class called "animals "
//define atleast 5 internal fields
//define a method to print al details of animals in descriptive fornmat
//in program entry points create atleats two objects of animals
//initialize the fields for each instance
//print details in console



//Animal a1 = new();



//a1.genus = "Oryctolagus";
//a1.species = "caniculus";
//a1.lifespan = 12;
//a1.height = 50;
//a1.habitat = "Terrestial";

//a1.PrintDetails();

Rectangle rectangle = new Rectangle(5, 7);

double area = rectangle.CalculateArea();
    double perimeter = rectangle.CalculatePerimeter();

 Console.WriteLine("Area of the rectangle: " + area);
        Console.WriteLine("Perimeter of the rectangle: " + perimeter);


 Square square = new Square(5);
        double squareArea = square.CalculateArea();
        double squarePerimeter = square.CalculatePerimeter();
        Console.WriteLine("Area of the square: " + squareArea);
        Console.WriteLine("Perimeter of the square: " + squarePerimeter);



Circle circle = new Circle(10);
        double circleArea = circle.CalculateArea();
        double circlePerimeter = circle.CalculatePerimeter();
        Console.WriteLine("Area of the circle: " + circleArea);
        Console.WriteLine("Perimeter of the circle (circumference): " + circlePerimeter);
    

    Triangle triangle = new Triangle(3, 4, 5);
    double triangleArea = triangle.CalculateArea();
        double trianglePerimeter = triangle.CalculatePerimeter();
          Console.WriteLine("Area of the triangle: " + triangleArea);
        Console.WriteLine("Perimeter of the triangle: " + trianglePerimeter);



        var fileio = new FileIO();
        fileio.CreateFile();