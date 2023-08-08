namespace Module7;

public class Obj3
{
    public string Name;
    public string Description;
    
    public static string Parent;
    public static int DaysInWeek;
    public static int MaxValue;

    static Obj3()
    {
        Parent = "System.Object";
        DaysInWeek = 7;
        MaxValue = 2000;
    }
}