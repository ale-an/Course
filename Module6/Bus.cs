namespace Module6;

public class Bus
{
    public int? Load;

    public void PrintStatus()
    {
        if (Load.HasValue && Load > 0)
        {
            Console.WriteLine($"В автобусе {Load.Value} пассажиров");
        }
        else
        {
            Console.WriteLine("Автобус пуст!");
        }
    }
}