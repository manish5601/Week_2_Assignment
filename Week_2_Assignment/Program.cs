//Task-1
//public class Program
//{
//    public static void Main()
//    {
//        string userName = "Alex";
//        int luckyNumber = 7;
//        System.Console.WriteLine($"Hello, {userName}! Your lucky number is {luckyNumber}.");
//    }
//}

//Task-2

//public class Circle
//{
//    public const double PI = 3.14;

//    public double CalculateArea(double radius)
//    {
//        return PI * radius * radius;
//    }

//    public double CalculatePerimeter(double radius)
//    {
//        return 2 * PI * radius;
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        // This line will cause a compilation error:
//        // Circle.PI = 3.14159;

//        // Error explanation:
//        // The field 'Circle.PI' is a constant and cannot be assigned to.
//        // Constants are immutable and their value cannot be changed after declaration.

//        Circle circle = new Circle();
//        double area = circle.CalculateArea(5);
//        double perimeter = circle.CalculatePerimeter(5);

//        System.Console.WriteLine($"Area: {area}");
//        System.Console.WriteLine($"Perimeter: {perimeter}");
//    }
//}

//Task- 3
public class Program
{
    public static void Main()
    {
        byte b = 255;
        short s = -32768;
        int i = 2147483647;
        long l = 9223372036854775807L;
        float f = 3.402823E+38f;
        double d = 1.7976931348623157E+308;
        decimal m = 79228162514264337593543950335m;
        char c = 'A';
        bool flag = true;

        string intToString = 42.ToString();
        double stringToDouble = double.Parse("3.14");

        System.Console.WriteLine($"byte: {b}");
        System.Console.WriteLine($"short: {s}");
        System.Console.WriteLine($"int: {i}");
        System.Console.WriteLine($"long: {l}");
        System.Console.WriteLine($"float: {f}");
        System.Console.WriteLine($"double: {d}");
        System.Console.WriteLine($"decimal: {m}");
        System.Console.WriteLine($"char: {c}");
        System.Console.WriteLine($"bool: {flag}");
        System.Console.WriteLine($"int 42 to string: {intToString}");
        System.Console.WriteLine($"string \"3.14\" to double: {stringToDouble}");
    }
}

//Task-6

//class Program
//{
//    static void Main()
//    {


//        List<string> fruits = new List<string> { "Apple", "Banana", "Mango" };

//        fruits.Add("Orange");

//        fruits.Remove("Banana");

//        Console.WriteLine("Fruits in List:");
//        foreach (string fruit in fruits)
//        {
//            Console.WriteLine(fruit);
//        }

//        Dictionary<int, string> fruitDict = new Dictionary<int, string>
//        {
//            { 1, "Apple" },
//            { 2, "Mango" },
//            { 3, "Orange" }
//        };

//        fruitDict.Add(4, "Grape");

//        Console.WriteLine("\nFruit Dictionary:");
//        foreach (var pair in fruitDict)
//        {
//            Console.WriteLine($"ID: {pair.Key}, Name: {pair.Value}");
//        }

//    }
//}