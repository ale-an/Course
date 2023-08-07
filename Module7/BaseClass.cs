using System.Diagnostics;

namespace Module7;

class BaseClass
{
    protected string Name;
    public virtual int Counter { get; set; }

    public BaseClass(string name)
    {
        Name = name;
    }

    public virtual void Display()
    {
        Console.WriteLine("Метод класса BaseClass");
    }
}

class DerivedClass : BaseClass
{
    public string Description;

    private int counter;
    public override int Counter
    {
        get { return counter; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Число должно быть больше нуля");
            }
            else
            {
                counter = value;
            }
        }
    }

    public DerivedClass(string name, string description) : base(name)
    {
        Description = description;
    }

    public DerivedClass(string name, string description, int counter) : base(name)
    {
        Description = description;
        Counter = counter;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine("Метод класса DerivedClass");
    }
}