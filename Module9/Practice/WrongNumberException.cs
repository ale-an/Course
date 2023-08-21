namespace Module9.Practice;

public class WrongNumberException : Exception
{
    public WrongNumberException()
    {
    }

    public WrongNumberException(string message)
        : base(message)
    {
    }
}
