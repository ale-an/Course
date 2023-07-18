using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace Module4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task_4_1_4();
            Task_4_1_5();
            Task_4_1_12();
            Task_4_1_17();
            Task_4_1_18();
            Task_4_2_11();
            Task_Evgenia();
            Task_4_3_7();
            Task_4_3_11();
            Task_4_3_12();
            Task_4_3_13();
            Task_4_3_14();
            Task_4_3_15();
            Task_4_3_16();
            Task_4_3_17();
            Task_4_4_2();
            Task_4_4_3();
            Task_4_4_5();
            Workshop();
        }

        private static void Task_4_1_4()
        {
            string A;
            string B;
            //bool C = A != B;
        }

        private static void Task_4_1_5()
        {
            int A;
            int B;
            double X;
            double Y;
            //bool C = (A < B) | (X > Y);
        }

        private static void Task_4_1_12()
        {
            var a = 7;
            var b = 7;

            if (a == b)
            {
                Console.WriteLine("Условие истинно");
            }
            else
            {
                Console.WriteLine("Условие ложно");
            }

            ;
        }

        private static void Task_4_1_17()
        {
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

            var color = Console.ReadLine();

            if (color == "red")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is red!");
            }

            else if (color == "green")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is green!");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");
            }

            ;
        }

        private static void Task_4_1_18()
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

                    Console.WriteLine("Your color is cyan!");
                    break;
            }
        }

        private static void Task_4_2_11()
        {
            int t = 0;

            do
            {
                Console.WriteLine(t);

                Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
                switch (Console.ReadLine())
                {
                }

                t++;
            } while (t < 3);
        }

        private static void Task_Evgenia()
        {
            Console.WriteLine("Напишите своё имя");
            var name = Console.ReadLine();
            Console.WriteLine("Ваше имя по буквам: ");

            foreach (var symbol in name)
            {
                Console.Write(symbol + " ");
            }

            char last = name[name.Length - 1];
            Console.WriteLine("Последняя буква - " + last);
        }

        private static void Task_4_3_7()
        {
            Console.WriteLine("Напишите своё имя");
            var name = Console.ReadLine();
            Console.WriteLine("Ваше имя по буквам: ");
            for (int i = 1; i <= name.Length; i++)
            {
                Console.Write(name[name.Length - i] + " ");
            }
        }

        private static void Task_4_3_11()
        {
            int[,] array = {{1, 2, 3}, {5, 6, 7}, {8, 9, 10}, {11, 12, 13}};

            for (int i = 0; i < array.GetUpperBound(1) + 1; i++)
            {
                for (int k = 0; k < array.GetUpperBound(0) + 1; k++)
                    Console.Write(array[k, i] + " ");

                Console.WriteLine();
            }
        }

        private static void Task_4_3_12()
        {
            var arr = new int[] {5, 6, 9, 1, 2, 3, 4};

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

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

            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        private static void Task_4_3_13()
        {
            var arr = new int[] {5, 6, 9, 1, 2, 3, 4};
            var result = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i];
            }

            Console.WriteLine(result);
        }

        private static void Task_4_3_14()
        {
            int[][] array = new int[3][];

            array[0] = new int[2] {1, 2};
            array[1] = new int[3] {1, 2, 3};
            array[2] = new int[5] {1, 2, 3, 4, 5};

            foreach (var num in array)
            {
                foreach (var item in num)
                {
                    Console.Write(item + " ");
                }
            }
        }

        private static void Task_4_3_15()
        {
            int r = 0;
            var arr = new int[] {-5, -6, -9, 1, 2, 3, 4};
            foreach (var number in arr)
            {
                if (number > 0)
                    r++;
            }

            Console.WriteLine(r);
        }

        private static void Task_4_3_16()
        {
            int r = 0;
            int[,] arr = {{-5, 6, 9, 1, 2, -3}, {-8, 8, 1, 1, 2, -3}};
            foreach (var number in arr)
            {
                if (number > 0)
                    r++;
            }

            Console.WriteLine(r);
        }

        private static void Task_4_3_17()
        {
            int[,] arr = {{-5, 6, 9, 1, 2, -3}, {-8, 8, 1, 1, 2, -3}};
            for (int i = 0; i < arr.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < arr.GetUpperBound(1) + 1; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }

                Console.WriteLine();
            }

            for (int k = 0; k <= arr.GetUpperBound(0); k++)
            {
                for (int i = 0; i <= arr.GetUpperBound(1); i++)
                {
                    for (int j = 0; j <= arr.GetUpperBound(1); j++)
                    {
                        if (arr[k, i] > arr[k, j])
                        {
                            var t = arr[k, i];
                            arr[k, i] = arr[k, j];
                            arr[k, j] = t;
                        }
                    }
                }
            }

            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }

                Console.WriteLine();
            }
        }

        private static void Task_4_4_2()
        {
            (string name, int age) anketa;
            Console.Write("Введите Ваше имя: ");
            anketa.name = Console.ReadLine();
            Console.Write("Введите Ваш возраст цифрами: ");
            anketa.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя: {0}", anketa.name);
            Console.WriteLine("Ваш возраст: {0}", anketa.age);
        }

        private static void Task_4_4_3()
        {
            var (name, age) = ("Алена", 24);
            Console.WriteLine("Мое имя: {0}", name);
            Console.WriteLine("Мой возраст: {0}", age);

            Console.Write("Введите имя: ");
            name = Console.ReadLine();
            Console.Write("Введите возраст с цифрами: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя: {0}", name);
            Console.WriteLine("Ваш возраст: {0}", age);
        }

        private static void Task_4_4_5()
        {
            (string Name, string Type, double Age, int NameCount) Pet;

            Console.Write("Введите имя булочки ");
            Pet.Name = Console.ReadLine();
            Pet.NameCount = Pet.Name.Length;

            Console.Write("Введите породу булочки ");
            Pet.Type = Console.ReadLine();

            Console.Write("Введите возраст булочки ");
            Pet.Age = Convert.ToDouble(Console.ReadLine());
            Console.Write("Длина имени Вашей булочки " + Pet.NameCount);
        }

        private static void Workshop()
        {
            for (int j = 0; j < 3; j++)
            {
                (string Name, string LastName, string Login, int LoginLength, bool HasPet, string[] favcolors, double
                    Age) User;

                Console.WriteLine("Введите имя");
                User.Name = Console.ReadLine();

                Console.WriteLine("Введите фамилию");
                User.LastName = Console.ReadLine();

                Console.WriteLine("Введите логин");
                User.Login = Console.ReadLine();
                User.LoginLength = User.Login.Length;

                Console.WriteLine("Длина вашего логина " + User.LoginLength);

                Console.WriteLine("Есть ли у вас животные? Да или Нет");
                var answer = Console.ReadLine();
                if (answer == "Да")
                {
                    User.HasPet = true;
                }
                else
                {
                    User.HasPet = false;
                }

                Console.WriteLine("Введите возраст пользователя");
                User.Age = Convert.ToDouble(Console.ReadLine());

                User.favcolors = new string[3];
                Console.WriteLine("Введите три любимых цвета пользователя");
                for (int i = 0; i < 3; i++)
                {
                    User.favcolors[i] = Console.ReadLine();
                }
            }
        }
    }
}