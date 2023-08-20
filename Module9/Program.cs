namespace Module9
{
    class Program
    {
        delegate int SupDelegate(int a, int b);

        delegate void ShowDelegate(int q, int w);

        static void Main(string[] args)
        {
            Task_9_1_4();
            Task_9_2_2();
            Task_9_2_3();

            SupDelegate supDelegate = Task_9_3_2;
            int c = supDelegate.Invoke(6, 5);
            int d = supDelegate(6, 5);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.Read();

            ShowDelegate showDelegate = Subtraction;
            showDelegate += Summation;
            showDelegate -= Summation;
            showDelegate.Invoke(1, 2);
            Console.Read();
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

        private static void Task_9_2_3()
        {
            try
            {
                throw new RankException($"Произошла ошибка!");
            }
            catch (RankException ex)
            {
                Console.WriteLine(ex.GetType());
            }
            finally
            {
                Console.Read();
            }
        }

        private static int Task_9_3_2(int a, int b)
        {
            return a - b;
        }

        private static void Subtraction(int q, int w)
        {
            Console.WriteLine(q - w);
        }

        private static void Summation(int q, int w)
        {
            Console.WriteLine(q + w);
        }
    }
}