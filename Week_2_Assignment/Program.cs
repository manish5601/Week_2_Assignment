class Program
{
    static void Main()
    {
        int[] favoriteNumbers = { 7, 3, 9, 1, 5 };

        Array.Sort(favoriteNumbers);
        Array.Reverse(favoriteNumbers);

        Console.WriteLine("Array elements:");
        for (int i = 0; i < favoriteNumbers.Length; i++)
        {
            Console.WriteLine(favoriteNumbers[i]);
        }

        int numberToFind = 3;
        int index = Array.IndexOf(favoriteNumbers, numberToFind);
        Console.WriteLine($"\nPosition of {numberToFind}: {index} (0-based index)");
    }
}