using Microsoft.VisualBasic.FileIO;

namespace DirectoryManager
{
    class Program
    {
        static void Main(string[] args)
        {
            GetCatalogs();
        }

        static void GetCatalogs()
        {
            string dirName = "C:\\";
            if (Directory.Exists(dirName))
            {
                DirectoryInfo dirInfo = new DirectoryInfo(dirName + "newFolder");
                
                if(!dirInfo.Exists)
                    dirInfo.Create();

                string[] dirs = Directory.GetDirectories(dirName);
                var dirsLength = dirs.Length;
                
                string[] files = Directory.GetFiles(dirName);
                var filesLength = files.Length;
                var sum = dirsLength + filesLength;
                Console.WriteLine($"Всего {sum} файлов и папок");
                
                dirInfo.Delete(true);
            }
        }

        static void NewFolder()
        {
            var dirName = "C:\\Users\\tipoy\\Desktop\\";
            DirectoryInfo dirInfo = new DirectoryInfo(dirName + "testFolder");
                
            if(!dirInfo.Exists)
                dirInfo.Create();
            
            FileSystem.DeleteDirectory(dirInfo.FullName, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
        }
    }
}