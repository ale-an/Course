namespace Module8;

public class Disk
{
    public string Name { get; set; }
    public double Capacity { get; set; }
    public double FreeSpace { get; set; }

    public Disk(string name, double capacity, double freeSpace)
    {
        Name = name;
        Capacity = capacity;
        FreeSpace = freeSpace;
    }
}