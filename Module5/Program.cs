namespace Module5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task_1();
        }

        private static void Task_1()
        {
            (string Name, string[] Dishes) User;

            Console.Write("Введите имя пользователя ");
            User.Name = Console.ReadLine();

            User.Dishes = new string[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Введите любимое блюдо номер {i + 1}");
                User.Dishes[i] = Console.ReadLine();
            }
        }
    }
}