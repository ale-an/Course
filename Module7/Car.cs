namespace Module7;

public abstract class Car<TEngine> where TEngine : Engine
{
    public TEngine Engine;

    public abstract void ChangePart<TPart>(TPart newPart) where TPart : CarPart;
}

public class ElectricCar : Car<ElectricEngine>
{
    public override void ChangePart<TPart>(TPart newPart)
    {
    }
}

public class GasCar : Car<GasEngine>
{
    public override void ChangePart<TPart>(TPart newPart)
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