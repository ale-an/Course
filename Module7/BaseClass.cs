namespace Module7;

class BaseClass
{
    protected string Name;

    public BaseClass(string name)
    {
        Name = name;
    }
}

class DerivedClass : BaseClass
{
    public string Description;

    public int Counter;

    public DerivedClass(string name, string description) : base(name)
    {
        Description = description;
    }

    public DerivedClass(string name, string description, int counter) : base(name)
    {
        Description = description;
        Counter = counter;
    }
}