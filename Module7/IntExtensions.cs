namespace Module7;

public static class IntExtensions
{
    public static int GetNegative(this int source)
    {
        return source > 0 ? source * -1 : source;
    }
    public static int GetPositive(this int source)
    {
        return source < 0 ? source * -1 : source;
    }
}