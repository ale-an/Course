namespace Module7;

public abstract class ComputerPart
{
    public abstract void Work();
}

class Processor : ComputerPart
{
    public override void Work()
    {
    }
}

class MotherBoard : ComputerPart
{
    public override void Work()
    {
    }
}

class GraphicCard : ComputerPart
{
    public override void Work()
    {
    }
}