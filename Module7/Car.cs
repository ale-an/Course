namespace Module7;

public class Car<T1>
{
    public T1 Engine;

    public virtual void ChangePart<T2>(T2 newPart)
    {
    }
}

public class ElectricEngine
{
}

public class GasEngine
{
}

public class Battery
{
}

public class Differential
{
}

public class Wheel
{
}