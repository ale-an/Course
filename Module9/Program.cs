namespace Module9
{
    class Program
    {
        static void Main(string[] args)
        {
            Task_9_1_4();
            Task_9_2_2();
        }

        static void Task_9_1_4()
        {
            Exception exception = new Exception("Всё плохо. Но дело не в Вас...");
            exception.Data.Add("Дата создания исключения : ", DateTime.Now);
            exception.HelpLink = "www.bing.com";
        }

        private static void Task_9_2_2()
        {
            try
            {
                throw new ArgumentOutOfRangeException($"Произошла ошибка!");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.Read();
            }
        }
    }
}