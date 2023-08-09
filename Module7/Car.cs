namespace Module7;

public class Car<TEngine> where TEngine : Engine
{
    public TEngine Engine;

    public virtual void ChangePart<TPart>(TPart newPart) where TPart : CarPart
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