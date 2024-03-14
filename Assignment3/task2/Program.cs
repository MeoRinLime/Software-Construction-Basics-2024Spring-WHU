using System;

public abstract class Shape
{
    public abstract double CalculateArea();
}

public class Circle : Shape
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
}

public class Square : Shape
{
    private double side;

    public Square(double side)
    {
        this.side = side;
    }

    public override double CalculateArea()
    {
        return side * side;
    }
}

public class Rectangle : Shape
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
}

public static class ShapeFactory
{
    //随机创建对象，创建随机形状，同时对应形状的属性也是随机的
    private static Random random = new Random();

    public static Shape CreateRandomShape()
    {
        switch (random.Next(3))
        {
            case 0:
                double radius = random.Next(1, 10);
                Console.WriteLine($"创建了一个圆形,半径为{radius}");
                return new Circle(radius);
            case 1:
                double side = random.Next(1, 10);
                Console.WriteLine($"创建了一个正方形,边长为{side}");
                return new Square(side);
            case 2:
                double length = random.Next(1, 10);
                double width = random.Next(1, 10);
                Console.WriteLine($"创建了一个矩形,长为{length},宽为{width}");
                return new Rectangle(length, width);
            default:
                throw new InvalidOperationException("Invalid shape type");
        }
    }
}

public class Program
{
    public static void Main()
    {
        double totalArea = 0;
        for (int i = 0; i < 10; i++)
        {
            Shape shape = ShapeFactory.CreateRandomShape();
            totalArea += shape.CalculateArea();
        }

        Console.WriteLine($"The total area of the 10 shapes is: {totalArea}");
    }
}
