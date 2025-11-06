class Program
{
    static void Main()
    {
        DateTime birthDate = new DateTime(1995, 7, 15);
        DateTime currentDate = DateTime.Now;

        TimeSpan ageSpan = currentDate - birthDate;
        int ageInYears = (int)(ageSpan.Days / 365.25);

        Console.WriteLine($"Birthdate: {birthDate:yyyy-MM-dd}");
        Console.WriteLine($"Current date: {currentDate:yyyy-MM-dd HH:mm:ss}");
        Console.WriteLine($"Age: {ageInYears} years");

        DateTime tenDaysLater = birthDate.AddDays(10);
        Console.WriteLine($"10 days after birthdate: {tenDaysLater:yyyy-MM-dd}");
    }
}