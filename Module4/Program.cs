using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace Module4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task_4_1_4();
            // Task_4_1_5();
            // Task_4_1_12();
            // Task_4_1_17();
            // Task_4_1_18();
            // Task_4_2_11();
            // Task_Evgenia();
            // Task_4_3_7();
            // Task_4_3_11();
            // Task_4_3_12();
            // Task_4_3_13();
            // Task_4_3_14();
            // Task_4_3_15();
            // Task_4_3_16();
            Task_4_3_17();
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
    }
}