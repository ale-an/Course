namespace Module9;

class Program2
{
    public delegate Parent HandlerMethod();

    delegate void ChildInfo(Child child);

    public static Parent ParentHandler()
    {
        return null;
    }

    public static Child ChildHandler()
    {
        return null;
    }

    static void Main2(string[] args)
    {
        ChildInfo childInfo = GetParentInfo;
        childInfo.Invoke(new Child());
        Console.Read();
    }

    public static void GetParentInfo(Parent g)
    {
        Console.WriteLine(g.GetType());
    }
}

public class Parent
{
}

public class Child : Parent
{
}