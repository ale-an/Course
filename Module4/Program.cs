﻿using System.Diagnostics;
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
                switch (Console.ReadLine()) { }

                t++;
            }
            while (t < 3); 
       
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
    }
}