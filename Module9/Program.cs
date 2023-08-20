namespace Module9
{
    class Program
    {
        static void Main(string[] args)
        {
            Exception exception = new Exception();
            exception.Data.Add("Дата создания исключения : ", DateTime.Now);
        }
    }
}