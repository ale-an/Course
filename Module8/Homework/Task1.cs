namespace Module8.Homework;

public class Task1
{
    public void RemoveFiles(string path)
    {
        try
        {
            if (Directory.Exists(path))
            {
                var files = Directory.GetFiles(path);
                foreach (var file in files)
                {
                    var fileInfo = new FileInfo(file);
                    if ((DateTime.Now - fileInfo.LastAccessTime).TotalMinutes > 30)
                    {
                        fileInfo.Delete();
                    }
                }

                var folders = Directory.GetDirectories(path);
                foreach (var folder in folders)
                {
                    var folderInfo = new DirectoryInfo(folder);
                    if ((DateTime.Now - folderInfo.LastAccessTime).TotalMinutes > 30)
                    {
                        folderInfo.Delete(true);
                    }
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}