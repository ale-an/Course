namespace Module7;

public class Car<T1> where T1 : Engine
{
    public T1 Engine;

    public virtual void ChangePart<T2>(T2 newPart) where T2 : CarPart
    {
    }
}

public abstract class Engine
{
}

public class ElectricEngine : Engine
{
}

public class GasEngine : Engine
{
}

public abstract class CarPart
{
}

public class Battery : CarPart
{
}

public class Differential : CarPart
{
}

public class Wheel : CarPart
{
}