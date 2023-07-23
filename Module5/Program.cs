namespace Module5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task_1();
            Task_5_1_5();
            Task_5_1_6();
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
            (string name, int age) anketa;
            Console.Write("Введите Ваше имя: ");
            anketa.name = Console.ReadLine();
            Console.Write("Введите Ваш возраст цифрами: ");
            anketa.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя: {0}", anketa.name);
            Console.WriteLine("Ваш возраст: {0}", anketa.age);

            var favcolors = new string[3];
            for (int i = 0; i < 3; i++)
            {
                favcolors[i] = ShowColor(anketa.name);
            }

            Console.WriteLine("Ваши любимые цвета ");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(favcolors[i]);
            }
        }

        private static string ShowColor(string name)
        {
            Console.WriteLine($"{name}, напишите свой любимый цвет на английском с маленькой буквы");
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

        private static void Task_5_1_6()
        {
            var array = GetArrayFromConsole();
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        static int[] GetArrayFromConsole()
        {
            var result = new int[5];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            Sort(result);

            return result;
        }

        private static void Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        var t = arr[i];
                        arr[i] = arr[j];
                        arr[j] = t;
                    }
                }
            }
        }
    }
}