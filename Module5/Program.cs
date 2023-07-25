namespace Module5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task_1();
            Task_5_1_5();
            Task_5_1_6();
            Task_5_2_18();
            Task_5_3_1();
            Task_5_5_3();
            Task_5_5_8();
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
                favcolors[i] = ShowColor(anketa.name, anketa.age);
            }

            Console.WriteLine("Ваши любимые цвета ");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(favcolors[i]);
            }
        }

        private static string ShowColor(string name, int age)
        {
            Console.WriteLine($"{name}, {age} лет, \nНапишите свой любимый цвет на английском с маленькой буквы");
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
            var num = 6;
            var result = GetArray(ref num);

            // Sort(result);

            return result;
        }

        private static int[] GetArray(ref int num)
        {
            var result = new int[num];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            return result;
        }

        private static void Sort(int[] arr, out int[] desc, out int[] asc)
        {
            desc = SortDesc(arr);
            asc = SortAsc(arr);
        }

        private static int[] SortAsc(int[] arr)
        {
            var temp = arr;
            for (int i = 0; i < temp.Length; i++)
            {
                for (int j = 0; j < temp.Length; j++)
                {
                    if (temp[i] < temp[j])
                    {
                        var t = temp[i];
                        temp[i] = temp[j];
                        temp[j] = t;
                    }
                }
            }

            return temp;
        }

        private static int[] SortDesc(int[] arr)
        {
            var temp = arr;
            for (int i = 0; i < temp.Length; i++)
            {
                for (int j = 0; j < temp.Length; j++)
                {
                    if (temp[i] > temp[j])
                    {
                        var t = temp[i];
                        temp[i] = temp[j];
                        temp[j] = t;
                    }
                }
            }

            return temp;
        }

        private static void Task_5_2_18()
        {
            var num = 10;
            var array = GetArray(ref num);
            ShowArray(array, true);
        }

        static void ShowArray(int[] array, bool flag = false)
        {
            var temp = array;
            if (flag)
            {
                // Sort(temp);
            }

            foreach (var item in temp)
            {
                Console.WriteLine(item);
            }
        }

        private static void Task_5_3_1()
        {
            var age = 0;
            ChangeAge(ref age);
            Console.WriteLine(age);
        }

        private static void ChangeAge(ref int age)
        {
            age += 1;
        }

        private static void Task_5_5_3()
        {
            Console.WriteLine("Напишите что-то");
            var str = Console.ReadLine();

            Console.WriteLine("Укажите глубину эха");
            var deep = int.Parse(Console.ReadLine());

            Echo(str, deep);

            Console.ReadKey();
        }

        static void Echo(string saidworld, int deep)
        {
            Console.BackgroundColor = (ConsoleColor) deep;
            var modif = saidworld;
            if (modif.Length > 2)
            {
                modif = modif.Remove(0, 2);
            }

            Console.WriteLine($"...{modif}");

            if (deep > 1)
            {
                Echo(modif, deep - 1);
            }
        }

        private static void Task_5_5_8()
        {
            Console.WriteLine(PowerUp(2, 10));
        }

        private static int PowerUp(int N, byte pow)
        {
            if (pow == 0)
            {
                return 1;
            }
            else
            {
                if (pow == 1)
                {
                    return N;
                }
                else
                {
                    return N * PowerUp(N, --pow);
                }
            }
        }
    }
}