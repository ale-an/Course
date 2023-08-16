using Microsoft.VisualBasic.FileIO;
using System;
using System.IO;

namespace DirectoryManager
{
    class Program
    {
        static void Main(string[] args)
        {
            // GetCatalogs();
            // Task_8_3_1();
            // Task_8_4_1();
            Task_8_4_2();
        }


        static void GetCatalogs()
        {
            string dirName = "C:\\";
            if (Directory.Exists(dirName))
            {
                DirectoryInfo dirInfo = new DirectoryInfo(dirName + "newFolder");

                if (!dirInfo.Exists)
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

            if (!dirInfo.Exists)
                dirInfo.Create();

            FileSystem.DeleteDirectory(dirInfo.FullName, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
        }

        private static void Task_8_3_1()
        {
            string filePath = @"C:\Users\tipoy\source\repos\Course\Module8\Program.cs";
            using (StreamReader sr = File.OpenText(filePath))
            {
                string str = "";
                while ((str = sr.ReadLine()) != null)
                {
                    Console.WriteLine(str);
                }
            }

            var fileInfo = new FileInfo(filePath);
            using (StreamWriter sw = fileInfo.AppendText())
            {
                sw.WriteLine($"//{DateTime.Now}");
            }
        }

        private static void Task_8_4_1()
        {
            string settingsFileName = "C:\\Users\\tipoy\\Desktop\\BinaryFile.bin";
            if (File.Exists(settingsFileName))
            {
                using (BinaryReader reader = new BinaryReader(File.Open(settingsFileName, FileMode.Open)))
                {
                    var stringValue = reader.ReadString();
                    Console.WriteLine(stringValue);
                }
            }
        }

        private static void Task_8_4_2()
        {
            string settingsFileName = "C:\\Users\\tipoy\\Desktop\\BinaryFile.bin";
            using (BinaryWriter writer = new BinaryWriter(File.Open(settingsFileName, FileMode.Create)))
            {
                writer.Write($"Файл изменен {DateTime.Now} на компьютере {Environment.OSVersion}");
            }
        }
    }
}