namespace Module7;

public class Obj2
{
    public int Value;

    public static Obj2 operator +(Obj2 source, Obj2 target)
    {
        return new Obj2()
        {
            Value = source.Value + target.Value
        };
    }
    
    public static Obj2 operator -(Obj2 source, Obj2 target)
    {
        return new Obj2()
        {
            Value = source.Value - target.Value
        };
    }
}