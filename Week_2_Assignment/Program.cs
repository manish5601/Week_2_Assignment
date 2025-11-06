using System;

class Circle
{
    public const double PI = 3.14;

    // Method to calculate area of the circle
    public double CalculateArea(double radius)
    {
        return PI * radius * radius;
    }

    // Method to calculate perimeter of the circle
    public double CalculatePerimeter(double radius)
    {
        return 2 * PI * radius;
    }
}

class Program
{
    static void Main()
    {
        Circle circle = new Circle();

        double radius = 5.0;
        Console.WriteLine($"Area of circle with radius {radius}: {circle.CalculateArea(radius)}");
        Console.WriteLine($"Perimeter of circle with radius {radius}: {circle.CalculatePerimeter(radius)}");
    }
}