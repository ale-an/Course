namespace Module8.Homework;

public class Task3
{
    public void Cleaning(string path)
    {
        try
        {
            if (Directory.Exists(path))
            {
                var task1 = new Task1();
                var task2 = new Task2();

                var size = task2.CountsTheSize(path);
                task1.RemoveFiles(path);
                var size2 = task2.CountsTheSize(path);

                Console.WriteLine($"Исходный размер папки: {size}");
                Console.WriteLine($"Освобождено: {size - size2}");
                Console.WriteLine($"Текущий размер папки: {size2}");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}