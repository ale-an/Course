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
            };
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
            };
        }

    }
}