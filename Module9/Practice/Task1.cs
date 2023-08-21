namespace Module9.Practice;

public class Task1
{
    private Exception[] exceptions = new Exception[5]
    {
        new ArgumentNullException("Аргумент, передаваемый в метод - пустой"),
        new NotSupportedException("Метод или операция не поддерживается"),
        new FormatException(
            "Значение не находится в соответствующем формате для преобразования из строки методом преобразования"),
        new DirectoryNotFoundException("Нет доступа"),
        new WrongNumberException("Число неккоректно")
    };

    public void Task()
    {
        foreach (var exception in exceptions)
        {
            try
            {
                throw exception;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}