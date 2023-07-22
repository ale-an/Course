namespace Module5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task_1();
            Task_5_1_5();
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

        private static void Task_5_1_5()
        {
            var favcolors = new string[3];
            for (int i = 0; i < 3; i++)
            {
                favcolors[i] = ShowColor();
            }
            Console.WriteLine("Ваши любимые цвета ");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(favcolors[i]);
            }
        }
        private static string ShowColor()
        {
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
            var color = Console.ReadLine();

            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }

            return color;
        }
    }
}