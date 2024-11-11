using System;
interface I2DShape
{
    double CalculateArea();
}
interface I3DShape
{
    double CalculateSurfaceArea();
}
class Square : I2DShape
{
    private double side;
    public Square(double side)
    {
        this.side = side;
    }
    public double CalculateArea()
    {
        return side * side;
    }
}
class Rectangle : I2DShape
{
    private double length, width;
    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }
    public double CalculateArea()
    {
        return length * width;
    }  }

class Rhombus : I2DShape
{
    private double diagonal1, diagonal2;
    public Rhombus(double diagonal1, double diagonal2)
    {
        this.diagonal1 = diagonal1;
        this.diagonal2 = diagonal2;
    }
    public double CalculateArea()
    {
        return 0.5 * diagonal1 * diagonal2;
    }
}
class Trapezium : I2DShape
{
    private double base1, base2, height;
    public Trapezium(double base1, double base2, double height)
    {
        this.base1 = base1;
        this.base2 = base2;
        this.height = height;
    }
    public double CalculateArea()
    {
        return 0.5 * (base1 + base2) * height;
    }
}
class Parallelogram : I2DShape
{
    private double baseLength, height;
    public Parallelogram(double baseLength, double height)
    {
        this.baseLength = baseLength;
        this.height = height;
        
    }
    public double CalculateArea()
    {
        return baseLength * height;
    }
}
class Triangle : I2DShape
{
    private double baseLength, height;
    public Triangle(double baseLength, double height)
    {
        this.baseLength = baseLength;
        this.height = height;
    }
    public double CalculateArea()
    {
        return 0.5 * baseLength * height;
    }
}
class Circle : I2DShape
{
    private double radius;
    public Circle(double radius)
    {
        this.radius = radius;
    }
    public double CalculateArea()
    {
        return Math.PI * radius * radius;
    }
}
class Sphere : I3DShape
{
    private double radius;

public Sphere(double radius)
    {
        this.radius = radius;
    }
    public double CalculateSurfaceArea()
    {
        return 4 * Math.PI * radius * radius;
    }
}
class Cube : I3DShape
{
    private double side;
    public Cube(double side)
    {
        this.side = side;
    }
    public double CalculateSurfaceArea()
    {
        return 6 * side * side;
    }
}
class Cuboid : I3DShape
{
    private double length, width, height;
    public Cuboid(double length, double width, double height)
    {
        this.length = length;
        this.width = width;
        this.height = height;
    }
    public double CalculateSurfaceArea()
    {
        return 2 * (length * width + length * height + width * height);
    }

}
class Cylinder : I3DShape
{
    private double radius, height;
    public Cylinder(double radius, double height)
    {
        this.radius = radius;
        this.height = height;
    }
    public double CalculateSurfaceArea()
    {
        return 2 * Math.PI * radius * (radius + height);
    }
}
class Cone : I3DShape
{
    private double radius, height;
    public Cone(double radius, double height)
    {
        this.radius = radius;
        this.height = height;
    }
    public double CalculateSurfaceArea()
    {
        return Math.PI * radius * (radius + Math.Sqrt(radius * radius + height * height));
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Shape Area Calculator!");
        Console.WriteLine("Please select the type of shape:");
        Console.WriteLine("1. 2D Shape");
        
    Console.WriteLine("2. 3D Shape");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1: // 2D Shapes
                Console.WriteLine("Please select the 2D shape:");
                Console.WriteLine("1. Square");
                Console.WriteLine("2. Rectangle");
                Console.WriteLine("3. Rhombus");
                Console.WriteLine("4. Trapezium");
                Console.WriteLine("5. Parallelogram");
                Console.WriteLine("6. Triangle");
                Console.WriteLine("7. Circle");
                int shape2DChoice = Convert.ToInt32(Console.ReadLine());
                switch (shape2DChoice)
                {
                    case 1: // Square
                        Console.Write("Enter the side length: ");
                        double side = Convert.ToDouble(Console.ReadLine());
                        I2DShape square = new Square(side);
                        Console.WriteLine($"The area of the square is: {square.CalculateArea()}");
                        break;
                    case 2: // Rectangle
                        Console.Write("Enter the length: ");
                        double length = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the width: ");
                        double width = Convert.ToDouble(Console.ReadLine());
                        I2DShape rectangle = new Rectangle(length, width);
                        Console.WriteLine($"The area of the rectangle is: {rectangle.CalculateArea()}");
                        break;
                    case 3: // Rhombus
                        Console.Write("Enter the diagonal 1: ");
                        double diagonal1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the diagonal 2: ");
                        
                double diagonal2 = Convert.ToDouble(Console.ReadLine());
                        I2DShape rhombus = new Rhombus(diagonal1, diagonal2);
                        Console.WriteLine($"The area of the rhombus is: {rhombus.CalculateArea()}");
                        break;
                    case 4: // Trapezium
                        Console.Write("Enter the length of base1: ");
                        double base1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the length of base2: ");
                        double base2 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the height: ");
                        double height = Convert.ToDouble(Console.ReadLine());
                        I2DShape trapezium = new Trapezium(base1, base2, height);
                        Console.WriteLine($"The area of the trapezium is: {trapezium.CalculateArea()}");
                        break;
                    case 5: // Parallelogram
                        Console.Write("Enter the base length: ");
                        double baseLength = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the height: ");
                        double height2 = Convert.ToDouble(Console.ReadLine());
                        I2DShape parallelogram = new Parallelogram(baseLength, height2);
                        Console.WriteLine($"The area of the parallelogram is: {parallelogram.CalculateArea()}");
                        break;
                    case 6: // Triangle
                        Console.Write("Enter the base length: ");
                        double baseLength2 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the height: ");
                        double height3 = Convert.ToDouble(Console.ReadLine());
                        I2DShape triangle = new Triangle(baseLength2, height3);
                        Console.WriteLine($"The area of the triangle is: {triangle.CalculateArea()}");
                        break;
                    case 7: // Circle
                        Console.Write("Enter the radius of the circle: ");
                        double radius = Convert.ToDouble(Console.ReadLine());
                        I2DShape circle = new Circle(radius);
                        
                Console.WriteLine($"The area of the circle is: {circle.CalculateArea()}");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
                break;
            case 2: // 3D Shapes
                Console.WriteLine("Please select the 3D shape:");
                Console.WriteLine("1. Sphere");
                Console.WriteLine("2. Cube");
                Console.WriteLine("3. Cuboid");
                Console.WriteLine("4. Cylinder");
                Console.WriteLine("5. Cone");
                int shape3DChoice = Convert.ToInt32(Console.ReadLine());
                switch (shape3DChoice)
                {
                    case 1: // Sphere
                        Console.Write("Enter the radius of the sphere: ");
                        double radius = Convert.ToDouble(Console.ReadLine());
                        I3DShape sphere = new Sphere(radius);
                        Console.WriteLine($"The surface area of the sphere is: {sphere.CalculateSurfaceArea()}");
                        break;
                    case 2: // Cube
                        Console.Write("Enter the side length of the cube: ");
                        double cubeSide = Convert.ToDouble(Console.ReadLine());
                        I3DShape cube = new Cube(cubeSide);
                        Console.WriteLine($"The surface area of the cube is: {cube.CalculateSurfaceArea()}");
                        break;
                    case 3: // Cuboid
                        Console.Write("Enter the length: ");
                        double length = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the width: ");
                        double width = Convert.ToDouble(Console.ReadLine());
                        
                Console.Write("Enter the height: ");
                        double height = Convert.ToDouble(Console.ReadLine());
                        I3DShape cuboid = new Cuboid(length, width, height);
                        Console.WriteLine($"The surface area of the cuboid is: {cuboid.CalculateSurfaceArea()}");
                        break;
                    case 4: // Cylinder
                        Console.Write("Enter the radius of the cylinder: ");
                        double radiusCylinder = double.Parse(Console.ReadLine());
                        Console.Write("Enter the height of the cylinder: ");
                        double heightCylinder = double.Parse(Console.ReadLine());
                        I3DShape cylinder = new Cylinder(radiusCylinder, heightCylinder);
                        Console.WriteLine($"The surface area of the cylinder is: {cylinder.CalculateSurfaceArea()}");
                        break;
                    case 5: // Cone
                        Console.Write("Enter the radius of the cone: ");
                        double radiusCone = double.Parse(Console.ReadLine());
                        Console.Write("Enter the height of the cone: ");
                        double heightCone = double.Parse(Console.ReadLine());
                        I3DShape cone = new Cone(radiusCone, heightCone);
                        Console.WriteLine($"The surface area of the cone is: {cone.CalculateSurfaceArea()}");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }
}