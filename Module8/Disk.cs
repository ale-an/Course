namespace Module8;

public class Disk
{
    public string Name { get; set; }
    public double Capacity { get; set; }
    public double FreeSpace { get; set; }
    
    public List<Folder> Folders { get; set; } = new List<Folder>();

    public Disk(string name, double capacity, double freeSpace)
    {
        Name = name;
        Capacity = capacity;
        FreeSpace = freeSpace;
    }

    public void CreateFolder(string name)
    {
        Folders.Add(new Folder()
        {
            Name = name
        });
        Console.WriteLine("Папка создана");
    }
}
