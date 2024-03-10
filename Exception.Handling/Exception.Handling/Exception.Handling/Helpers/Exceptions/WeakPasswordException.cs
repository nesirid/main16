public class WeakPasswordException : Exception
{
    public WeakPasswordException(string message) : base(message)
    {
        Console.WriteLine("Parol ve ya Email duzgun daxil olunmadi");
    }
}