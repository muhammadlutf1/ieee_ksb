// var shape = new Shape() {Name = "shape"}; // Error CS0144 : Cannot create an instance of the abstract type or interface 'Shape'

var c1 = new Circle(5) { Name = "c1"};
var c2 = new Circle(10) { Name = "c2" };
var c3 = new ColoredCircle(3) { Name = "c3", Color = "Red" };
var rec1 = new Rectangle(10, 5) { Name = "rec1"};
var rec2 = new Rectangle(20, 50) { Name = "rec2"};
var tri = new Triangle(10, 10, 5) { Name = "tri"};

var shapes = new List<Shape> {c1, c2, c3, rec1, rec2, tri};

double maxArea = 0;
double totalArea = 0;
foreach (var shape in shapes)
{
    var area = shape.CalculateArea();
    maxArea = Math.Max(maxArea, area);
    totalArea += area;
    
    shape.Display();
    Console.WriteLine();
}

Console.WriteLine($"Largest Area: {maxArea}\nArea Sum:{totalArea}");

public abstract class Shape
{
    public required string Name { get; set; }
    public abstract double CalculateArea();
    public abstract double CalculatePerimeter();

    public void Display()
    {
        Console.WriteLine($"Name: {Name};\nArea: {CalculateArea()};\nPerimeter: {CalculatePerimeter()}");
    }
}

public class Circle: Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }
    
    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}

public class Rectangle : Shape
{
    public double Length { get; set; }
    public double Width { get; set; }
    
    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    public override double CalculateArea()
    {
        return Length * Width;
    }

    public override double CalculatePerimeter()
    {
        return (Length + Width) * 2;
    }
}

public class Triangle : Shape
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    public Triangle(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public override double CalculateArea()
    {
        // Heron's Formula
        var s = CalculatePerimeter() / 2;
        return Math.Sqrt(s * (s - X) * (s - Y) * (s - Z));
    }

    public override double CalculatePerimeter()
    {
        return X + Y + Z;
    }
}

public abstract class ColoredShape : Shape
{
    public required string Color { get; set; }
}

public class ColoredCircle : ColoredShape
{
    public double Radius { get; set; }

    public ColoredCircle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}