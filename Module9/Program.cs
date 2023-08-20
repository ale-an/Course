namespace Module9
{
    class Program
    {
        static void Main(string[] args)
        {
            Exception exception = new Exception("Всё плохо. Но дело не в Вас...");
            exception.Data.Add("Дата создания исключения : ", DateTime.Now);
            exception.HelpLink = "www.bing.com";
        }
    }
}