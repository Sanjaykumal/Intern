//top level statement
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

using System;
using Inheritance;

var rec1 = new Rectangle(5.7, 3.4);
var p = rec1.GetPerimeter();

var rec2 = new Rectangle(123.23, 34.3);
var a = rec2.GetArea();

var square1 = new Square(34.5);
var sa = square1.GetArea();

var circle1 = new Circle(34.5);
var ca = circle1.GetArea();

var sphere1 = new Sphere(34.5);
var ssa = sphere1.GetArea();
sphere1.PrintSphereInfo(34.5);

var fileio = new FileIO();
fileio.CreateFileWithInFolder();

Console.WriteLine("abcdefghij");