using System.Security.Principal;
using System;

abstract class Shape
{
    public abstract double CalculateArea();
    public abstract bool Validate();
}

class Rectangle : Shape
{
    private double length;
    private double width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public override double CalculateArea()
    {
        return length * width;
    }

    public void PrintArea()
    {
        Console.WriteLine("Area: " + CalculateArea());
    }

    public override bool Validate()
    {
        return length > 0 && width > 0;
    }
}   

class Square : Rectangle
{
    public Square(double side) : base(side, side) {}

}

class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * radius * radius;
    }

    public void PrintArea()
    {
        Console.WriteLine("Area: " + CalculateArea());
    }

    public override bool Validate()
    {
        return radius > 0;
    }
}

class Triangle : Shape
{
    private double side1;
    private double side2;
    private double side3;

    public Triangle(double side1, double side2, double side3)
    {
        this.side1 = side1;
        this.side2 = side2;
        this.side3 = side3;
    }

    public override double CalculateArea()
    {
        double s = (side1 + side2 + side3) / 2;
        return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
    }

    public override bool Validate()
    {
        return side1 > 0 && side2 > 0 && side3 > 0;
    }

    public void PrintArea()
    {
        Console.WriteLine("Area: " + CalculateArea());
    }
}

class Test
{
    public static void Main()
    {
        Rectangle rectangle1 = new Rectangle(5, 10);
        Triangle triangle1 = new Triangle(3, 4, 5);
        Circle circle1 = new Circle(5);
        Square square1 = new Square(5);

        rectangle1.PrintArea();
        triangle1.PrintArea();
        circle1.PrintArea();
        square1.PrintArea();

    }
}
