
class Program
{
    static void Main()
    {
        byte b = 100;
        short s = -5000;
        int i = 123456;
        long l = 9876543210L;
        float f = 2.718f;
        double d = 3.1415926535;
        decimal m = 12345.6789m;
        char c = 'X';
        bool flag = false;

        string intToStr = 42.ToString();
        double strToDouble = double.Parse("3.14");

        Console.WriteLine($"byte:   {b}   (Type: {b.GetType()})");
        Console.WriteLine($"short:  {s}   (Type: {s.GetType()})");
        Console.WriteLine($"int:    {i}   (Type: {i.GetType()})");
        Console.WriteLine($"long:   {l}   (Type: {l.GetType()})");
        Console.WriteLine($"float:  {f}   (Type: {f.GetType()})");
        Console.WriteLine($"double: {d}   (Type: {d.GetType()})");
        Console.WriteLine($"decimal:{m}   (Type: {m.GetType()})");
        Console.WriteLine($"char:   '{c}' (Type: {c.GetType()})");
        Console.WriteLine($"bool:   {flag} (Type: {flag.GetType()})");
        Console.WriteLine();
        Console.WriteLine($"42 as string: \"{intToStr}\" (Type: {intToStr.GetType()})");
        Console.WriteLine($"\"3.14\" as double: {strToDouble} (Type: {strToDouble.GetType()})");
    }
}