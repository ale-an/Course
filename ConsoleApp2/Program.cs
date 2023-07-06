namespace ConsoleApp2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Задания();
            Анкета();
            Цвета();
            Задание3_6_8();
            Анкета_2();
        }

        public static void Задания()
        {
            const string MyName = "Jane";

            Console.WriteLine(MyName);

            Console.WriteLine("\t Привет Мир");
            Console.WriteLine("\t Мне 27 лет");
            Console.WriteLine("\t My name is \n {0}", MyName);
            Console.WriteLine("\u0023");
            Console.ReadKey();
        }

        public static void Анкета()
        {
            const string MyName = "Alena";
            Console.WriteLine("My name is " + MyName);

            byte MyAge = 23;
            Console.WriteLine("My age is " + MyAge);

            bool HaveIApet = false;
            Console.WriteLine("Do I have a pet? " + HaveIApet);

            float MyShoeSize = 38;
            Console.WriteLine("My shoe size is " + MyShoeSize);
        }
        public static void Цвета()
        {
            Console.WriteLine(Semaphore.Red);
            Console.WriteLine(Semaphore.Yellow);
            Console.WriteLine(Semaphore.Green);
        }
        private static void Задание3_6_8()
        {
            double result = 10 % 3;
            Console.WriteLine(result);
            Console.ReadKey();
        }
        private static void Анкета_2()
        {
            Console.WriteLine("Введите имя: ");
            var name = Console.ReadLine();
            Console.WriteLine("Введите возраст: ");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ваше имя - {0} и ваш возраст {1} ", name, age);
            Console.WriteLine("Введите дату рождения: ");
            var birthday = Console.ReadLine();
            Console.WriteLine($"Дата вашего рождения - {birthday}");
        }
    }


    enum Semaphore
    {
        Red = 100,
        Yellow = 200,
        Green = 300
    }


}
