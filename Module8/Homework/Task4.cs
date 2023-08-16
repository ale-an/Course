using System.Runtime.Serialization.Formatters.Binary;

namespace FinalTask;

public class Task4
{
    [Obsolete("Obsolete")]
    public void Download()
    {
        var path = "C:\\Users\\tipoy\\Desktop\\";
        BinaryFormatter formatter = new BinaryFormatter();
        Student[] students;
        using (var fs = new FileStream($"{path}/Students.dat", FileMode.OpenOrCreate))
        {
            students = (Student[]) formatter.Deserialize(fs);
        }

        var studentDirectory = new DirectoryInfo($"{path}/Students");
        
        if(studentDirectory.Exists)
            studentDirectory.Create();
            
        foreach (var student in students)
        {
            string studentGroup = $"{path}/Students/{student.Group}.txt";

            using (FileStream fs = new FileStream(studentGroup, FileMode.OpenOrCreate))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine($"{student.Name}, {student.DateOfBirth}");
                }
            }
        }
    }
}

[Serializable]
public class Student
{
    public string Name { get; set; }
    public string Group { get; set; }
    public DateTime DateOfBirth { get; set; }
}