namespace Module9;

class Program1
{
    public delegate Car HandlerMethod();

    public static Car CarHandler()
    {
        return null;
    }

    public static Lexus LexusHandler()
    {
        return null;
    }

    static void Main1(string[] args)
    {
        HandlerMethod handlerCar = LexusHandler;
        Console.Read();
    }

    public class Car
    {
    }

    public class Lexus : Car
    {
    }
}