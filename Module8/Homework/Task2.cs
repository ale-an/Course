namespace Module8.Homework;

public class Task2
{
    public long CountsTheSize(string path)
    {
        long result = 0;

        try
        {
            if (Directory.Exists(path))
            {
                var dirInfo = new DirectoryInfo(path);
                var files = dirInfo.GetFiles();

                foreach (var file in files)
                {
                    result += file.Length;
                }

                foreach (var directoryInfo in dirInfo.GetDirectories())
                {
                    result += CountsTheSize(directoryInfo.FullName);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }

        return result;
    }
}