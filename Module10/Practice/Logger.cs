namespace Module10.Practice;

public class Logger : ILogger
{
    public void Event(string message)
    {
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(message);
    }

    public void Error(string message)
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(message);
    }
}

public interface ILogger
{
    void Event(string message);
    void Error(string message);
}